using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YMT.projects.classes.AbstractFactory.Abstract_Products;

namespace YMT.projects.classes.AbstractFactory
{
    class Client
    {
        private readonly Shirt _shirt;
        private readonly Trousers _trousers;

        public Client(ClothesFactory factory)
        {
            _shirt = factory.CreateShirt();
            _trousers = factory.CreateTrousres();
        }

        public string DecribeYourClothes()
        {
            return $"Bugün giydiklerim: {_shirt.GetType().Name} ve {_trousers.GetType().Name}";
        }
    }
}
