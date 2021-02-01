using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    public abstract class Weapon : IShootable
    {
        private string _brand;

        public abstract int Damage { get; }

        public Weapon(string brand)
        {
            _brand = brand;
        }

        public virtual string Shoot(Hunter hunter)
        {
            if (hunter.IsDead == false)
            {
                hunter.GetShot(Damage);
            }

            return $"Shooting {_brand}.";

        }

        public override string ToString()
        {
            return ($"{base.ToString()}, Weapon Name:{_brand}");
        }
    }

    public class LaserGun : Weapon
    {
        public override int Damage { get; } = 3;
        public LaserGun(string brand) : base(brand)
        {

        }

        public override string Shoot(Hunter hunter)
        {
            
            return $"Pew! Pew! Pew! Pew! Pew! {base.Shoot(hunter)}";
        }
    }

    public class WaterPistol : Weapon
    {
        public override int Damage { get; } = 1;
        public WaterPistol(string brand) : base(brand)
        {

        }

        public override string Shoot(Hunter hunter)
        {
            return $"Splash {base.Shoot(hunter)}";
        }
    }
}
