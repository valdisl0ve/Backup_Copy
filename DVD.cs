using System;

namespace ConsoleApplication3
{
    public enum TypeSide {OneSide = 4700, TwoSide = 9400}
    
    public class DVD : Storage
    {
        public int speedRead { get; set; }
        public int speedWrite { get; set; }
        public TypeSide TypeSide { get; set; }
        
        
        
        private int busyMemory;
        private int freeMemory;
       
        
        
        
        
        
        public void WriteCapacity(DVD dvd)
        {
            if (dvd.TypeSide == TypeSide.OneSide)
            {
                Console.WriteLine("CAPACITY - 4700 Mbytes");
            }
            else if (dvd.TypeSide == TypeSide.TwoSide)
            {
                Console.WriteLine("CAPACITY - 9400 Mbytes");
            }
        }

        public void CopyToStorage(DVD dvd)
        {
            if (dvd.TypeSide == TypeSide.OneSide)
            {
                int remainder = 4700 % 780;
                int busy_memory = 4700 - remainder;
                busyMemory = busy_memory;
                
            }  else if (dvd.TypeSide == TypeSide.TwoSide)
            {
                int remainder = 9400 % 780;
                int busy_memory = 9400 - remainder;
                busyMemory = busy_memory;
            }
        }


        public void FreeMemory(DVD dvd)
        {
            
            if (dvd.TypeSide == TypeSide.OneSide)
            {
                freeMemory = 4700 - busyMemory; 
                
            }  else if (dvd.TypeSide == TypeSide.TwoSide)
            {
                freeMemory = 9400 - busyMemory; 
            }
           
        }
    
    
    
    
        public void StorageInfo(DVD dvd)
        {
            Console.WriteLine("STORAGE NAME - " + dvd.storageName);
            Console.WriteLine("MODEL - " + dvd.model);
            Console.WriteLine("TYPE SIDE - " + dvd.TypeSide);
            Console.WriteLine("SPEED READ - " + dvd.speedRead + " Mbyte/s");
            Console.WriteLine("SPEED WRITE - " + dvd.speedWrite + " Mbyte/s");
            if (dvd.TypeSide == TypeSide.OneSide)
            {
                Console.WriteLine("CAPACITY - 4700 Mbyte" );
                
            }  else if (dvd.TypeSide == TypeSide.TwoSide)
            {
                Console.WriteLine("CAPACITY - 9400 Mbyte" );
            }
            
            Console.WriteLine("FREE MEMORY - " + freeMemory + " Mbyte");
        }

        
        
    }
}