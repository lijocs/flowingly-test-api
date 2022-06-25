using SDC.Api.Helpers;
using SDC.Api.Models;

namespace SDC.Api.ApiModels
{
    public static class ExpenseClaimApiModelMapper
    {
        #region Public Methods

        public static ExpenseClaimApiModel MapToApiModel(ExpenseClaim content, decimal taxRate, decimal totalBeforeTax)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            if (content.Expense == null)
            {
                throw new ArgumentNullException(nameof(content.Expense));
            }

            return new ExpenseClaimApiModel()
            {
                TotalBeforeTax = totalBeforeTax,
                Date = content.Date,
                Vendor = content.Vendor,
                TaxRate = taxRate,
                Description = content.Description,
                Expense = new ExpenseApiModel()
                {
                    Total = content.Expense.Total,
                    PaymentMethod = content.Expense.PaymentMethod,
                    CostCentre = content.Expense.CostCentre ?? Strings.CostCentreUnknown,
                },
            };
        }

        #endregion
    }
}
