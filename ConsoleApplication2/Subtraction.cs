
using System.IO;

namespace ConsoleApplication2
{
    public class Subtraction : AbstractMathematicalOperation
    {
        public override void Proceed(int a , int b, string path)
        {
            string name = GetName();
            StreamWriter streamWriter = File.AppendText(path);
            int c = a - b;
            streamWriter.WriteLine("{0} ; {1} ; {2} ; {3} ; {4} ; {5} ; {6} ; {7} ", "name:", name, "number A:", a ,"number B:", b ,"score:",c );
            streamWriter.Close();
            
        }

        public override string GetName()
        {
            string name = typeof(Subtraction).Name;
            return name;
        }
    }
}