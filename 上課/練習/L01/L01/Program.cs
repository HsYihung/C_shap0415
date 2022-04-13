using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("using ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("System;");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("using ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("System.Collections.Generic;");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("using ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("System.Linq;");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("using ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("System.Text;");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("using ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("System.Threading.Tasks;");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("namespace ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("ConsoleApp1");

            Console.WriteLine("{");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\tclass ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Program");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\t{");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\t\tstatic void ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Main");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("string");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[] ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("args");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(")");

            Console.WriteLine("\t\t{");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\t\t\t// 單行註解");

            Console.WriteLine("\t\t\t/*\n\t\t\t  多行註解\n\t\t\t    1234\n\t\t\tABCD\n\t\t\t +_+_+_+\n\t\t\t/*");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\t\t\tSystem.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Console");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("WritLine");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\"Hello World !!\"");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(");");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\t\t\tSystem.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Console");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("WritLine");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\"Hi, 這是第一個Console程式\"");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(");");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\tConsole");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("WritLine");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\"C# 語言第一個示範\"");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(");");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\tConsole");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("WritLine");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\"C# Demo\"");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(");");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\tConsole");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("ForegroundColor ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("= ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("ConsoleColor");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Yellow;");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\tConsole");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("BackgroundColor ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("= ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("ConsoleColor");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Blue;");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\tConsole");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("WritLine");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\"1. 主控台應用程式\"");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(");");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\tConsole");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("WritLine");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\"2. Windows Form 應用程式\"");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(");");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\tConsole");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("WritLine");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\"3. Web 應用程式\"");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(");");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\tConsole");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("WritLine");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("(");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(");");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\tConsole");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("ResetColor");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("(");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(");");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\tConsole");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("WritLine");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\"特殊字元符號\"");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(");");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\tConsole");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("WritLine");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\"");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\\"");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("雙引號");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\\"");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\"");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(");");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\tConsole");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("WritLine");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\"");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\\\");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("反斜線");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\\\");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\"");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(");");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\tConsole");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("WritLine");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\"");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\t\\t");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("縮排\"");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(");");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\tConsole");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("WritLine");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\"換行");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\\n\\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\"");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(");\n");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\t\t\tConsole");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("WritLine");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("(");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\"按Enter結束程式\"");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(");");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("\t\t\tSystem.");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Console");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(".");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("ReadLine");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("();");

            Console.WriteLine("\t\t}");
            Console.WriteLine("\t}");
            Console.WriteLine("}");

            Console.ReadLine();
        }
    }
    public class AA
    {
        public string str_Con;
        public void _Console()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("str_Con");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("")
        }
    }

}
