using System;
using System.Collections.Generic;
using System.Text;

namespace SafariPark
{
    class Camera : IShootable 
    {
        private string _brand;

        public Camera(string brand)
        {
            _brand = brand;
        }

        public string Shoot(Hunter hunter)
        {
            return ($"Taking a picture of {hunter} with {_brand}");
        }

        public override string ToString()
        {
            return ($"{base.ToString()}, Camera brand: {_brand}.");
        }
    }
}
