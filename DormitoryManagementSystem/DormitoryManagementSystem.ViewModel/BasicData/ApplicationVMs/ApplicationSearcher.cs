
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using DormitoryManagementSystem.Model.BasicData;
using DormitoryManagementSystem.Model;
namespace DormitoryManagementSystem.ViewModel.BasicData.ApplicationVMs
{
    public partial class ApplicationSearcher : BaseSearcher
    {
        
        [Display(Name = "_Model._Application._AppType")]
        public ApplicationTypeEnum? AppType { get; set; }
        [Display(Name = "_Model._Application._AppliName")]
        public string AppliName { get; set; }
        [Display(Name = "_Model._Application._IdentityID")]
        public string IdentityID { get; set; }
        [Display(Name = "_Model._Application._StatTime")]
        public DateRange StatTime { get; set; }
        [Display(Name = "_Model._Application._EndTime")]
        public DateRange EndTime { get; set; }
        [Display(Name = "_Model._Application._StatusProcess")]
        public ProcessStatusEnum? StatusProcess { get; set; }
        [Display(Name = "_Model._Application._CreateTime")]
        public DateRange CreateTime { get; set; }
        [Display(Name = "_Model._Application._UpdateTime")]
        public DateRange UpdateTime { get; set; }
        [Display(Name = "_Model._Application._CreateBy")]
        public string CreateBy { get; set; }
        [Display(Name = "_Model._Application._UpdateBy")]
        public string UpdateBy { get; set; }

        protected override void InitVM()
        {
            
        }
    }

}