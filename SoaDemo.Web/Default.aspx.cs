using System;
using System.Globalization;
using System.Web.UI;
using SoaDemo.Services.Common.DataContracts;
using SoaDemo.Web.ProductService;

namespace SoaDemo.Web
{
    public class CustomValidator : IValidator
    {
        public void Validate() {}

        public bool IsValid { get; set; }
        public string ErrorMessage { get; set; }
    }

    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e) { }

        protected void GetCogButton_Click(object sender, EventArgs e)
        {
            var cogId = int.Parse(CogIdInputTextBox.Text);

            var productServiceClient = new ProductServiceClient();
            var product = productServiceClient.GetCog(cogId);

            // product should be translated into ViewModel
            BindProduct(product);

        }

        protected void SaveCogButton_Click(object sender, EventArgs e)
        {
            var productServiceClient = new ProductServiceClient();

            // assembler will do this
            var product = new Product()
            {
                Description = CogDescriptionDisplayTextBox.Text,
                Id = int.Parse(CogIdHiddenField.Value),
                Name = CogNameDisplayTextBox.Text
            };

            product = productServiceClient.SaveCog(product);

            // product should be translated to ViewModel
            BindProduct(product);
        }

        private void BindProduct(Product product)
        {
            if (product != null)
            {
                CogIdHiddenField.Value = product.Id.ToString(CultureInfo.InvariantCulture);
                CogIdDisplayLabel.Text = string.Format("Cog Id: {0}", product.Id.ToString(CultureInfo.InvariantCulture));
                CogNameDisplayTextBox.Text = product.Name;
                CogDescriptionDisplayTextBox.Text = product.Description;

                // validation should be done differently.  validation should be done at the ViewModel
                // any ErrorMessages returned in the DTO would be incorporated when the ViewModel does its validation
                if (product.ErrorMessages != null)
                {
                    foreach (var errorMessage in product.ErrorMessages)
                    {
                        Page.Validators.Add(new CustomValidator { ErrorMessage = errorMessage, IsValid = false });
                    }
                }
            }
            else
            {
                CogIdHiddenField.Value = string.Empty;
                CogIdDisplayLabel.Text = string.Empty;
                CogNameDisplayTextBox.Text = string.Empty;
                CogDescriptionDisplayTextBox.Text = string.Empty;
            }
        }

    
    }
}