using System;
using System.Globalization;
namespace songuyen{
    class Program{
        static void Main(string[] Args){
            int nums = 0;
            int N = 2;
            int count = 0;
            Console.WriteLine("nhap so");
            nums = Int16.Parse(Console.ReadLine());
            
            
            
            while(count<nums){
                
                
                int m = (int)Math.Sqrt(N);
                for(int i = 2; i <= m;i ++){
                    if(N % i == 0){
                        Console.WriteLine(N);
                        count++;
                        break;

                    }
                } N++;
            }
           
            }


        }
    }

