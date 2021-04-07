using System;
using System.Collections.Generic;

namespace ConsoleApplication3
{
    public abstract class Storage
    {
        public string storageName { get; set; }
        public string model { get; set; }


        
        public int AllStorageMemory(Flash flash, DVD dvd, HDD hdd)
        {
            int allMemory = flash.flashCapacity + hdd.sectionCapacity * hdd.sectionCount + 4700;
            return allMemory;
        }
        
        
        
        
    }
}