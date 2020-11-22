using System;

namespace RadioApp
{
    public class Radio
    {
        public bool _on;
        private int _channel = 1;

        public int Channel
        {
            get { return _channel; }
            set 
            {  
                if (_on == true && value > 0 && value <= 4)
                { _channel = value; }
            }
        }

        public string Play()
        {
            if (_on == true)
            {
                return ($"Playing channel {Channel}.");
            }
            else
            {
                return ("Radio is off");
            }
        }

        public void TurnOff()
        {
            if (_on == true)
            {
                _on = false;
            }
        }

        public void TurnOn()
        {
            if (_on == false)
            {
                _on = true;

            }
        }

    }
    // implement a class Radio that corresponds to the Class diagram 
    //   and specification in the Radio_Mini_Project document
}