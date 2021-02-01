using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Airplane : Vehicle
    {
        //FIELDS
        private string _airline;

        //PROPERTIES
        public int Altitude { get; private set; }

        //COSTRUCTORS
        public Airplane(int capacity, int topSpeed): base(capacity, topSpeed)
        {

        }

        public Airplane(int capacity, string airline, int topSpeed, int speed = 50) : base(capacity, topSpeed, speed)
        {
            _airline = airline;
        }

        //METHODS
        public override string Move()
        {
            return $"{base.Move()} at an altitude of {Altitude} meters.";
        }

        public override string Move(int times)
        {
            return $"{base.Move(times)} at an altitude of {Altitude} meters.";
        }

        public void Ascend(int distance)
        {
            if (Altitude + distance <= 30000)
            {
                Altitude += distance;
            }
            else 
            {
                Altitude = 30000;
            }
        }

        public void Descend(int distance)
        {
            if (Altitude - distance > 0)
            {
                Altitude -= distance;
            }
            else
            {
                Altitude = 0;
            }
        }

        public override string SpeedUp()
        {
            if (Speed + 50 <= TopSpeed)
            {
                Speed += 50;
            }
            else
            {
                Speed = TopSpeed;
            }

            return "Increasing throttle";
        }

        public override string SlowDown()
        {
            if (Speed > 50)
            {
                Speed -= 50;

                return "Slowing down";
            }
            else
            {
                Speed -= Speed;
                return "Stopped";
            }
        }

        public override string ToString()
        {
            return $"Thank you for flying {_airline}: {base.ToString()} Altitude: {Altitude}";
        }

    }
}
