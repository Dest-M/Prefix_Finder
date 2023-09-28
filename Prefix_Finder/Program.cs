using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anna_25_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool found = false;
            bool err = false;
            List<string> list = new List<string>() { "flower", "flour", "fly" };
            List<string> list2 = new List<string>() { "book", "bookend", "books" };
            List<string> list3 = new List<string>() { "fook", "hookend", "books" };

            List<string> use = list;  //assign a different list to 'use' if needed
            var prefix = use.OrderBy(x => x.Length).First();
            string pre = prefix;

            while (!err && !found)
            {
                foreach (var a in use)
                {
                    if (a.Contains(pre))
                    {
                        found = true;
                    }
                    else
                    {
                        found = false;
                        if (pre != pre[0].ToString())
                        {
                            pre = pre.Substring(0, pre.Length - 1);

                        }
                        else
                        {
                            err = true;
                            break;

                        }
                    }
                }

            }
            if (err)
            {
                Console.WriteLine("No prefix found");
            }
            else if (found)
            {
                Console.WriteLine("Prefix is: " + pre);
            }
            else
            {
                Console.WriteLine("An error occured");
            }
        }
    }
}

