namespace SDC.Api.ApiModels
{
    /// <summary>
    /// The API model for expain claim.
    /// </summary>
    public class ExpenseClaimApiModel
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseClaimApiModel"/> class.
        /// </summary>
        public ExpenseClaimApiModel()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the expense.
        /// </summary>
        /// <value>
        /// The expense.
        /// </value>
        public ExpenseApiModel Expense { get; set; }

        /// <summary>
        /// Gets or sets the vendor.
        /// </summary>
        /// <value>
        /// The vendor.
        /// </value>
        public string Vendor { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>     
        public string Date { get; set; }


        /// <summary>
        /// Gets or sets the amount.
        /// </summary>
        /// <value>
        /// The amount.
        /// </value>
        public decimal TotalBeforeTax { get; set; }


        /// <summary>
        /// Gets or sets the tax rate.
        /// </summary>
        /// <value>
        /// The tax rate.
        /// </value>
        public decimal TaxRate { get; set; }

        #endregion
    }
}
