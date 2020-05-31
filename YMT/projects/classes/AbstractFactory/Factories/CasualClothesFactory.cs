using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMT.projects.classes.AbstractFactory.Abstract_Products;
using YMT.projects.classes.AbstractFactory.Products;

namespace YMT.projects.classes.AbstractFactory.Factories
{
    class CasualClothesFactory : ClothesFactory
    {
        public override Shirt CreateShirt()
        {
            return new PoloShirt();
        }

        public override Trousers CreateTrousres()
        {
            return new Jeans();
        }
    }
}
