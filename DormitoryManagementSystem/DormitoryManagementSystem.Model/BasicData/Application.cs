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
    /// 申请管理
    /// </summary>
	[Table("Applications")]

    [Display(Name = "_Model.Application")]
    public class Application : BasePoco
    {
        [Display(Name = "_Model._Application._AppType")]
        [Comment("申请类型")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public ApplicationTypeEnum? AppType { get; set; }
        [Display(Name = "_Model._Application._AppliName")]
        [StringLength(15, ErrorMessage = "Validate.{0}stringmax{1}")]
        [Comment("申请人姓名")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public string AppliName { get; set; }
        [Display(Name = "_Model._Application._IdentityID")]
        [StringLength(18, ErrorMessage = "Validate.{0}stringmax{1}")]
        [Comment("身份证号")]
        [Required(ErrorMessage = "Validate.{0}required")]
        [RegularExpression("^(\\d{17})([0-9]|X)$", ErrorMessage = "Validate.{0}formaterror")]
        public string IdentityID { get; set; }
        [Display(Name = "_Model._Application._StatTime")]
        [Comment("开始时间")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public DateTime? StatTime { get; set; }
        [Display(Name = "_Model._Application._EndTime")]
        [Comment("结束时间")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public DateTime? EndTime { get; set; }
        [Display(Name = "_Model._Application._StatusProcess")]
        [Comment("申请状态")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public ProcessStatusEnum? StatusProcess { get; set; }

	}

}
