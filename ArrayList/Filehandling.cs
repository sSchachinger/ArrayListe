using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    internal class Filehandling
    {
        private string path;
        libLinkedList.ILinkedList<string> linkedList;
        libArrayList.IArrayList<string> arraylist;

        public Filehandling(string path)
        {
            this.path = path;
            linkedList = new libLinkedList.LinkedList<string>();
            arraylist = new libArrayList.ArrayList<string>(10);
        }
        public libLinkedList.ILinkedList<string> readFileToLinked()
        {
            StreamReader sr = new StreamReader(path);
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                linkedList.Add(line);
            }
            sr.Close();
            return linkedList;
        }

        public libArrayList.IArrayList<string> readFileToArray()
        {
            StreamReader sr = new StreamReader(path);
            string line;

            while ((line = sr.ReadLine()) != null)
            {
                arraylist.Add(line);
            }
            sr.Close();
            return arraylist;
        }


    }
}
