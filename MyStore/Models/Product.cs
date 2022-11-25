namespace MyStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "Mã sản phẩm không được để trống !")]
        [DisplayName("Mã sản phẩm")]
        public int ProductID { get; set; }


        [Required(ErrorMessage = "Tên sản phẩm không được để trống !")]
        [DisplayName("Tên sản phẩm")]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Danh mục không được để trống !")]

        [Column(TypeName = "text")]
        [DisplayName("Mô tả")]
        public string Description { get; set; }

        [Column(TypeName = "numeric")]
        [DisplayName("Giá nhập")]
        public decimal PurchasePrice { get; set; }

        [Column(TypeName = "numeric")]
        [DisplayName("Giá bán")]
        public decimal Price { get; set; }

        [DisplayName("Số lượng")]
        public int Quantity { get; set; }

        [StringLength(20)]
        [DisplayName("Năm sản xuất")]
        public string Vintage { get; set; }

        [Required(ErrorMessage = "Danh mục không được để trống !")]
        [StringLength(10)]
        [DisplayName("Danh mục")]
        public string CatalogyID { get; set; }

        [Column(TypeName = "text")]
        [DisplayName("Hình ảnh")]
        public string Image { get; set; }

      
        [StringLength(100)]
        [DisplayName("Xuất xứ")]
        public string Region { get; set; }

        public virtual Catalogy Catalogy { get; set; }
    }
}
