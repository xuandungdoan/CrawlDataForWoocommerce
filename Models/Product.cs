using System;
using System.Collections.Generic;
using System.Text;

namespace WebAutomation.Models
{
    public class Product
    {
        //Properties
        public string ID { get; set; }
        public string Type { get; set; }
        public string SKU { get; set; }
        public string Name { get; set; }
        public string Published { get; set; }
        public string IsFeatured { get; set; }
        public string VisibilityInCatalog { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string DateSalePriceStarts { get; set; }
        public string DateSalePriceEnds { get; set; }
        public string TaxStatus { get; set; }
        public string TaxClass { get; set; }
        public string InStock { get; set; }
        public string Stock { get; set; }
        public string LowStockAmount { get; set; }
        public string BackordersAllowed { get; set; }
        public string SoldIndividually { get; set; }
        public string Weight { get; set; }
        public string Length { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string AllowCustomerReviews { get; set; }
        public string PurchaseNote { get; set; }
        public double SalePrice { get; set; }
        public double RegularPrice { get; set; }
        public string Categories { get; set; }
        public string Tags { get; set; }
        public string ShippingClass { get; set; }
        public string Images { get; set; }
        public string DownloadLimit { get; set; }
        public string DownloadExpiryDays { get; set; }
        public string Parent { get; set; }
        public string GroupedProducts { get; set; }
        public string Upsells { get; set; }
        public string CrossSells { get; set; }
        public string ExternalURL { get; set; }
        public string ButtonText { get; set; }
        public string Position { get; set; }
        public string Attribute1Name { get; set; }
        public string Attribute1Value { get; set; }
        public string Attribute1Visible { get; set; }
        public string Attribute1Global { get; set; }
        public string Attribute1Default { get; set; }
        public string Attribute2Name { get; set; }
        public string Attribute2Value { get; set; }
        public string Attribute2Visible { get; set; }
        public string Attribute2Global { get; set; }
        public string Attribute2Default { get; set; }
        public string Attribute3Name { get; set; }
        public string Attribute3Value { get; set; }
        public string Attribute3Visible { get; set; }
        public string Attribute3Global { get; set; }
        public string Attribute3Default { get; set; }
        public string Attribute4Name { get; set; }
        public string Attribute4Value { get; set; }
        public string Attribute4Visible { get; set; }
        public string Attribute4Global { get; set; }
        public string Attribute4Default { get; set; }
        public string Attribute5Name { get; set; }
        public string Attribute5Value { get; set; }
        public string Attribute5Visible { get; set; }
        public string Attribute5Global { get; set; }
        public string Attribute5Default { get; set; }
        public string Attribute6Name { get; set; }
        public string Attribute6Value { get; set; }
        public string Attribute6Visible { get; set; }
        public string Attribute6Global { get; set; }
        public string Attribute6Default { get; set; }
        public string Attribute7Name { get; set; }
        public string Attribute7Value { get; set; }
        public string Attribute7Visible { get; set; }
        public string Attribute7Global { get; set; }
        public string Attribute7Default { get; set; }
        public string Attribute8Name { get; set; }
        public string Attribute8Value { get; set; }
        public string Attribute8Visible { get; set; }
        public string Attribute8Global { get; set; }
        public string Attribute8Default { get; set; }
        public string Attribute9Name { get; set; }
        public string Attribute9Value { get; set; }
        public string Attribute9Visible { get; set; }
        public string Attribute9Global { get; set; }
        public string Attribute9Default { get; set; }
        public string Attribute10Name { get; set; }
        public string Attribute10Value { get; set; }
        public string Attribute10Visible { get; set; }
        public string Attribute10Global { get; set; }
        public string Attribute10Default { get; set; }


        //Constructor
        public Product()
        {
            this.ID = "";
            this.Type = "simple";
            this.SKU = "";
            this.Name = "";
            this.Published = "1";
            this.IsFeatured = "0";
            this.VisibilityInCatalog = "visible";
            this.ShortDescription = "<ul>\n<li> Nhập mã<strong>[HE10] </ strong > giảm thêm 10K cho đơn hàng từ 150K trở lên cho mỗi Nhà Cung Cấp(Chỉ áp dụng cho Danh Mục: ÁO KHÔNG TAY, ÁO TAY NGẮN, ÁO POLO, ÁO CROPTOP, ÁO THUN BASIC, QUẦN NGẮN, TÚI, NÓN, GIÀY, PHỤ KIỆN)</ li >\n<li> Nhập mã<strong>[HE20] </ strong > giảm thêm 20K cho đơn hàng từ 250K trở lên cho mỗi Nhà Cung Cấp(Chỉ áp dụng cho Danh Mục: ÁO KHÔNG TAY, ÁO TAY NGẮN, ÁO POLO, ÁO CROPTOP, ÁO THUN BASIC, QUẦN NGẮN, TÚI, NÓN, GIÀY, PHỤ KIỆN)</ li >\n<li> Nhập mã<strong>[HE50] </ strong > giảm thêm 50K cho đơn hàng từ 500K trở lên cho mỗi Nhà Cung Cấp(Chỉ áp dụng cho Danh Mục: ÁO KHÔNG TAY, ÁO TAY NGẮN, ÁO POLO, ÁO CROPTOP, ÁO THUN BASIC, QUẦN NGẮN, TÚI, NÓN, GIÀY, PHỤ KIỆN)</ li >\n<li> Đăng ký thành viên tặng ngay 20K cùng một mã giảm 5 % < strong >[VENUS_NEW_MEMBER] </ strong ></ li >\n </ ul >";
            this.Description = "";
            this.DateSalePriceStarts = "";
            this.DateSalePriceEnds = "";
            this.TaxStatus = "taxable";
            this.TaxClass = "";
            this.InStock = "1";
            this.Stock = "";
            this.LowStockAmount = "";
            this.BackordersAllowed = "0";
            this.SoldIndividually = "0";
            this.Weight = "";
            this.Length = "";
            this.Width = "";
            this.Height = "";
            this.AllowCustomerReviews = "1";
            this.PurchaseNote = "";
            this.SalePrice = 99999999;
            this.RegularPrice = 999999999;
            this.Categories = "TÚI,";
            this.Tags = "";
            this.ShippingClass = "";
            this.Images = "";
            this.DownloadLimit = "";
            this.DownloadExpiryDays = "";
            this.Parent = "";
            this.GroupedProducts = "";
            this.Upsells = "";
            this.CrossSells = "";
            this.ExternalURL = "";
            this.ButtonText = "";
            this.Position = "0";
            this.Attribute1Name = "Size";
            this.Attribute1Value = "";
            this.Attribute1Visible = "0";
            this.Attribute1Global = "1";
            this.Attribute1Default = "";
            this.Attribute2Name = "Brand ";
            this.Attribute2Value = "";
            this.Attribute2Visible = "0";
            this.Attribute2Global = "1";
            this.Attribute2Default = "";
            this.Attribute3Name = "PriceRange";
            this.Attribute3Value = "";
            this.Attribute3Visible = "0";
            this.Attribute3Global = "1";
            this.Attribute3Default = "";
            this.Attribute4Name = "Gender";
            this.Attribute4Value = "";
            this.Attribute4Visible = "0";
            this.Attribute4Global = "1";
            this.Attribute4Default = "";
            this.Attribute5Name = "ÁO";
            this.Attribute5Value = "";
            this.Attribute5Visible = "0";
            this.Attribute5Global = "1";
            this.Attribute5Default = "";
            this.Attribute6Name = "ÁO KHOÁC";
            this.Attribute6Value = "";
            this.Attribute6Visible = "0";
            this.Attribute6Global = "1";
            this.Attribute6Default = "";
            this.Attribute7Name = "QUẦN";
            this.Attribute7Value = "";
            this.Attribute7Visible = "0";
            this.Attribute7Global = "1";
            this.Attribute7Default = "";
            this.Attribute8Name = "TÚI";
            this.Attribute8Value = "BA LÔ";
            this.Attribute8Visible = "0";
            this.Attribute8Global = "1";
            this.Attribute8Default = "";
            this.Attribute9Name = "GIÀY";
            this.Attribute9Value = "";
            this.Attribute9Visible = "0";
            this.Attribute9Global = "1";
            this.Attribute9Default = "";
            this.Attribute10Name = "PHỤ KIỆN";
            this.Attribute10Value = "";
            this.Attribute10Visible = "0";
            this.Attribute10Global = "1";
            this.Attribute10Default = "";
        }
    }
}


/*
Field	Sample Data	Notes
ID		Để trống
Type	simple	"simple" đối với Product không có Attribute
SKU	ANK-3386NMRG	Lấy field "Internal ID" của Jomashop
Name	Anne Klein Navy Mother of Pearl Dial Ladies Watch ANK-3386NMRG	Lấy tên sản phẩm từ Jomashop -> Translate to VN
Published	1	"1" -> hiển thị lên website ngay lập tức, "0" -> tạm thời chưa hiển thị
Is featured?	0	0 hoặc 1
Visibility in catalog	visible	visible
Short description		Để trống
Description		Lấy từ Jomashop
Date sale price starts		Để trống
Date sale price ends		Để trống
Tax status	taxable	taxable
Tax class		Để trống
In stock?	1	"Có hàng" điền 1, "Không có hàng" điền 0
Stock		Để trống
Low stock amount		Để trống
Backorders allowed?	0	
Sold individually?	0	
Weight(kg)		Để trống
Length(cm)		Để trống
Width(cm)		Để trống
Height(cm)		Để trống
Allow customer reviews?	1	Cho phép khách hàng review sp thì điền 1
Purchase note		Để trống
Sale price	2000000	Final price của Jomashop (Lấy giá $ * 1.1 * 24300 + 350000) . Giá theo VND
Regular price	2820000	Retail price của Jomashop (Lấy giá $ * 1.1 * 24300 + 350000) . Giá theo VND
Categories	Anne Klein, Watches>Anne Klein, Mắt kính nữ	Các category phân cách bởi dấy phẩy, Subcategory bởi dấu >
Tags		Để trống
Shipping class		Để trống
Images	http://images.shipdongho.com/anne-klein-navy-mother-of-pearl-dial-ladies-watch-3386nmrg.jpg,http://images.shipdongho.com/anne-klein-navy-mother-of-pearl-dial-ladies-watch-3386nmrg_2.jpg,http://images.shipdongho.com/anne-klein-navy-mother-of-pearl-dial-ladies-watch-3386nmrg_3.jpg	Gộp tất cả link sản phẩm lại, phân cách bởi dấu phẩy ,
Download limit		Để trống
Download expiry days		Để trống
Parent		Để trống
Grouped products		Để trống
Upsells		Để trống
Cross-sells		Để trống
External URL		Để trống
Button text		Để trống
Position	0	0
Attribute 1 name	Brand	"Brand"
Attribute 1 value(s)	Anne Klein	Lấy Brand từ Jomashop
Attribute 1 visible	0	0
Attribute 1 global	1	1
Attribute 1 default		Để trống
Attribute 2 name	Gender	"Gender"
Attribute 2 value(s)	Nữ	Ladies -> Nữ, Men -> Name, Others (Unisex)
Attribute 2 visible	0	0
Attribute 2 global	1	1
Attribute 2 default		Để trống
Attribute 3 name	Case Size	"Case Size"
Attribute 3 value(s)	40mm	Lấy Case Size từ Jomashop
Attribute 3 visible	0	0
Attribute 3 global	1	1
Attribute 3 default		Để trống
Attribute 4 name	Case Shape	"Case Shape"
Attribute 4 value(s)	Round	Lấy Case Shape từ Jomashop
Attribute 4 visible	0	0
Attribute 4 global	1	1
Attribute 4 default		Để trống
Attribute 5 name	Style	"Style"
Attribute 5 value(s)	H64455533	Lấy Model từ Jomashop
Attribute 5 visible	0	0
Attribute 5 global	1	1
Attribute 5 default		Để trống
Attribute 6 name	Movement	Movement
Attribute 6 value(s)	Automatic	Lấy Movement từ Jomashop
Attribute 6 visible	0	0
Attribute 6 global	1	1
Attribute 6 default		Để trống
Attribute 7 name	PriceRange	PriceRange
Attribute 7 value(s)	<= 2.000.000	Có 4 range: <= 2.000.000 VND, 2.000.000 - 4.000.000 VND, > 4.000.000 VND (So với giá bán)
Attribute 7 visible	0	0
Attribute 7 global	1	1
Attribute 7 default		Để trống
Attribute 8 name	Band Type	"Band Type"
Attribute 8 value(s)	Strap	Lấy Band Type từ Jomashop
Attribute 8 visible	0	0
Attribute 8 global	1	1
Attribute 8 default		Để trống
Attribute 9 name	Collection	Collection
Attribute 9 value(s)	Anne Klein	Lấy Brand từ Jomashop
Attribute 9 visible	0	0
Attribute 9 global	1	1
Attribute 9 default		Để trống
Attribute 10 name	Country of Origin	Country of Origin
Attribute 10 value(s)	US	US, EU, VN, FR
Attribute 10 visible	0	
Attribute 10 global	1	
Attribute 10 default		Để trống
*/

/*

 */
