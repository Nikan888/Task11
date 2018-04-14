using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Task11
{
    internal class TextTransformer
    {
        public IEnumerable<Char> SetCharToUpperCase(string input)
        {
            foreach (char ch in input)
            {
                yield return Char.ToUpper(ch);
            }
        }

        public string SetSomethingVariable(ref string str)
        {
            str = "/something_variable/";
            return str;
        }

        public List<string> SetMessageToUpperCase(List<string> message)
        {
            string test = "";

            for (int i = 0; i < message.Count; i++)
            {
                if (string.IsNullOrEmpty(message[i]))
                {
                    test = message[i];
                    SetSomethingVariable(ref test);
                    message[i] = test;
                }
                else
                {
                    message[i] = new string(SetCharToUpperCase(message[i]).ToArray());
                }
            }
            return message;
        }
    }
}
