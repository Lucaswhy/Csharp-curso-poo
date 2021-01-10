using System.Globalization;
using System.Text;

namespace ExercicioPolimorfismo.Entities {
    class ImportedProduct : Product {

        private double _customsFee { get; set; }

        public ImportedProduct() {

        }

        public ImportedProduct(string name, double price,double customsFee)
            : base(name,price) {
            _customsFee = customsFee;
        }

        public override string priceTag() {
            StringBuilder sb = new StringBuilder();

            sb.Append($"{_name} $ {totalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Custom fee: $ {_customsFee.ToString("F2",CultureInfo.InvariantCulture)})");

            return sb.ToString();

        }

        public double totalPrice() {
            return _price + _customsFee;
        }
    }
}
