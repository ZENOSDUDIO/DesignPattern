using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ver 1
            var game = new HandsetNGame();
            game.Run();
            #endregion

            #region Ver 2
            //HandsetBrand ab = new HandsetBrandMContactList();
            //ab.Run();

            //ab = new HandsetBrandMGame();
            //ab.Run();
            #endregion

            #region Ver 3
            //HandsetBrand ab = new HandsetBrandN();
            //ab.SetHandsetSoft(new HandsetGame());
            //ab.Run();

            //ab.SetHandsetSoft(new HandsetContactList());
            //ab.Run();
            #endregion
        }
    }
}
