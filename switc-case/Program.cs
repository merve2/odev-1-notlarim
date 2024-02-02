using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switc_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int golSayisi = 0;
            string takimSeviyesi = "";
            Random sayi = new Random();
            golSayisi=sayi.Next(0,6);  // 0 ve 5 sayıları gelebilir.
            switch (golSayisi)
            {
                case 1:
                    takimSeviyesi = "ok";
                    break;
                case 2:
                    takimSeviyesi = "guzel";
                    break;
                case 3:
                    takimSeviyesi = "yuksek";
                    break;
                case 4:
                    takimSeviyesi = "muhtesem";
                    break;
                case 5:
                    takimSeviyesi = "wow";
                    break;
                default:
                    takimSeviyesi = "kotu";
                    break ;

            }
            Console.WriteLine(takimSeviyesi);
            Console.ReadLine();
        
        }
    }
}
