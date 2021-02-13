using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioInterface.Services {
    interface IOnlinePaymentService {

        double paymentFee(double amount);
        double interest(double amount, int months);

    }
}
