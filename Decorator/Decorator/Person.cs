using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    public class Person
    {
        public string Name { get; set; }

        public Person() { }

        public Person(string name)
        {
            Name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("Equipped {0}", Name);
        }

        #region Ver 1
        public void EquipThunderArmor()
        {
            Console.WriteLine("Thunder Armor");
        }

        public void EquipStormArmor()
        {
            Console.WriteLine("Storm Armor");
        }

        public void EquipThunderHelmet()
        {
            Console.WriteLine("Thunder Helmet");
        }

        public void EquipStormHelmet()
        {
            Console.WriteLine("Storm Helmet");
        }

        public void EquipThunderShield()
        {
            Console.WriteLine("Thunder Shield");
        }

        public void EquipStormShield()
        {
            Console.WriteLine("Storm Shield");
        }

        public void EquipThunderWeapon()
        {
            Console.WriteLine("Thunder Blade");
        }

        public void EquipStormWeapon()
        {
            Console.WriteLine("Storm Sword");
        }

        public void EquipThunderBoots()
        {
            Console.WriteLine("Thunder Boots");
        }

        public void EquipStormBoots()
        {
            Console.WriteLine("Storm Boots");
        }

        public void EquipThunderMagic()
        {
            Console.WriteLine("Thunder Magic");
        }

        public void EquipStormMagic()
        {
            Console.WriteLine("Storm Magic");
        }
        #endregion
    }
}
