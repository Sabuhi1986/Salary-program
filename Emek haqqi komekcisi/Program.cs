using System;

namespace Emek_haqqi_komekcisi
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal xalisemekhaqqi = 0;
            decimal vergi;
            decimal elilvergisi;
            bool elil;
            int evlilikmuavineti = 50;
            int usaqpulu = 0;
            int x = 35;
            Console.WriteLine("==========================Emek haqqi komekcisi proqrami: ========================");
            Console.WriteLine("");
            Console.Write("Umumi Gross Emek haqqi:  ");
            int grossemekhaqqi = int.Parse(Console.ReadLine());
            Console.WriteLine("Elillik derecesi varmi? beli/yox");
            string elillikderecesi = (Console.ReadLine().ToLower());
            if (elillikderecesi == "beli")
            {
                elil = true;
                elilvergisi = (grossemekhaqqi / 100) * 50;
                xalisemekhaqqi = grossemekhaqqi - elilvergisi;
            }
            else
            {
                elil = false;
            }
            Console.WriteLine("Aile veziyyeti: e/E: evli, s/S: subay, d/D: dul");
            string aileveziyyeti = (Console.ReadLine().ToLower());

            if (aileveziyyeti != "subay")
            {
                Console.WriteLine("Usaqlarin sayi:  ");
                int usaqlarinsayi = int.Parse(Console.ReadLine());

                

                for (int i = 0; i < usaqlarinsayi; i++)
                {
                    if (i <= 3)
                    {
                        x = x - 5;
                    }

                    if (i > 3)
                    {
                        x = 0;
                        usaqpulu = usaqpulu + 15;
                    }
                    usaqpulu = usaqpulu + x;
                }
            }
            else
            {
                evlilikmuavineti = 0;
                Console.WriteLine("aile muavinati " + evlilikmuavineti);
            }

            if (grossemekhaqqi <= 1000)
            {
                if (elil == true)
                {
                    vergi = ((grossemekhaqqi / 100) * 50);
                    xalisemekhaqqi = grossemekhaqqi - vergi;
                    Console.WriteLine("Elilin Xalis emek haqqisi:--- " + xalisemekhaqqi + "AZN");
                }
                else
                    vergi = (grossemekhaqqi / 100) * 15;
                xalisemekhaqqi = grossemekhaqqi - vergi;
                Console.WriteLine("Xalis emek haqqi:--- " + xalisemekhaqqi + "AZN");
            }

            if (grossemekhaqqi > 1000 && grossemekhaqqi <= 2000)
            {
                if (elil == true)
                {
                    vergi = ((grossemekhaqqi / 100) * 50);
                    xalisemekhaqqi = grossemekhaqqi - vergi;
                    Console.WriteLine("Elilin Xalis emek haqqisi:--- " + xalisemekhaqqi + "AZN");
                }
                else
                    vergi = (grossemekhaqqi / 100) * 20;
                xalisemekhaqqi = grossemekhaqqi - vergi;
                Console.WriteLine("Xalis emek haqqi:--- " + xalisemekhaqqi + "AZN");
            }

            if (grossemekhaqqi > 2000 && grossemekhaqqi <= 3000)
            {
                if (elil == true)
                {
                    vergi = (grossemekhaqqi / 100) * 50;
                    xalisemekhaqqi = grossemekhaqqi - vergi;
                    Console.WriteLine("Elilin Xalis emek haqqisi:--- " + xalisemekhaqqi + "AZN");
                }
                else
                    vergi = (grossemekhaqqi / 100) * 25;
                xalisemekhaqqi = grossemekhaqqi - vergi;
                Console.WriteLine("Xalis emek haqqi:--- " + xalisemekhaqqi + "AZN");
            }

            if (grossemekhaqqi > 3000)
            {
                if (elil == true)
                {
                    vergi = (grossemekhaqqi / 100) * 50;
                    xalisemekhaqqi = grossemekhaqqi - vergi;
                    Console.WriteLine("Elilin Xalis emek haqqisi:--- " + xalisemekhaqqi + "AZN");
                }
                else
                    vergi = (grossemekhaqqi / 100) * 30;
                xalisemekhaqqi = grossemekhaqqi - vergi;
                Console.WriteLine("Xalis emek haqqi:--- " + xalisemekhaqqi + "AZN");
            }

            Console.WriteLine("Aile muavineti:--- " + evlilikmuavineti + "AZN");
            Console.WriteLine("Umumi emek haqqi:--- " + grossemekhaqqi + "AZN");
            Console.WriteLine("Usaq pulu:--- " + usaqpulu + "AZN");
            Console.WriteLine("===================================================================");

            Console.WriteLine("Sizin emek haqqiniz asagidaki eskinazlarnan odenilecek");
            Console.WriteLine("                                                    ");

            int[] manat = { 200, 100, 50, 20, 10, 5, 1 };
            for (int i = 0; i < manat.Length; i++)
            {
                int PulEskinazi = Convert.ToInt32(Math.Floor(xalisemekhaqqi / manat[i]));
                Console.WriteLine($"{manat[i]}.-liq eskinazdan  { PulEskinazi}  eded");
                xalisemekhaqqi = Convert.ToInt32(Math.Floor(xalisemekhaqqi - (manat[i] * PulEskinazi)));
            }

        }
    }



}