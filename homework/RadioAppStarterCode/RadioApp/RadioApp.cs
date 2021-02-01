using System;

namespace RadioApp
{
    public class Radio
    {
        private int _channel = 1;

        public bool On { get; set; }
        public int Channel
        {
            get { return _channel; }
            set
            {
                if (On == true && value > 0 && value <= 4)
                { _channel = value; }
            }
        }
        public bool Playing { get; set; }
        public int Volume { get; set; } = 75;

        public string Play()
        {
            if (On == true)
            {
                Playing = true;
                return ($"Playing channel {Channel}.");
            }
            else
            {
                return ("");
            }
            
        }

        public string Pause()
        { 
            if (Playing == true)
            {
                Playing = false;
                return "Paused";
            }
            else
            {
                return "Paused";
            }
            
        }

        public void TurnOff()
        {
            if (On == true)
            {
                On = false;
            }
        }

        public void TurnOn()
        {
            if (On == false)
            {
                On = true;

            }
        }

        public void ChangeVolume()
        {

        }

    }
    // implement a class Radio that corresponds to the Class diagram 
    //   and specification in the Radio_Mini_Project document
}