﻿//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Entities
{
    public class DPS
    {
        /// <summary>
        /// تاریخ انتشار
        /// </summary>
        public string PublishDate { get; set; }

        /// <summary>
        /// تاریخ مجمع
        /// </summary>
        public string CouncilDate { get; set; }

        /// <summary>
        /// سال مالی
        /// </summary>
        public string FiscalYear { get; set; }

        /// <summary>
        /// سود یا زیان پس از کسر مالیات
        /// </summary>
        public string ProfitOrLoss { get; set; }

        /// <summary>
        /// سود قابل تخصیص
        /// </summary>
        public string DistributableProfit { get; set; }

        /// <summary>
        /// سود انباشته پایان دوره
        /// </summary>
        public string AccumulatedProfit { get; set; }

        /// <summary>
        /// سود نقدی هر سهم
        /// </summary>
        public string CashProfit { get; set; }
    }
}