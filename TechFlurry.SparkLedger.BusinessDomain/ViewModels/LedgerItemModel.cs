﻿using TechFlurry.SparkLedger.BusinessDomain.Enums;

namespace TechFlurry.SparkLedger.BusinessDomain.ViewModels
{
    public class LedgerItemModel
    {
        public long Id { get; set; }
        public string ItemName { get; set; }
        public LedgerCategories Category { get; set; }
    }
}
