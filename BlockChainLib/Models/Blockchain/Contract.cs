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
