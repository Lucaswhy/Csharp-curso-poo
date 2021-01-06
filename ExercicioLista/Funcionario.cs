using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioLista {
    class Funcionario {
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salario { get; set; }

        public Funcionario() {

        }

        public Funcionario (int id, string name, double salario) {

            Id = id;
            Name = name;
            Salario = salario;            
        }

        public double aumentoSalario(double p) {

            p = p / 100.0;
            Salario = Salario + (Salario * p);

            return Salario;
        }
    }
}
