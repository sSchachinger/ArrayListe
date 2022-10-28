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

            string path = "C:\\Users\\Simon&Tanja\\source\\repos\\ArrayListe\\ArrayListe\\german.dic";
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
            gd.linkedList = fh.readFileToLinked();
            swLinked.Stop();

            Console.WriteLine($"Dauer des Einlesens bei einem Array:{swArray.ElapsedMilliseconds}");
            Console.WriteLine($"Länge:{gd.arrayList.Count}");
            Console.WriteLine($"Dauer des Einlesens bei einer Linked:{swLinked.ElapsedMilliseconds}\n");
            Console.WriteLine($"Länge:{gd.linkedList.length}");

            swArray.Reset();
            swLinked.Reset();


            swArray.Start();
            int length = gd.arrayList.Count;
            swArray.Stop();
            swLinked.Start();
            length = gd.linkedList.Count();
            swLinked.Stop();

            Console.WriteLine($"Dauer der Count-Funktion bei einem Array:{swArray.ElapsedMilliseconds}");
            Console.WriteLine($"Dauer der Count-Funktion bei einer Linked:{swLinked.ElapsedMilliseconds}\n");

            swArray.Reset();
            swLinked.Reset();

            swArray.Start();
            string arrayReturn = gd.arrayList.Indexer(gd.linkedList.length / 2);//gd.arrayList.Count / 2);
            swArray.Stop();
            swLinked.Start();
            string linkedReturn = gd.linkedList.FindbyIndex(gd.arrayList.Count / 2);// gd.linkedList.length / 2 +1);
            swLinked.Stop();
            Console.WriteLine($"Dauer der Indexer für  {gd.linkedList.length / 2} ist der Wert {arrayReturn} bei einem Array:{swArray.ElapsedMilliseconds}");
            Console.WriteLine($"Dauer der FindbyIndex für {gd.arrayList.Count / 2} ist der Wert {linkedReturn} bei einer Linked:{swLinked.ElapsedMilliseconds}\n");



            Console.ReadLine();
        }
    }
}
