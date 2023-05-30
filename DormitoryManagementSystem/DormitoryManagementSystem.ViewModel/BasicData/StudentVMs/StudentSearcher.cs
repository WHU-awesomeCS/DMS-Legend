
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using DormitoryManagementSystem.Model.BasicData;
using DormitoryManagementSystem.Model;
namespace DormitoryManagementSystem.ViewModel.BasicData.StudentVMs
{
    public partial class StudentSearcher : BaseSearcher
    {
        
        [Display(Name = "_Model._Student._StudentName")]
        public string StudentName { get; set; }
        [Display(Name = "_Model._Student._Department")]
        public DepartmentTypeEnumerateEnum? Department { get; set; }
        [Display(Name = "_Model._Student._Gender")]
        public GenderEnum? Gender { get; set; }
        [Display(Name = "_Model._Student._BirthDate")]
        public String BirthDate { get; set; }
        [Display(Name = "_Model._Student._Telephone")]
        public string Telephone { get; set; }
        [Display(Name = "_Model._Student._DormitoryNum")]
        public int? DormitoryNum { get; set; }
        [Display(Name = "_Model._Student._RoomNum")]
        public int? RoomNum { get; set; }
        [Display(Name = "_Model._Student._WhetherLeave")]
        public bool? WhetherLeave { get; set; }
        [Display(Name = "_Model._Student._LeaveTime")]
        public DateRange LeaveTime { get; set; }
        [Display(Name = "_Model._Student._StudentID")]
        public long? StudentID { get; set; }
        [Display(Name = "_Model._Student._BedNum")]
        public int? BedNum { get; set; }
        [Display(Name = "_Model._Student._CreateTime")]
        public DateRange CreateTime { get; set; }
        [Display(Name = "_Model._Student._UpdateTime")]
        public DateRange UpdateTime { get; set; }
        [Display(Name = "_Model._Student._CreateBy")]
        public string CreateBy { get; set; }
        [Display(Name = "_Model._Student._UpdateBy")]
        public string UpdateBy { get; set; }

        protected override void InitVM()
        {
            
        }
    }

}