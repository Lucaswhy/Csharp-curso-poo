using System;

namespace ExercicioVetor {
    class Program {
        static void Main(string[] args) {

            Console.Write("How many rooms will be rented? ");

            int N = int.Parse(Console.ReadLine());

            string nome, email;
            int quarto;

            Hotel[] vect = new Hotel[10];

            for (int i = 0; i < 10; i++) {
                vect[i] = new Hotel();
            }

            for (int i = 0; i < N; i++) {
                Console.WriteLine("\nRent #" + (i + 1));

                Console.Write("Name: ");
                nome = Console.ReadLine();

                Console.Write("Email: ");
                email = Console.ReadLine();

                Console.Write("Room: ");
                quarto = int.Parse(Console.ReadLine());
                vect[quarto] = new Hotel(nome, email, quarto);

            }

            Console.WriteLine("Busy rooms: ");

            for (int i = 0; i < 10; i++) {
                if (vect[i].Quarto.HasValue) {
                    Console.WriteLine(vect[i]);
                }
            }
        }
    }
}
