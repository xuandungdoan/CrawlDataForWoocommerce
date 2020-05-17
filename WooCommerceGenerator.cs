using System;
using System.Collections.Generic;
using System.Text;

namespace WebAutomation
{
    public class WooCommerceGenerator
    {
        /// <summary>
        /// Generate template for importing product to WooCommerce
        /// </summary>
        /// <param name="products">List of product information crawled from Jomashop</param>
        /// <param name="templateFile">Save as template file name</param>
        public void GenerateProductImportTemplate(List<Models.Product> products, string templateFile)
        {
            string dataFormat = "ID@Type@SKU@Name@Published@\"Is featured?\"@\"Visibility in catalog\"@\"Short description\"@Description@\"Date sale price starts\"@\"Date sale price ends\"@\"Tax status\"@\"Tax class\"@\"In stock?\"@Stock@\"Low stock amount\"@\"Backorders allowed?\"@\"Sold individually?\"@\"Weight(kg)\"@\"Length(cm)\"@\"Width(cm)\"@\"Height(cm)\"@\"Allow customer reviews?\"@\"Purchase note\"@\"Sale price\"@\"Regular price\"@Categories@Tags@\"Shipping class\"@Images@\"Download limit\"@\"Download expiry days\"@Parent@\"Grouped products\"@Upsells@Cross-sells@\"External URL\"@\"Button text\"@Position@\"Attribute 1 name\"@\"Attribute 1 value(s)\"@\"Attribute 1 visible\"@\"Attribute 1 global\"@\"Attribute 1 default\"@\"Attribute 2 name\"@\"Attribute 2 value(s)\"@\"Attribute 2 visible\"@\"Attribute 2 global\"@\"Attribute 2 default\"@\"Attribute 3 name\"@\"Attribute 3 value(s)\"@\"Attribute 3 visible\"@\"Attribute 3 global\"@\"Attribute 3 default\"@\"Attribute 4 name\"@\"Attribute 4 value(s)\"@\"Attribute 4 visible\"@\"Attribute 4 global\"@\"Attribute 4 default\"@\"Attribute 5 name\"@\"Attribute 5 value(s)\"@\"Attribute 5 visible\"@\"Attribute 5 global\"@\"Attribute 5 default\"@\"Attribute 6 name\"@\"Attribute 6 value(s)\"@\"Attribute 6 visible\"@\"Attribute 6 global\"@\"Attribute 6 default\"@\"Attribute 7 name\"@\"Attribute 7 value(s)\"@\"Attribute 7 visible\"@\"Attribute 7 global\"@\"Attribute 7 default\"@\"Attribute 8 name\"@\"Attribute 8 value(s)\"@\"Attribute 8 visible\"@\"Attribute 8 global\"@\"Attribute 8 default\"@\"Attribute 9 name\"@\"Attribute 9 value(s)\"@\"Attribute 9 visible\"@\"Attribute 9 global\"@\"Attribute 9 default\"";

            System.IO.StreamWriter writer = new System.IO.StreamWriter(templateFile);
            //Write header
            
            string header = dataFormat;
            writer.WriteLine(header);

            //Write data row
            foreach(var product in products)
            {
                string dataRow = dataFormat;
                dataRow = dataRow.Replace("ID", product.ID);
                dataRow = dataRow.Replace("Type", product.Type);
                dataRow = dataRow.Replace("SKU", product.SKU);
                dataRow = dataRow.Replace("Name", product.Name);
                dataRow = dataRow.Replace("Published", product.Published);
                dataRow = dataRow.Replace("Is featured?", product.IsFeatured);
                dataRow = dataRow.Replace("Visibility in catalog", product.VisibilityInCatalog);
                dataRow = dataRow.Replace("Short description", product.ShortDescription);
                dataRow = dataRow.Replace("Description", product.Description);
                dataRow = dataRow.Replace("Date sale price starts", product.DateSalePriceStarts);
                dataRow = dataRow.Replace("Date sale price ends", product.DateSalePriceEnds);
                dataRow = dataRow.Replace("Tax status", product.TaxStatus);
                dataRow = dataRow.Replace("Tax class", product.TaxClass);
                dataRow = dataRow.Replace("In stock?", product.InStock);
                dataRow = dataRow.Replace("Stock", product.Stock);
                dataRow = dataRow.Replace("Low stock amount", product.LowStockAmount);
                dataRow = dataRow.Replace("Backorders allowed?", product.BackordersAllowed);
                dataRow = dataRow.Replace("Sold individually?", product.SoldIndividually);
                dataRow = dataRow.Replace("Weight(kg)", product.Weight);
                dataRow = dataRow.Replace("Length(cm)", product.Length);
                dataRow = dataRow.Replace("Width(cm)", product.Width);
                dataRow = dataRow.Replace("Height(cm)", product.Height);
                dataRow = dataRow.Replace("Allow customer reviews?", product.AllowCustomerReviews);
                dataRow = dataRow.Replace("Purchase note", product.PurchaseNote);
                dataRow = dataRow.Replace("Sale price", product.SalePrice.ToString());
                dataRow = dataRow.Replace("Regular price", product.RegularPrice.ToString());
                dataRow = dataRow.Replace("Categories", product.Categories);
                dataRow = dataRow.Replace("Tags", product.Tags);
                dataRow = dataRow.Replace("Shipping class", product.ShippingClass);
                dataRow = dataRow.Replace("Images", product.Images);
                dataRow = dataRow.Replace("Download limit", product.DownloadLimit);
                dataRow = dataRow.Replace("Download expiry days", product.DownloadExpiryDays);
                dataRow = dataRow.Replace("Parent", product.Parent);
                dataRow = dataRow.Replace("Grouped products", product.GroupedProducts);
                dataRow = dataRow.Replace("Upsells", product.Upsells);
                dataRow = dataRow.Replace("Cross-sells", product.CrossSells);
                dataRow = dataRow.Replace("External URL", product.ExternalURL);
                dataRow = dataRow.Replace("Button text", product.ButtonText);
                dataRow = dataRow.Replace("Position", product.Position);
                dataRow = dataRow.Replace("Attribute 1 name", product.Attribute1Name);
                dataRow = dataRow.Replace("Attribute 1 value(s)", product.Attribute1Value);
                dataRow = dataRow.Replace("Attribute 1 visible", product.Attribute1Visible);
                dataRow = dataRow.Replace("Attribute 1 global", product.Attribute1Global);
                dataRow = dataRow.Replace("Attribute 1 default", product.Attribute1Default);
                dataRow = dataRow.Replace("Attribute 2 name", product.Attribute2Name);
                dataRow = dataRow.Replace("Attribute 2 value(s)", product.Attribute2Value);
                dataRow = dataRow.Replace("Attribute 2 visible", product.Attribute2Visible);
                dataRow = dataRow.Replace("Attribute 2 global", product.Attribute2Global);
                dataRow = dataRow.Replace("Attribute 2 default", product.Attribute2Default);
                dataRow = dataRow.Replace("Attribute 3 name", product.Attribute3Name);
                dataRow = dataRow.Replace("Attribute 3 value(s)", product.Attribute3Value);
                dataRow = dataRow.Replace("Attribute 3 visible", product.Attribute3Visible);
                dataRow = dataRow.Replace("Attribute 3 global", product.Attribute3Global);
                dataRow = dataRow.Replace("Attribute 3 default", product.Attribute3Default);
                dataRow = dataRow.Replace("Attribute 4 name", product.Attribute4Name);
                dataRow = dataRow.Replace("Attribute 4 value(s)", product.Attribute4Value);
                dataRow = dataRow.Replace("Attribute 4 visible", product.Attribute4Visible);
                dataRow = dataRow.Replace("Attribute 4 global", product.Attribute4Global);
                dataRow = dataRow.Replace("Attribute 4 default", product.Attribute4Default);
                dataRow = dataRow.Replace("Attribute 5 name", product.Attribute5Name);
                dataRow = dataRow.Replace("Attribute 5 value(s)", product.Attribute5Value);
                dataRow = dataRow.Replace("Attribute 5 visible", product.Attribute5Visible);
                dataRow = dataRow.Replace("Attribute 5 global", product.Attribute5Global);
                dataRow = dataRow.Replace("Attribute 5 default", product.Attribute5Default);
                dataRow = dataRow.Replace("Attribute 6 name", product.Attribute6Name);
                dataRow = dataRow.Replace("Attribute 6 value(s)", product.Attribute6Value);
                dataRow = dataRow.Replace("Attribute 6 visible", product.Attribute6Visible);
                dataRow = dataRow.Replace("Attribute 6 global", product.Attribute6Global);
                dataRow = dataRow.Replace("Attribute 6 default", product.Attribute6Default);
                dataRow = dataRow.Replace("Attribute 7 name", product.Attribute7Name);
                dataRow = dataRow.Replace("Attribute 7 value(s)", product.Attribute7Value);
                dataRow = dataRow.Replace("Attribute 7 visible", product.Attribute7Visible);
                dataRow = dataRow.Replace("Attribute 7 global", product.Attribute7Global);
                dataRow = dataRow.Replace("Attribute 7 default", product.Attribute7Default);
                dataRow = dataRow.Replace("Attribute 8 name", product.Attribute8Name);
                dataRow = dataRow.Replace("Attribute 8 value(s)", product.Attribute8Value);
                dataRow = dataRow.Replace("Attribute 8 visible", product.Attribute8Visible);
                dataRow = dataRow.Replace("Attribute 8 global", product.Attribute8Global);
                dataRow = dataRow.Replace("Attribute 8 default", product.Attribute8Default);
                dataRow = dataRow.Replace("Attribute 9 name", product.Attribute9Name);
                dataRow = dataRow.Replace("Attribute 9 value(s)", product.Attribute9Value);
                dataRow = dataRow.Replace("Attribute 9 visible", product.Attribute9Visible);
                dataRow = dataRow.Replace("Attribute 9 global", product.Attribute9Global);
                dataRow = dataRow.Replace("Attribute 9 default", product.Attribute9Default);
                 dataRow = dataRow.Replace("Attribute 10 name", product.Attribute10Name);
                dataRow = dataRow.Replace("Attribute 10 value(s)", product.Attribute10Value);
                dataRow = dataRow.Replace("Attribute 10 visible", product.Attribute10Visible);
                dataRow = dataRow.Replace("Attribute 10 global", product.Attribute10Global);
                dataRow = dataRow.Replace("Attribute 10 default", product.Attribute10Default);
                writer.WriteLine(dataRow);
            }
            writer.Close();
        }
    }
}
