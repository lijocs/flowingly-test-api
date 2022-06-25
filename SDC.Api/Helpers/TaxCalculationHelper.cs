namespace SDC.Api.Helpers
{
    /// <summary>
    /// The helper class for Tax calculation.
    /// </summary>
    public static class TaxCalculationHelper
    {
        #region Public Methods

        /// <summary>
        /// Calculates the tax amount when total and tax rate is provided.
        /// </summary>
        /// <param name="total">The total amount.</param>
        /// <param name="taxRate">The sales tax rate.</param>
        /// <returns>The tax amount.</returns>
        public static decimal CalculateTax(decimal total, decimal taxRate)
        {
            return total - (total / (1 + taxRate) * taxRate);
        }

        #endregion
    }
}
