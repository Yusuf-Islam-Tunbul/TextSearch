using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220215_Quiz2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "alabalık";

            string fragment = "a";

            string copy_text = text;

            int i = 0;

            try
            {
                while (true)
                {
                    copy_text = copy_text.Remove(copy_text.IndexOf(fragment), 1);
                    i++;
                }
            }
            catch
            {
                if (i == 0)
                {
                    Console.WriteLine($"{text} metninde {fragment} hiç geçmemektedir.");
                }

                else
                {
                    Console.WriteLine($"{text} metninde {fragment} {i} kez geçmektedir.");
                }                
            }

            Console.WriteLine("Çıkmak için herhangi bir tuşa basınız.");
            Console.ReadKey();
        }
    }
}
