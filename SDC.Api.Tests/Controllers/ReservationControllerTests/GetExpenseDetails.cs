using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Moq;
using SDC.Api.ApiModels;
using SDC.Api.Controllers;
using System.Net;

namespace SDC.Api.Tests.Controllers.ReservationControllerTests
{
    public class GetExpenseDetails : IDisposable
    {
        #region Constants & Fields

        private readonly ReservationController m_controller;

        private readonly Mock<IConfiguration> m_configurationMock = new Mock<IConfiguration>();

        private readonly Mock<IConfigurationSection> m_configurationSectionMock = new Mock<IConfigurationSection>();

        #endregion

        #region Constructors

        public GetExpenseDetails()
        {
            m_controller = new ReservationController(m_configurationMock.Object);
        }

        #endregion

        #region Facts

        [Test]
        public async Task WhenInvalidInput_ThenReturnsBadRequest()
        {
            // Act
            IActionResult result = m_controller.GetExpenseDetails(Strings.InvalidMessageFormat);
            ObjectResult okResult = result as ObjectResult;

            //Assert
            Assert.Null(okResult);
        }

        [Test]
        public async Task WhenInputDoesnotHaveTotal_ThenReturnsBadRequest()
        {
            // Act
            IActionResult result = m_controller.GetExpenseDetails(Strings.TotalFieldMissingMessageFormat);
            ObjectResult okResult = result as ObjectResult;

            //Assert
            Assert.Null(okResult);
        }

        [Test]
        public async Task WhenInputDoesnotHaveCostCentreField_ThenAssignsDefault_ReturnsSuccess()
        {
            // Arrange
            SetupConfigurationData();

            // Act & Assert
            IActionResult result = m_controller.GetExpenseDetails(Strings.CostCentreMissingMessageFormat);
            ObjectResult okResult = result as ObjectResult;

            Assert.That(okResult, Is.Not.Null);
            Assert.That(okResult.StatusCode, Is.EqualTo((int)HttpStatusCode.OK));

            ExpenseClaimApiModel content = okResult.Value as ExpenseClaimApiModel;

            Assert.NotNull(content);
            Assert.That(content.Expense.CostCentre, Is.EqualTo(Strings.CostCentreUnknown));
        }

        [Test]
        public async Task WhenValidInput_ThenReturnsSuccessResult()
        {
            // Arrange
            SetupConfigurationData();

            // Act
            IActionResult result = m_controller.GetExpenseDetails(Strings.ValidMessageFormat);
            ObjectResult okResult = result as ObjectResult;

            //Assert
            Assert.NotNull(okResult);
            Assert.That(okResult.StatusCode, Is.EqualTo((int)HttpStatusCode.OK));
        }

        #endregion

        #region Private Methods

        private void SetupConfigurationData()
        {
            m_configurationSectionMock
               .Setup(x => x.Value)
               .Returns("6.25");

            m_configurationMock
               .Setup(x => x.GetSection("Settings:SalesTaxRate"))
               .Returns(m_configurationSectionMock.Object);
        }
        #endregion

        #region IDisposable Implementation

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (m_controller is IDisposable controller)
                {
                    controller.Dispose();
                }
            }
        }

        #endregion
    }
}
