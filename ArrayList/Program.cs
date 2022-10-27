using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = "C:\\Users\\Simon&Tanja\\source\\repos\\Spellchecker\\Spellchecker\\german.dic";
            libLinkedList.ILinkedList<string> linkedList = new libLinkedList.LinkedList<string>();
            libArrayList.IArrayList<string> arrayList = new libArrayList.ArrayList<string>(10);

            German gd = new German();
            Filehandling fh = new Filehandling(path);

            Stopwatch swArray = new Stopwatch();
            Stopwatch swLinked = new Stopwatch();
            swArray.Start();
            gd.arrayList = fh.readFileToArray();
            swArray.Stop();
            swLinked.Start();
            gd.linkedList=fh.readFileToLinked();
            swLinked.Stop();
            Console.WriteLine($"Dauer des einlesens bei einem Array:{swArray.ElapsedMilliseconds}");
            Console.WriteLine($"Länge:{gd.arrayList.Count}");
            Console.WriteLine($"Dauer des einlesens bei einer Linked:{swLinked.ElapsedMilliseconds}");
            Console.WriteLine($"Länge:{gd.linkedList.length}");
            Console.ReadLine();
        }
    }
}
