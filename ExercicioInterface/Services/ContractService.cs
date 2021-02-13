using System;
using System.Collections.Generic;
using System.Text;
using ExercicioInterface.Entities;
using ExercicioInterface.Services;

namespace ExercicioInterface.Services {
    class ContractService {

        private IOnlinePaymentService IOnPaymentSvc;

        public ContractService(IOnlinePaymentService onPaymentSvc) {
            IOnPaymentSvc = onPaymentSvc;
        }

        public void processContract(Contract contract, int months) {

            double baseValue = contract.TotalValue / months;

            DateTime baseDate = contract.Date;
            DateTime dDate = baseDate;

            for (int i = 1; i <= months; i++) {

                double pValue = 0;

                pValue = pValue + (IOnPaymentSvc.interest(baseValue, i));
                pValue = pValue + (IOnPaymentSvc.paymentFee(baseValue));

                pValue = pValue + baseValue;
                                
                dDate = baseDate.AddMonths(i);

                contract.addList(new Installments(dDate, pValue));
            }


        }

    }
}
