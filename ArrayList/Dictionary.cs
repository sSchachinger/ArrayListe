using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    public class Dictionary
    {
        public libLinkedList.ILinkedList<string> linkedList { get; set; }
        public libArrayList.IArrayList<string> arrayList { get; set; }
        public Dictionary()
        {
            linkedList = new libLinkedList.LinkedList<string>();
            arrayList = new libArrayList.ArrayList<string>();
        }
    }
    public class German : Dictionary 
    {
        public German() : base()
        {

        }

    }

}
