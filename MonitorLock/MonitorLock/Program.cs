using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MonitorLock
{
    public class Account
    {
        Object customLock = new Object();
        Random random = new Random();
        private int balance;
        public Account(int _balance)
        {
            this.balance = _balance;
        }

        public void WithdrawRandomly()
        {
            for (int i = 0; i < 100; i++)
            {
                var balance = Withdraw(random.Next(2000, 5000));
                if (balance > 0)
                {
                    Console.WriteLine("current thread id: {0}", Thread.CurrentThread.ManagedThreadId);
                    Console.WriteLine("Balance left: " + balance);
                }

            }
        }

        public int Withdraw(int amount)
        {
            if (balance < 0)
            {
                throw new Exception("Not enough money");
            }
            Monitor.Enter(customLock);
            try
            {
                if (balance >= amount)
                {
                    Console.WriteLine("The withdrawn amount is: " + amount);
                    balance -= amount;

                    return balance;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Monitor.Exit(customLock);
            }
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(20000);
            Task task1 = Task.Factory.StartNew(() => account.WithdrawRandomly());
            Task task2 = Task.Factory.StartNew(() => account.WithdrawRandomly());
            Task task3 = Task.Factory.StartNew(() => account.WithdrawRandomly());
            Task.WaitAll(task1, task2, task3);
            Console.WriteLine("All tasks are completed");

            Console.Read();
        }
    }
}
