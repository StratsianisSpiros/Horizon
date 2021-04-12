using System.Collections.Generic;

namespace Entities.UtilityModels
{
    public static class TaxRates
    {
        public static readonly int Low = 13;
        public static readonly int Mid = 23;
        public static readonly int High = 30;
        public static readonly int VeryHigh = 40;

        public static List<int> GetTaxRates() => new List<int> { Low, Mid, High, VeryHigh };
    }
}
