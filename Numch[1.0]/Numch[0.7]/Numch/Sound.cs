/*
Notes : 
Win and Lose sounds need to change, they don't fit anymore
The background music must loop without going silent
Settings bars must control the sound volume
*/
using System;
using NAudio.Wave;

namespace Numch
{
    //<summary>
    //Class used to manage sound
    //</summary>
    public class Sound : WaveStream
    {
        //Class variables
        WaveStream loopSource;                                  //Where to Loop from
        static String soundSource = " ";                        //Where to play sound from
        static WaveFileReader wfr = null;                       //Which file to read
        static WaveChannel32 wc = null;                         //Audio channel
        static DirectSoundOut drSound = new DirectSoundOut();   //Output
        public static bool mute = false;                        //True if mute button pressed
        //Retrun the loopSource's wave fromat
        public override WaveFormat WaveFormat
        {
            get { return loopSource.WaveFormat; }
        }

        //Return loopSource
        public override long Length
        {
            get { return loopSource.Length; }
        }

        //Set position to loopSource to stream
        public override long Position
        {
            get { return loopSource.Position; }

            set { loopSource.Position = value; }
        }

        //Turn on/off looping
        public bool EnableLooping { get; private set; }

        //Using this constructor only in case of looping
        public Sound (WaveStream Source)
        {
            this.loopSource = Source;
            this.EnableLooping = true;
        }

        //Called in Forms to manage the playing sound
        public static void PlaySound(String soundType)
        {
            //Check type to play and save the source path to string
            switch (soundType)
            {
                case "Click":
                    soundSource = @"Sounds\\ButtonClick.wav";
                    break;
                case "Back1":
                    soundSource = @"Sounds\\ButtonBack1.wav";
                    break;
                case "Back2":
                    soundSource = @"Sounds\\ButtonBack2.wav";
                    break;
                case "Coundown":    //Probably will not use
                    soundSource = @"Sounds\\Countdown.wav";
                    break;
                case "Exit":
                    soundSource = @"Sounds\\Exit.wav";
                    break;
                case "Play":
                    soundSource = @"Sounds\\Play.wav";
                    break;
                case "Play2":
                    soundSource = @"Sounds\\Play2.wav";
                    break;
                case "Lose":
                    soundSource = @"Sounds\\Lose.wav";
                    break;
                case "Win":
                    soundSource = @"Sounds\\Win.wav";
                    break;
                default:
                    break;
            }
            //Manage sound output
            wfr = new WaveFileReader(soundSource);      //Set the WaveFileReader to the soundSource
            wc = new WaveChannel32(wfr);                //Set the WaveChannel32 to the WaveFileReader
            drSound.Init(wc);                           //Initialise sound output to play once
            if (mute)                                   //If mute is true
                wc.Volume = 0.0f;                       //Set volume to 0
            else                                        //If mute is false
                wc.Volume = 1.0f;                       //Set volume to max
            drSound.Play();                             //And Play it
        }

        //To loop the sound
        public override int Read(byte[] buffer, int offset, int count)
        {
            int totalBytes = 0;//Sound bytes read

            while (totalBytes < count)
            {
                int Bytes = loopSource.Read(buffer, offset + totalBytes, count - totalBytes);//Recursive call
                if (Bytes == 0)//If sound ended
                {
                    if(loopSource.Position == 0 || !EnableLooping)
                    {
                        //In case something goes off stop looping
                        break;
                    }
                    loopSource.Position = 0;//Set position to 0, in order to loop
                }
                totalBytes += Bytes;//Increase totalBytes
            }
            return totalBytes;
        }
    }
}