using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskovsky_sabstitution
{
    public interface CustomParent {
        void Say();
    }

    public class CustomChild1 : CustomParent
    {
        public void Say()
        {
            Console.WriteLine("Say from Child 1");
        }
    }

    public class CustomChild2 : CustomParent 
    {
        public void Say()
        {
            Console.WriteLine("Say from Child 2");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<CustomParent> cp = new List<CustomParent>();
            cp.Add(new CustomChild1());
            cp.Add(new CustomChild1());
            cp.Add(new CustomChild2());
            cp.Add(new CustomChild1());
            cp.Add(new CustomChild2());
            cp.Add(new CustomChild1());

            foreach (var item in cp)
            {
                item.Say();
            }
            Console.Read();
        }
    }
}
