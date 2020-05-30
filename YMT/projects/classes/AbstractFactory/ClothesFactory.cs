using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMT.projects.classes.AbstractFactory.Abstract_Products;

namespace YMT.projects.classes.AbstractFactory
{
    abstract class ClothesFactory
    {
        public abstract Shirt CreateShirt();
        public abstract Trousers CreateTrousres();
    }
}
