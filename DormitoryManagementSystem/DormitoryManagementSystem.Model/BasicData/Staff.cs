using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkingTec.Mvvm.Core;
using System.Text.Json.Serialization;
using DormitoryManagementSystem.Model;

namespace DormitoryManagementSystem.Model.BasicData
{
    /// <summary>
    /// 职工管理
    /// </summary>
	[Table("Staffs")]

    [Display(Name = "_Model.Staff")]
    public class Staff : BasePoco
    {
        [Display(Name = "_Model._Staff._WorkID")]
        [Comment("工号")]
        [Range(10000,90000,ErrorMessage="Validate.{0}range{1}{2}")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public int? WorkID { get; set; }
        [Display(Name = "_Model._Staff._Name")]
        [StringLength(15, ErrorMessage = "Validate.{0}stringmax{1}")]
        [Comment("姓名")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public string Name { get; set; }
        [Display(Name = "_Model._Staff._Sector")]
        [Comment("部门")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public SectorTypeEnumerateEnum? Sector { get; set; }
        [Display(Name = "_Model._Staff._Telephone")]
        [Comment("电话")]
        [Required(ErrorMessage = "Validate.{0}required")]
        [RegularExpression("^[1][345789][0-9]{9}$", ErrorMessage = "Validate.{0}formaterror")]
        public string Telephone { get; set; }
        [Display(Name = "_Model._Staff._Email")]
        [Comment("邮箱")]
        [RegularExpression("^[a-zA-Z0-9_-]+@[a-zA-Z0-9_-]+(\\.[a-zA-Z0-9_-]+)+$", ErrorMessage = "Validate.{0}formaterror")]
        public string Email { get; set; }
        [Display(Name = "_Model._Staff._DormitoryNum")]
        [Comment("管理宿舍号")]
        [Range(1,50,ErrorMessage="Validate.{0}range{1}{2}")]
        public int? DormitoryNum { get; set; }

	}

}
