using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Vehicle : IMovable
    {
        
        //FIELDS
        protected int _capacity = 1;
        protected int _numPassengers;
        protected int _speed;


        //PROPERTIES
        public int NumPassengers
        {
            get { return _numPassengers; }
            set
            {
                if (value >= 0 && value <= _capacity){ _numPassengers = value; }
                else if (value > _capacity) { _numPassengers = _capacity; }
            }
        }
        public int Position { get; private set; }
        public int TopSpeed { get; protected set; }


        public int Speed
        {
            get { return _speed; }
            set
            { if (value >= 0) { _speed = value; } }
        }



        //CONSTRUCTORS
        public Vehicle() { Speed = 10; }

        public Vehicle(int capacity, int topSpeed, int speed = 10)
        {
            _capacity = capacity;
            Speed = speed;
            TopSpeed = topSpeed;
        }

        //METHODS
        public virtual string Move()
        {
            Position += Speed;

            return "Moving along";
        }

        public virtual string Move(int times)
        {
            Position += Speed * times;

            return $"Moving along {times} times";
        }

        public virtual string SpeedUp()
        {
            if (Speed + 10 < TopSpeed)
            {
                Speed += 10;
            }

            return "Speeding up";
        }
        //Can also overload to speed up x times

        public virtual string SlowDown()
        {
            if (Speed > 10)
            {
                Speed -= 10;

                return "Slowing down";
            }
            else
            {
                Speed -= Speed;
                return "Stopped";
            }
        }
        //Can also overload to slow down x times

        public override string ToString()
        {
            return $"{base.ToString()} Capacity: {_capacity} Passengers: {NumPassengers} Speed: {Speed} Position: {Position}";
        }
    }
}
