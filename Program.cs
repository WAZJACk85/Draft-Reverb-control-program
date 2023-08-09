using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Principle is that when you input more Reverb, the Reverb level increases, and the Decibel level decreases to a) avoid ultra loud
// refraction b) gives the correct indication of decibels (loudness) decreasing as Reverb increases, which is true to life.
// i.e in real life when Reverb is increased it widens the frequency and thus reduces the decibel or loudness concentration.



namespace Reverb_Control_App2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Set Reverb Level");

            

            string Reverbcontrol = Console.ReadLine();
            int num1 = Int32.Parse(Reverbcontrol);

           // int num2 = Int32.Parse(50 / newReverb);
            
            var Reverb = 1 * num1;
            var decibel = 100;                      //prev 50    POSSIBLY SHOULD BE DECIBEL MAXIMUM.
            var decibelMargin = -6;                 // decibelMargin is the reduction in decibels when 1/1% reverb is added                         


            int newReverb = num1 / Reverb;     // num1 / Reverb;

            Console.WriteLine("Current Reverb " + newReverb + "%");

            int decibellimit = 30;

            bool a = newReverb > decibellimit;


            int decibelLow;

            decibelLow = (decibel - decibel - decibelMargin); //(decibel - decibel - decibelmargin)

            int decibelLower = decibelLow; if (a is true);            

            int newdecibel = decibel - decibelLower;



            Console.WriteLine("New Decibel level is now " + newdecibel);
            Console.WriteLine("New Reverb level is now " + newReverb);

            Console.ReadKey();





        }
    }
}
