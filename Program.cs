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

           
            
           
            var Reverb = 1;  
            var decibel = 100;                      //prev 50    POSSIBLY SHOULD BE DECIBEL MAXIMUM.
            var decibelMargin = num1 / 10 * 6;                 // decibelMargin is the reduction in decibels when 1/1% reverb is added                         


            int newReverb = num1 * Reverb;     
            int currentReverb = 0;


            
            

            Console.WriteLine("Current Reverb " + currentReverb + "%");

            int decibellimit = 30;    //prev 30

            //int decibelLow;

            int decibelLow = decibel - decibelMargin; 

            bool a = decibelLow > decibellimit;     


            

            

            int decibelLower = decibelLow; if (a is true);            

            int newdecibel = decibelLower;     



            Console.WriteLine("New Decibel level is now " + newdecibel);
            Console.WriteLine("New Reverb level is now " + newReverb + "%");

            Console.ReadKey();





        }
    }
}
