using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Reverb_Control_App2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Set Reverb Level");
            
            var Reverb = 1;
            var decibel = 50;
            var decibelmargin = -6;
            
            
            string Reverbcontrol = Console.ReadLine();

            

           
            
            int num1 = Int32.Parse(Reverbcontrol);
            

           int newReverb = num1 / Reverb;

           Console.WriteLine("Current Reverb " + newReverb + "% ");

            int decibellimit = 30;

            bool a = newReverb > decibellimit;


            int decibellow;
            
            decibellow = (decibel - decibel - decibelmargin);

            int decibellower = decibellow; if (a is true);
                        
            int newdecibel = decibel - decibellower;    


                         
           Console.WriteLine("New Decibel level is now " + newdecibel);

            Console.ReadKey();





        }
    }
}
