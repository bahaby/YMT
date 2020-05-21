using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YMT
{
    class ClassSingleton
    {
        public static ClassSingleton BoxName;
        private  ClassSingleton()
        {

        }
        public static ClassSingleton boxName()
        {
            if (BoxName == null)
                BoxName = new ClassSingleton();
            return BoxName;
        }
        public string box(string girilendeger)
        {
            Dictionary<string, string> boxcode = new Dictionary<string, string>();
            boxcode.Add("1", "Kulaklık");
            boxcode.Add("2", "Hoparlör");
            boxcode.Add("3", "Mouse");
            boxcode.Add("4", "Kasa");
            boxcode.Add("5", "Monitor");
            boxcode.Add("6", "Ekran Kartı");
            
            try
            {
              string deger = boxcode[girilendeger];
                return deger;
            }
            catch
            {
                return "Girilen Koda ait kutu yok";
            }
             
        }

    }
}
