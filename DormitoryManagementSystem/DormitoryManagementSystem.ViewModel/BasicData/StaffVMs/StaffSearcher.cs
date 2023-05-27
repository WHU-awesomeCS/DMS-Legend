
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using DormitoryManagementSystem.Model.BasicData;
using DormitoryManagementSystem.Model;
namespace DormitoryManagementSystem.ViewModel.BasicData.StaffVMs
{
    public partial class StaffSearcher : BaseSearcher
    {
        
        [Display(Name = "_Model._Staff._WorkID")]
        public int? WorkID { get; set; }
        [Display(Name = "_Model._Staff._Name")]
        public string Name { get; set; }
        [Display(Name = "_Model._Staff._Sector")]
        public SectorTypeEnumerateEnum? Sector { get; set; }
        [Display(Name = "_Model._Staff._Telephone")]
        public string Telephone { get; set; }
        [Display(Name = "_Model._Staff._Email")]
        public string Email { get; set; }
        [Display(Name = "_Model._Staff._DormitoryNum")]
        public int? DormitoryNum { get; set; }
        [Display(Name = "_Model._Staff._CreateTime")]
        public DateRange CreateTime { get; set; }
        [Display(Name = "_Model._Staff._UpdateTime")]
        public DateRange UpdateTime { get; set; }
        [Display(Name = "_Model._Staff._CreateBy")]
        public string CreateBy { get; set; }
        [Display(Name = "_Model._Staff._UpdateBy")]
        public string UpdateBy { get; set; }

        protected override void InitVM()
        {
            
        }
    }

}