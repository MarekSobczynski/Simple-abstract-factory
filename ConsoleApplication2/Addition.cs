using System;
using System.IO;

namespace ConsoleApplication2
{
    public class Addition : AbstractMathematicalOperation
    {
        public override void Proceed(int a , int b, string path)
        {
            StreamWriter streamWriter = File.AppendText(path);
            
            string name = GetName();
            int c = a + b;
            streamWriter.WriteLine("{0} ; {1} ; {2} ; {3} ; {4} ; {5} ; {6} ; {7} ", "name:", name, "number A:", a ,"number B:", b ,"score:",c );
            streamWriter.Close();
            Console.WriteLine(c);
        }

        public override string GetName()
        {
            string name = typeof(Addition).Name;
            return name;
        }
    }
}