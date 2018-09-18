using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuntosali
{
    // Määritetään luokka Asiakas
    class Asiakas
    {
        // Asiakkaan attribuutit (ominaisuudet)
        string etunimi;
        string sukunimi;
        uint ika;
        bool mies;
        double pituus;
        double paino;


        // Olionmuodostin (konskruktori)
        public Asiakas(string etunimi, string sukunimi, uint ika, bool mies, double pituus, double paino)
        {
            this.etunimi = etunimi;
            this.sukunimi = sukunimi;
            this.ika = ika;
            this.mies = mies;
            this.paino = paino;
            this.pituus = pituus;
        }

        //metodi, jolla lasketaan painoindeksi
        public void laskeBMI()
        {
            double bmi = this.paino / (this.pituus * this.pituus);
            Console.WriteLine("asiakkaan BMI on: " + bmi);
        }

        public void TulostaHenkilötiedot()
        {
            Console.WriteLine("Asiakkaan etunimi on " + etunimi + ", sukunimi on " + sukunimi + " ja ikä on " + ika + " on mies" + mies);
        }

        // Metodit rasvaprosentin laskemiseen

        // Pojan rasvaprosentti
        public void PojanRasvaProsentti()
        {
            double bmi = this.paino / (this.pituus * this.pituus);
            double rasvaProsentti = (1.51f * bmi) - (0.70f * this.ika) - 3.6f + 1.4f;
            Console.WriteLine("Rasvaprosentti on: " + rasvaProsentti); 
        }
    }
    class Program
    {
        // Varsinainen pääohjelma alkaa tästä
        static void Main(string[] args)
        {
            // Käyttöliittymän muuttujat
            string eNimi;
            string sNimi;
            string asIka;
            string onMies;
            string asPaino;
            string asPituus;
            double paino;
            double pituus;
            bool mies;
            uint ika;

            // Kysytään käyttäjältä asiakastiedot
            Console.Write("Anna etunimi: ");
            eNimi = Console.ReadLine();
            Console.Write("Anna sukunimi: ");
            sNimi = Console.ReadLine();
            Console.Write("Anna ikä: ");
            asIka = Console.ReadLine();
            Console.Write("Anna paino: ");
            asPaino = Console.ReadLine();
            Console.Write("Anna pituus: ");
            asPituus = Console.ReadLine();
            asPaino = Console.ReadLine();
            Console.Write("Paina X, jos asiakas on Mies: ");
            onMies = Console.ReadLine();

            ika = UInt32.Parse(asIka); // muunnos 32 bittiseksi
                                       //muutetaan tekstinä annetut tiedot luvuiksi
            paino = Double.Parse(asPaino);
            pituus = Double.Parse(asPituus);
            if (onMies == "x")
            {
                mies = true;
            }
            else
            {
                mies = false;

            }
            //luodaan ensimmäinen asiakas
            Asiakas asiakas1 = new Asiakas(eNimi, sNimi, ika, mies, pituus, paino);
            Console.WriteLine("asiakkaan 1 tiedot ovat");
            asiakas1.TulostaHenkilötiedot();
            asiakas1.laskeBMI();
            Console.ReadLine();
        }
    }
}
                       
                
                  
                   