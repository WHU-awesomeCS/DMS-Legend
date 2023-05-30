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
    /// 学生管理
    /// </summary>
	[Table("Students")]

    [Display(Name = "_Model.Student")]
    public class Student : BasePoco
    {
        [Display(Name = "_Model._Student._StudentName")]
        [StringLength(15, ErrorMessage = "Validate.{0}stringmax{1}")]
        [Comment("学生姓名")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public string StudentName { get; set; }
        [Display(Name = "_Model._Student._Department")]
        [Comment("所在院系")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public DepartmentTypeEnumerateEnum? Department { get; set; }
        [Display(Name = "_Model._Student._Gender")]
        [Comment("性别")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public GenderEnum? Gender { get; set; }
        [Display(Name = "_Model._Student._BirthDate")]
        [Comment("生日")]
        [Required(ErrorMessage = "Validate.{0}required")]
        [RegularExpression("^(19|20)(9[0-9]|0[0-9])(0[1-9]|1[0-2])([0-2][0-9]|30)$", ErrorMessage = "Validate.{0}formaterror")]
        public string BirthDate { get; set; }
        [Display(Name = "_Model._Student._Telephone")]
        [Comment("电话")]
        [Required(ErrorMessage = "Validate.{0}required")]
        [RegularExpression("^[1][345789][0-9]{9}$", ErrorMessage = "Validate.{0}formaterror")]
        public string Telephone { get; set; }
        [Display(Name = "_Model._Student._DormitoryNum")]
        [Comment("宿舍号")]
        [Range(1,50,ErrorMessage="Validate.{0}range{1}{2}")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public int? DormitoryNum { get; set; }
        [Display(Name = "_Model._Student._RoomNum")]
        [Comment("房间号")]
        [Range(100,999,ErrorMessage="Validate.{0}range{1}{2}")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public int? RoomNum { get; set; }
        [Display(Name = "_Model._Student._WhetherLeave")]
        [Comment("是否离开")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public bool? WhetherLeave { get; set; }
        [Display(Name = "_Model._Student._LeaveTime")]
        [Comment("离开时间")]
        public DateTime? LeaveTime { get; set; }
        [Key]
        [Display(Name = "_Model._Student._ID")]
        [Required(ErrorMessage = "Validate.{0}required")]
        [Column("StuedentID")]
        public new int ID { get; set; }
        [Display(Name = "_Model._Student._StudentID")]
        [Comment("学生学号")]
        [Range(1000000,9999999,ErrorMessage="Validate.{0}range{1}{2}")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public long? StudentID { get; set; }
        [Display(Name = "_Model._Student._BedNum")]
        [Comment("床位号")]
        [Range(1,4,ErrorMessage="Validate.{0}range{1}{2}")]
        [Required(ErrorMessage = "Validate.{0}required")]
        public int? BedNum { get; set; }
        [Display(Name = "宿舍管理")]
        [InverseProperty("StudentID")]
        public List<Dormitory> Dormitory_StudentID { get; set; }

	}

}
