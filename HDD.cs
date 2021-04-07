using System;

namespace ConsoleApplication3
{
    public class HDD : Storage
    {
        public int speed2 { get; set; }
        public int sectionCount { get; set; }   
        public int sectionCapacity { get; set; } 
        
        
        public int busyMemory;
        public int freeMemory;
    
    
    
    
    
        public void WriteCapacity(HDD hdd)
        {
            Console.WriteLine("CAPACITY - " + sectionCount * sectionCapacity);
        }

        public void CopyToStorage(HDD hdd)
        {
            int remainder = sectionCount * sectionCapacity % 780;
            int busy_memory = sectionCount * sectionCapacity - remainder;
            busyMemory = busy_memory;
        }


        public void FreeMemory(HDD hdd)
        {
            freeMemory = sectionCount * sectionCapacity - busyMemory; 
        }
    
    
    
    
        public void StorageInfo(HDD hdd)
        {
            Console.WriteLine("STORAGE NAME - " + hdd.storageName);
            Console.WriteLine("MODEL - " + hdd.model);
            Console.WriteLine("SPEED USB 3.0 - " + hdd.speed2 + " Mbyte/s");
            Console.WriteLine("CAPACITY - " + sectionCount * sectionCapacity + " Mbyte");
            Console.WriteLine("FREE MEMORY - " + freeMemory + " Mbyte");
        }
        
        
        
        
    }
}