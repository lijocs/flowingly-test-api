using Microsoft.AspNetCore.Mvc;
using SDC.Api.ApiModels;
using SDC.Api.Helpers;
using SDC.Api.Models;

namespace SDC.Api.Controllers
{
    /// <summary>
    /// Reservation controller.
    /// </summary>
    /// <seealso cref="ControllerBase" />
    [Route("reservations")]
    public class ReservationController : ControllerBase
    {
        private readonly IConfiguration m_configuration;

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ReservationController"/> class.
        /// </summary>
        public ReservationController(IConfiguration configuration)
        {
            m_configuration = configuration;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the expense details for the input message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <returns>Returns the formatted result extracted data and calculated results.</returns>
        [HttpGet]
        [Route("expensedetails")]
        public IActionResult GetExpenseDetails(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return NotFound();
            }

            XmlSerializationHelper<ExpenseClaim> helper = new XmlSerializationHelper<ExpenseClaim>();

            ExpenseClaim content;
            try
            {
                content = helper.Deserialize(message);
            }
            catch
            {
                return BadRequest();
            }

            if (content == null || content.Expense?.Total == null)
            {
                return BadRequest();
            }

            decimal salesTax = m_configuration.GetValue<decimal>("Settings:SalesTaxRate");
            decimal taxRate = TaxCalculationHelper.CalculateTax(decimal.Parse(content.Expense.Total), salesTax);
            decimal totalBeforeTax = decimal.Parse(content.Expense.Total) - taxRate;

            ExpenseClaimApiModel apiModel = ExpenseClaimApiModelMapper.MapToApiModel(content, taxRate, totalBeforeTax);
            return Ok(apiModel);
        }

        #endregion
    }
}
