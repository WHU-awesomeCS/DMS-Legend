
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using DormitoryManagementSystem.Model.BasicData;
using DormitoryManagementSystem.Model;

namespace DormitoryManagementSystem.ViewModel.BasicData.StudentVMs
{
    public partial class StudentBatchVM : BaseBatchVM<Student, Student_BatchEdit>
    {
        public StudentBatchVM()
        {
            ListVM = new StudentListVM();
            LinkedVM = new Student_BatchEdit();
        }

        public override bool DoBatchEdit()
        {
            
            return base.DoBatchEdit();
        }
    }

	/// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class Student_BatchEdit : BaseVM
    {

        
        [Display(Name = "_Model._Student._StudentName")]
        public string StudentName { get; set; }
        [Display(Name = "_Model._Student._Department")]
        public DepartmentTypeEnumerateEnum? Department { get; set; }
        [Display(Name = "_Model._Student._Gender")]
        public GenderEnum? Gender { get; set; }
        [Display(Name = "_Model._Student._BirthDate")]
        public DateTime? BirthDate { get; set; }
        [Display(Name = "_Model._Student._Telephone")]
        public string Telephone { get; set; }
        [Display(Name = "_Model._Student._WhetherLeave")]
        public bool? WhetherLeave { get; set; }
        [Display(Name = "_Model._Student._LeaveTime")]
        public DateTime? LeaveTime { get; set; }

        protected override void InitVM()
        {
           
        }
    }

}