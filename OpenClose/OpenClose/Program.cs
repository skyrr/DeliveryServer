using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClose
{
    class Cook
    {
        public string Name { get; set; }

        public Cook(string name)
        {
            this.Name = name;
        }

        public void MakeDinner()
        {
            //Console.WriteLine("Чистим картошку");
            //Console.WriteLine("Ставим почищенную картошку на огонь");
            //Console.WriteLine("Сливаем остатки воды, разминаем варенный картофель в пюре");
            //Console.WriteLine("Посыпаем пюре специями и зеленью");
            //Console.WriteLine("Картофельное пюре готово");
            this.MakeDinner(new SaladMeal());
        }

        public void MakeDinner(IMeal meal)
        {
            meal.Make();
        }


    }

    interface IMeal
    {
        void Make();
    }
    class PotatoMeal : IMeal
    {
        public void Make()
        {
            Console.WriteLine("Чистим картошку");
            Console.WriteLine("Ставим почищенную картошку на огонь");
            Console.WriteLine("Сливаем остатки воды, разминаем варенный картофель в пюре");
            Console.WriteLine("Посыпаем пюре специями и зеленью");
            Console.WriteLine("Картофельное пюре готово");
        }
    }
    class SaladMeal : IMeal
    {
        public void Make()
        {
            Console.WriteLine("Нарезаем помидоры и огурцы");
            Console.WriteLine("Посыпаем зеленью, солью и специями");
            Console.WriteLine("Поливаем подсолнечным маслом");
            Console.WriteLine("Салат готов");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cook cook = new Cook("Vova");
            cook.MakeDinner(new PotatoMeal());
            cook.MakeDinner(new SaladMeal());

            Console.Read();
        }
    }
}
