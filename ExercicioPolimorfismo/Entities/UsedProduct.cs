using System;
using System.Globalization;
using System.Text;

namespace ExercicioPolimorfismo.Entities {
    class UsedProduct : Product {

        private DateTime _manufactureDate { get; set; }

        public UsedProduct() {

        }

        public UsedProduct(string name, double price, DateTime manufactureDate) 
           : base(name, price) {
            _manufactureDate = manufactureDate;
        }

        public override string priceTag() {

            StringBuilder sb = new StringBuilder();

            sb.Append($"{_name} (used) $ {_price.ToString("F2",CultureInfo.InvariantCulture)} (Manufacture date: {_manufactureDate.ToString("dd/MM/yyyy")})");

            return sb.ToString();
        }
    }
}
