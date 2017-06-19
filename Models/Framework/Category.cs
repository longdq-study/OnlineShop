namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Display(Name = "Tên danh mục")]
        [Required(ErrorMessage="Bạn chưa nhập tên danh mục")]
        public string Name { get; set; }

        [StringLength(50)]
        [Display(Name = "Tiêu đề SEO")]
        public string Alias { get; set; }

        [Display(Name = "Danh mục cha")]
        public int? ParentID { get; set; }

        [Display(Name = "Ngày tạo")]
        public DateTime? CreatedDate { get; set; }

        [Display(Name = "Thứ tự")]
        [Range(0,Int32.MaxValue, ErrorMessage="Bạn phải nhập số")]
        public int? Order { get; set; }

        [Display(Name = "Trạng thái")]
        public bool? Status { get; set; }
    }
}
