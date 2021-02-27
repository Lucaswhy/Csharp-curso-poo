using System;
using System.Globalization;
using ExercicioInterface.Entities;
using ExercicioInterface.Services;

namespace ExercicioInterface {
    class Program {
        static void Main(string[] args) {

            int n,nInst;
            DateTime date;
            double cValue;

            

            Console.WriteLine("Enter contract data");
            Console.WriteLine("Number: ");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Date (dd/MM/yyyy): ");
            date = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Contract value: ");
            cValue = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Enter number of installments: ");
            nInst = int.Parse(Console.ReadLine());



            Contract contract = new Contract(n,date,cValue);

            ContractService sContract = new ContractService(new PaypalService());
            sContract.processContract(contract,nInst);

            Console.WriteLine(contract.ToString());


            
        }
    }
}
