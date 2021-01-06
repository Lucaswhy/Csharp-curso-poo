using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioVetor {
    class Hotel {

        public string Name { get; set; }
        public string Email { get; set; }

        public int? Quarto { get; set; }

        public Hotel() {
            Quarto = null;
        }

        public Hotel(string name, string email, int quarto) {

            Name = name;
            Email = email;
            Quarto = quarto;

        }

        public override string ToString() {
            return $"{Quarto}: {Name}, {Email}";
        }

    }
}
