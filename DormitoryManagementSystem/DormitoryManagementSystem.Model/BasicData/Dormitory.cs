using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WalkingTec.Mvvm.Core;
using System.Text.Json.Serialization;
using DormitoryManagementSystem.Model;
using DormitoryManagementSystem.Model.BasicData;

namespace DormitoryManagementSystem.Model.BasicData
{
    /// <summary>
    /// 宿舍管理
    /// </summary>
	[Table("Dormitorys")]

    [Display(Name = "_Model.Dormitory")]
    public class Dormitory : BasePoco
    {
        [Display(Name = "_Model._Dormitory._DormitoryNum")]
        [Comment("宿舍号")]
        [Range(1,50,ErrorMessage="Validate.{0}range{1}{2}")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public int? DormitoryNum { get; set; }
        [Display(Name = "_Model._Dormitory._AvailableBed")]
        [Comment("可用床位数")]
        [Range(0,1000,ErrorMessage="Validate.{0}range{1}{2}")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public int? AvailableBed { get; set; }
        [Display(Name = "_Model._Dormitory._SumBed")]
        [Comment("总床位数")]
        [Range(1,1000,ErrorMessage="Validate.{0}range{1}{2}")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public int? SumBed { get; set; }
        [Key]
        [Display(Name = "_Model._Dormitory._ID")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public new int ID { get; set; }
        [Display(Name = "_Model._Dormitory._RoomNum")]
        [Comment("房间号")]
        [Range(100,999,ErrorMessage="Validate.{0}range{1}{2}")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public int? RoomNum { get; set; }
        [Display(Name = "_Model._Dormitory._BedNum")]
        [Comment("床位号")]
        [Range(1,4,ErrorMessage="Validate.{0}range{1}{2}")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public int? BedNum { get; set; }
        [Display(Name = "_Model._Dormitory._StudentID")]
        [Comment("学生学号")]
        public Student StudentID { get; set; }
        [Display(Name = "_Model._Dormitory._StudentID")]
        [Comment("学生学号")]
        public int? StudentIDId { get; set; }

	}

}
