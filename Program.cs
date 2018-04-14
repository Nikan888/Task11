using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            TextTransformer textTransformer = new TextTransformer();
            List<string> message = new List<string>
            {
                null,
                "One can become a writer only if he is talented.",
                null,
                "",
                null,
                "They say, the Winter will be cold.",
                null
            };
            message = textTransformer.SetMessageToUpperCase(message);
            foreach (var m in message)
            {
                Console.WriteLine(m);
            }
            Console.ReadKey();
        }
    }
}
