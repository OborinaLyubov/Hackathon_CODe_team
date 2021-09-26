using System;

namespace BlockChainLib.Models.Blockchain
{
    /// <summary>
    /// Договор
    /// </summary>
    public struct Contract
    {
        /// <summary>
        /// Фамилия Имя Отчество страхователя
        /// </summary>
        public string FIOInsurent { get; private set; }
        
        /// <summary>
        /// Номер кредитного договора
        /// </summary>
        public string NumberCreditContract { get; private set; }

        /// <summary>
        /// Дата кредитного договора
        /// </summary>
        public DateTime DateCreditContract { get; private set; }

        /// <summary>
        /// Номер страхового договора
        /// </summary>
        public string NumberInsuranceContract { get; private set; }

        /// <summary>
        /// Дата страхового договора
        /// </summary>
        public DateTime DateInsurancyContract { get; private set; }

        /// <summary>
        /// Сумма страхования
        /// </summary>
        public uint SumInsured { get; private set; }

        /// <summary>
        /// Дата платежа
        /// </summary>
        public DateTime DatePayment { get; private set; }

        /// <summary>
        /// Сумма платежа
        /// </summary>
        public uint SumPayment { get; private set; }

        /// <summary>
        /// Страховые риски
        /// </summary>
        public InsuranceRisk InsuranceRisk { get; private set; }

        /*public bool Equals(Contract other)
        {
            return Equals(other, this);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var objectToCompareWith = (Contract)obj;

            return objectToCompareWith.FIOInsurent == FIOInsurent && objectToCompareWith.NumberCreditContract == NumberCreditContract &&
                   objectToCompareWith.DateCreditContract == DateCreditContract && objectToCompareWith.NumberInsuranceContract == NumberInsuranceContract
                   && objectToCompareWith.DateInsurancyContract == DateInsurancyContract && objectToCompareWith.SumInsured == SumInsured
                    && objectToCompareWith.DatePayment == DatePayment && objectToCompareWith.SumPayment == SumPayment && objectToCompareWith.InsuranceRisk == InsuranceRisk;

        }

        public override int GetHashCode()
        {
            var calculation = FIOInsurent + NumberCreditContract + DateCreditContract + NumberInsuranceContract + DateInsurancyContract + SumInsured + DatePayment + SumPayment + InsuranceRisk;
            return calculation.GetHashCode();
        }*/
    }

    /// <summary>
    /// Страховые риски
    /// </summary>
    public enum InsuranceRisk
    {
        /// <summary>
        /// страхование жизни
        /// </summary>
        LifeInsurance = 0,

        /// <summary>
        /// страхование имущества
        /// </summary>
        PropertyInsurance = 1,

        /// <summary>
        /// страхование титула
        /// </summary>
        TitleInsurance = 2
    }
}
