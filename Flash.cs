using System;
using System.Collections.Generic;

namespace ConsoleApplication3
{
    public class Flash : Storage

    {
    public int speed3 { get; set; }
    public int flashCapacity { get; set; }

    public int busyMemory;
    public int freeMemory;
    
    
    
    
    
    public void WriteCapacity(Flash flash)
    {
        Console.WriteLine("CAPACITY - " +flashCapacity);
    }

    public void CopyToStorage(Flash flash)
    {
        int remainder = flashCapacity % 780;
        int busy_memory = flashCapacity - remainder;
        busyMemory = busy_memory;
    }


    public void FreeMemory(Flash flash)
    {
       freeMemory = flashCapacity - busyMemory; 
    }
    
    
    
    
    public void StorageInfo(Flash flash)
    {
        Console.WriteLine("STORAGE NAME - " + flash.storageName);
        Console.WriteLine("MODEL - " +flash.model);
        Console.WriteLine("SPEED USB 3.0 - " +flash.speed3 + " Mbyte/s");
        Console.WriteLine("CAPACITY - " + flash.flashCapacity + " Mbyte");
        Console.WriteLine("FREE MEMORY - " + freeMemory + " Mbyte");
    }
    
    
    
    
   
   
    }
}