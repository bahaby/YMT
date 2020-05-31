using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMT.projects.classes.AbstractFactory.Abstract_Products;
using YMT.projects.classes.AbstractFactory.Products;

namespace YMT.projects.classes.AbstractFactory.Factories
{
    class ElegantClothesFactory : ClothesFactory
    {
        public override Shirt CreateShirt()
        {
            return new DressShirt();
        }

        public override Trousers CreateTrousres()
        {
            return new SuitTrousers();
        }
    }
}
