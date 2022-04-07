using System;

namespace Notes
{
    class Program
    {

        static void Main(string[] args)
        {
            // Değişkenleri tanımlayalım.
            string oncekiNota, sonrakiNota;
            string kullaniciNotasi;
            bool notaBulundu;
            sbyte n, x;

            // Notaları tanımlayalım.
            string[] nota = {"do","re","mi","fa","sol","la","si"};

            // Kullanıcıya nota soralım.
            Console.Write("Bir nota girin :");
            kullaniciNotasi = Console.ReadLine();

            // Kullanıcının girdiği notayı arayalım ve n degiskenine atayalım.
            notaBulundu  = false;
            n = 0;
            for (x = 0; x < 7; x++)
            {
                if (kullaniciNotasi == nota[x])
                {
                    notaBulundu = true;
                    n = x;
                }
            }

            // Kullanıcının girdiği nota bulundu ise...
            if (notaBulundu)
            {
                ///////
                // Sonraki notayi tespit edelim...

                // Nota Si ise...
                if (n==6)
                {
                    sonrakiNota = nota[0];
                }
                // Aksi takdirde...
                else
                {
                    sonrakiNota = nota[n + 1];
                }

                ///////
                // Sonraki notayi tespit edelim...

                // Nota Do ise...
                if ( n == 0)
                {
                    oncekiNota = nota[6];
                }
                // Aksi takdirde...
                else
                {
                    oncekiNota = nota[n - 1];
                }

                ///////
                // Buldugumuz notaları ekrana yazalım
                Console.WriteLine("Sonraki        nota:" + sonrakiNota);
                Console.WriteLine("Onceki       nota:" + oncekiNota);
            }
            // Aksi takdirde (nota bulunamadıysa)
            else
            {
                Console.WriteLine("Girdiginiz nota bulunamadi...");
            }

            // Pause
            Console.ReadLine();
            



            
        }
    }
}
