namespace SDC.Api.ApiModels
{
    /// <summary>
    /// The API model for expense.
    /// </summary>
    public class ExpenseApiModel
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseApiModel"/> class.
        /// </summary>
        public ExpenseApiModel()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the cost centre.
        /// </summary>
        /// <value>
        /// The cost centre.
        /// </value>
        public string CostCentre { get; set; }

        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        /// <value>
        /// The total.
        /// </value>
        public string Total { get; set; }

        /// <summary>
        /// Gets or sets the payment method.
        /// </summary>
        /// <value>
        /// The payment method.
        /// </value>
        public string PaymentMethod { get; set; }

        #endregion
    }
}
