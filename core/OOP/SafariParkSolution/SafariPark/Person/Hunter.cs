using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public class Hunter : Person , IShootable
    {
        //FIELDS
        

        //PROPERTIES
        public IShootable Shooter { get; set; }
        public bool IsDead { get; set; }

        //CONSTRUCTORS
        public Hunter() : base(){ }
        public Hunter(string fName, string lName, IShootable shooter) : base(fName, lName)
        {
            Shooter = shooter;
        }

        //METHODS
        public string Shoot(Hunter hunter)
        {
            
            return ($"{GetFullName()} is shooting. {Shooter.Shoot(hunter)}");
        }

        public override string ToString()
        {
            return $"{base.ToString()}, Shooter:{Shooter.ToString()}";
        }

        public void GetShot(int damage)
        {
            Health -= damage;

            if (Health <= 0)
            {
                Health = 0;
                IsDead = true;
            }
        }
    }  
}
