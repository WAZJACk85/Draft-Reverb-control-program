# Draft-Reverb-control-program

This Read me will display the updates to the main project:-


Recent changes 09/08/2023 :  Changed the code so that it better calculates sums.  Changed some of the text to show starting Reverb instead of 'current reverb'

Next steps : Now the draft works, I am reading : Designing software synthesizer Plugins in C++, I am going to Develop a UI for this mock reverb control and then
further UI's for  distortion and chorus pedal controls.



# Current information:-

The current file is a very brief sketch of an app designed to monitor inputs of reverb control of a reverb sythesizer to an amp or head or pedal.

sketch:  When you 'Set reverb'  you type in a number   , this currently works best in multiples of 10 , i,e  10,20,30,70,100.
With each increment of 10 it will reduce the Decibel Level by 6 so INPUT 10 = -6   |  INPUT 20 = -12   and so on...  And each increment of 10 increases the Reverb by 10.

So for example if you Set reverb at 100  the Decibel level starts at 100, this will change it to 60 (as INPUT increments of 10  reduces decibels by 6 each time in this case it subracts 60)  and also will change the Reverb to 100%.

I will update new components each week from 15/09/2021.   Once the program reaches a certain intellectual value, I will leave read me files with the title of the original file and these can be described and annotated in interview with the assistance of pre-prepared videos/files I can share on the Teams/Zoom interview video call.

Caveat:-

Once the program has taken on a very high level of complexity and becomes viable to bring to market, I will not post further changes on here and will potentially remove some code and insert comments and end comment with how many lines of code are missing.

------------------
