using System;
using System.Text;

namespace ExercicioInterface.Entities {
    class Installments {

        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installments(DateTime dueDate, double amount) {
            DueDate = dueDate;
            Amount = amount;
        }
               
    }
}
