using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = null + "One can become a writer only if he is talented. " 
            //    + null + "" + null + "They say, the Winter will be cold." + null;
            //Regex regSplitSentence = new Regex(@"\. |\! |\? ");
            //string[] sentences = regSplitSentence.Split(str);
            //List<string> listSentence = new List<string>();
            //foreach (var s in sentences)
            //{
            //    listSentence.Add(s);
            //}
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
