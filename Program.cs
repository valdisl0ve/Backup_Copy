using System;
using System.Collections.Generic;
using System.Data;

namespace ConsoleApplication3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int totalCapacity = 565000;
            
            Flash flash = new Flash();
            flash.storageName = "MyFlash";
            flash.model = "MEGA";
            flash.flashCapacity = 8000;
            flash.speed3 = 100;
           


            DVD dvd = new DVD();
            dvd.storageName = "MyDVD_disc";
            dvd.model = "DVD/RW";
            dvd.TypeSide = TypeSide.OneSide;
            dvd.speedRead = 100;
            dvd.speedWrite = 100;


            HDD hdd = new HDD();
            hdd.storageName = "DISC (D:)";
            hdd.model = "Seagate";
            hdd.sectionCount = 10;
            hdd.sectionCapacity = 10000;
            hdd.speed2 = 1000;
            
          
            
            
            Console.WriteLine("---FLASH--");
            flash.WriteCapacity(flash);
            flash.StorageInfo(flash);
            Console.WriteLine("__________");
            
            Console.WriteLine();
            
            Console.WriteLine("---DVD--");
            dvd.WriteCapacity(dvd);
            dvd.CopyToStorage(dvd);
            dvd.FreeMemory(dvd);
            dvd.StorageInfo(dvd);
            Console.WriteLine("__________");
            
            Console.WriteLine();
            
            Console.WriteLine("---HDD--");
            hdd.WriteCapacity(hdd);
            hdd.CopyToStorage(hdd);
            hdd.FreeMemory(hdd);
            hdd.StorageInfo(hdd);
            Console.WriteLine("__________");
            
            
            
            
            

        }
    }
}