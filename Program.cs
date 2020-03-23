using System;
using System.Collections.Generic;

namespace NamuDarbai1
{
    class Program
    {
        
        static void Main()
        {
            int rez = VartotojoIvestis();

            //Console.WriteLine("spausdinu is main: " + VartotojoIvestis());

            IsvedamTeksta(rez);
        }

        static int VartotojoIvestis()
        {
            int rezis1 = -19;
            int rezis2 = 19;

            Console.Write($"Prasom ivesti Jusu pasirinkta skaiciu nuo {rezis1} iki {rezis2}: ");
            string zodis = Console.ReadLine();

            
            bool arPavyko;
            int resultatas;

            arPavyko = int.TryParse(zodis, out resultatas);

            Console.WriteLine($"Spausdinu parse resultatas: {resultatas} ar vertimas pavyko: {arPavyko}");

            return resultatas;

        }
        
        static void RezioPatikra(int rez)
        {
            if (rez >= -19 && rez <= 19)
            {
                Console.WriteLine($"Jusu ivestas skaicius: {rez} yra teisingame rezyje, tarp -19 ir 19");
            }
            else
            {
                Console.WriteLine($"Jusu ivestas skaicius: {rez} nera tinkamame rezyje, prasome ivesti kita");
                VartotojoIvestis();
            }
        }
        
        
        static void IsvedamTeksta(int rez)
        {
            if (rez >= 0)
            {
                if (rez == 0)
                {
                    Console.WriteLine("Ivestas skaicius yra Nulis");
                }
                else if (rez == 1)
                {
                    Console.WriteLine("Ivestas skaicius yra Vienas");
                }
                else if (rez == 2)
                {
                    Console.WriteLine("Ivestas skaicius yra Du");
                }
                else if (rez == 3)
                {
                    Console.WriteLine("Ivestas skaicius yra Trys");
                }
                else if (rez == 4)
                {
                    Console.WriteLine("Ivestas skaicius yra Keturi");
                }
                else if (rez == 5)
                {
                    Console.WriteLine("Ivestas skaicius yra Penki");
                }
                else if (rez == 6)
                {
                    Console.WriteLine("Ivestas skaicius yra Sesi");
                }
                else if (rez == 7)
                {
                    Console.WriteLine("Ivestas skaicius yra Septyni");
                }
                else if (rez == 8)
                {
                    Console.WriteLine("Ivestas skaicius yra Astuoni");
                }
                else if (rez == 9)
                {
                    Console.WriteLine("Ivestas skaicius yra Devyni");
                }
                else if (rez == 10)
                {
                    Console.WriteLine("Ivestas skaicius yra Desimt");
                }
                else if (rez == 11)
                {
                    Console.WriteLine("Ivestas skaicius yra Vienuolika");
                }
                else if (rez == 12)
                {
                    Console.WriteLine("Ivestas skaicius yra Dvylika");
                }
                else if (rez == 13)
                {
                    Console.WriteLine("Ivestas skaicius yra Trylika");
                }
                else if (rez == 14)
                {
                    Console.WriteLine("Ivestas skaicius yra Keturiolika");
                }
                else if (rez == 15)
                {
                    Console.WriteLine("Ivestas skaicius yra Penkiolika");
                }
                else if (rez == 16)
                {
                    Console.WriteLine("Ivestas skaicius yra Sesiolika");
                }
                else if (rez == 17)
                {
                    Console.WriteLine("Ivestas skaicius yra Septyniolika");
                }
                else if (rez == 18)
                {
                    Console.WriteLine("Ivestas skaicius yra Astuoniolika");
                }
                else if (rez == 19)
                {
                    Console.WriteLine("Ivestas skaicius yra Devyniolika");
                }
                else
                {
                    Console.WriteLine("ERRORas");
                }
            }
            else
            {
                
                if (rez == -1)
                {
                    Console.WriteLine("Ivestas skaicius yra minus Vienas");
                }
                else if (rez == -2)
                {
                    Console.WriteLine("Ivestas skaicius yra minus Du");
                }
                else if (rez == -3)
                {
                    Console.WriteLine("Ivestas skaicius yra minus Trys");
                }
                else if (rez == -4)
                {
                    Console.WriteLine("Ivestas skaicius yra minus Keturi");
                }
                else if (rez == -5)
                {
                    Console.WriteLine("Ivestas skaicius yra minus Penki");
                }
                else if (rez == -6)
                {
                    Console.WriteLine("Ivestas skaicius yra minus Sesi");
                }
                else if (rez == -7)
                {
                    Console.WriteLine("Ivestas skaicius yra minus Septyni");
                }
                else if (rez == -8)
                {
                    Console.WriteLine("Ivestas skaicius yra minus Astuoni");
                }
                else if (rez == -9)
                {
                    Console.WriteLine("Ivestas skaicius yra minus Devyni");
                }
                else if (rez == -10)
                {
                    Console.WriteLine("Ivestas skaicius yra minus Desimt");
                }
                else if (rez == -11)
                {
                    Console.WriteLine("Ivestas skaicius yra minus Vienuolika");
                }
                else if (rez == -12)
                {
                    Console.WriteLine("Ivestas skaicius yra minus Dvylika");
                }
                else if (rez == -13)
                {
                    Console.WriteLine("Ivestas skaicius yra minus Trylika");
                }
                else if (rez == -14)
                {
                    Console.WriteLine("Ivestas skaicius yra minus Keturiolika");
                }
                else if (rez == -15)
                {
                    Console.WriteLine("Ivestas skaicius yra minus Penkiolika");
                }
                else if (rez == -16)
                {
                    Console.WriteLine("Ivestas skaicius yra minus Sesiolika");
                }
                else if (rez == -17)
                {
                    Console.WriteLine("Ivestas skaicius yra minus Septyniolika");
                }
                else if (rez == -18)
                {
                    Console.WriteLine("Ivestas skaicius yra minus Astuoniolika");
                }
                else if (rez == -19)
                {
                    Console.WriteLine("Ivestas skaicius yra minus Devyniolika");
                }
                else
                {
                    Console.WriteLine("ERRORas");
                }
            }
        }
        





    }





}
