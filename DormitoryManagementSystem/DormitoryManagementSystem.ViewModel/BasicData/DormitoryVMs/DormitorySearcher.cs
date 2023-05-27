
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using DormitoryManagementSystem.Model.BasicData;
using DormitoryManagementSystem.Model;
namespace DormitoryManagementSystem.ViewModel.BasicData.DormitoryVMs
{
    public partial class DormitorySearcher : BaseSearcher
    {
        
        [Display(Name = "_Model._Dormitory._DormitoryNum")]
        public int? DormitoryNum { get; set; }
        [Display(Name = "_Model._Dormitory._AvailableBed")]
        public int? AvailableBed { get; set; }
        [Display(Name = "_Model._Dormitory._SumBed")]
        public int? SumBed { get; set; }
        [Display(Name = "_Model._Dormitory._RoomNum")]
        public int? RoomNum { get; set; }
        [Display(Name = "_Model._Dormitory._BedNum")]
        public int? BedNum { get; set; }
        [Display(Name = "_Model._Dormitory._StudentID")]
        public int? StudentIDId { get; set; }
        [Display(Name = "_Model._Dormitory._CreateTime")]
        public DateRange CreateTime { get; set; }
        [Display(Name = "_Model._Dormitory._UpdateTime")]
        public DateRange UpdateTime { get; set; }
        [Display(Name = "_Model._Dormitory._CreateBy")]
        public string CreateBy { get; set; }
        [Display(Name = "_Model._Dormitory._UpdateBy")]
        public string UpdateBy { get; set; }

        protected override void InitVM()
        {
            

        }
    }

}