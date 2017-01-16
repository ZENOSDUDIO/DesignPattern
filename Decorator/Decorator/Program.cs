using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ver 1
            var person = new Person("Jason");
            Console.WriteLine("First equipment");
            person.EquipThunderArmor();
            person.EquipThunderHelmet();
            person.EquipThunderShield();
            person.EquipThunderBoots();
            person.EquipThunderWeapon();
            person.EquipThunderMagic();
            person.Show();

            Console.WriteLine();
            Console.WriteLine("Second equipment");
            person.EquipStormArmor();
            person.EquipStormHelmet();
            person.EquipStormShield();
            person.EquipStormBoots();
            person.EquipStormWeapon();
            person.EquipStormMagic();
            person.Show();
            #endregion

            #region Ver 2
            //var person = new Person("Adam");
            //Console.WriteLine("First equipment");
            //Equipment thunderArmor = new ThunderArmor();
            //Equipment thunderShield = new ThunderShield();
            //Equipment thunderWeapon = new ThunderWeapon();

            //thunderArmor.Show();
            //thunderShield.Show();
            //thunderWeapon.Show();
            //person.Show();

            //Console.WriteLine();
            //Console.WriteLine("First equipment");
            //Equipment stormArmor = new StormArmor();
            //Equipment stormShield = new StormShield();
            //Equipment stormWeapon = new StormWeapon();

            //stormArmor.Show();
            //stormShield.Show();
            //stormWeapon.Show();
            //person.Show();
            #endregion

            #region Ver 3
            //var person = new Person("Declan");
            //Console.WriteLine("First equipment");
            //var thunderArmor = new ThunderArmor();
            //var thunderShield = new ThunderShield();
            //var thunderWeapon = new ThunderWeapon();

            //thunderArmor.Decorate(person);
            //thunderShield.Decorate(thunderArmor);
            //thunderWeapon.Decorate(thunderShield);
            //thunderWeapon.Show();

            //Console.WriteLine();
            //Console.WriteLine("Second equipment");
            //var stromArmor = new StormArmor();
            //var stromShield = new StormShield();
            //var stromWeapon = new StormWeapon();

            //stromArmor.Decorate(person);
            //stromShield.Decorate(stromArmor);
            //stromWeapon.Decorate(stromShield);
            //stromWeapon.Show();
            #endregion
        }
    }
}
