using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioInterface.Entities {
    class Contract {

        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }

        private List<Installments> _installments { get; set; }

        public Contract(int number, DateTime date, double totalValue) {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            _installments = new List<Installments>();
        }

        public void addList(Installments list) {
            _installments.Add(list);
        }

        public void removeList(Installments list) {
            _installments.Remove(list);
        }
        
        public override string ToString() {

            StringBuilder sb = new StringBuilder();

            sb.Append("Installments:\n");
            
            foreach(Installments item in _installments) {
                sb.Append(item.DueDate.ToString("dd/MM/yyyy"));
                sb.Append(" - " + item.Amount.ToString("F2",CultureInfo.InvariantCulture) + "\n");
            }

            return sb.ToString();
        }


    }
}
