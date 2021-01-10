using System.Globalization;
using System.Text;

namespace ExercicioPolimorfismo.Entities {
    class Product {
        protected string _name { get; set; }
        protected double _price { get; set; }

        public Product() {

        }

        public Product(string name, double price) {
            _name = name;
            _price = price;
        }

        public virtual string priceTag() {

            StringBuilder sb = new StringBuilder();

            sb.Append($"{_name} $ {_price.ToString("F2", CultureInfo.InvariantCulture)}");

            return sb.ToString();
        }

    }
}
