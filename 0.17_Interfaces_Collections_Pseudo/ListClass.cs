﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_Interfaces_Collections_Pseudo
{
    class ListClass : IEnum, IList, ICollect
    {
        public void AddStuff()
        {
            Console.WriteLine("Add stuff to list");
        }

        public void CheckTheCapacity()
        {
            Console.WriteLine("Checking capacity of list");
        }

        public void CheckTheCount()
        {
            Console.WriteLine("Checking count of list");
        }

        public void IterateOverCollection()
        {
            Console.WriteLine("Iterating over list");
        }

        public void RemoveStuff()
        {
            Console.WriteLine("Remove stuff from list");
        }
    }
}
