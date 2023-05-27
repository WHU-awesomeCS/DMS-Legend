
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

namespace DormitoryManagementSystem.ViewModel.BasicData.ApplicationVMs
{
    public partial class ApplicationBatchVM : BaseBatchVM<Application, Application_BatchEdit>
    {
        public ApplicationBatchVM()
        {
            ListVM = new ApplicationListVM();
            LinkedVM = new Application_BatchEdit();
        }

        public override bool DoBatchEdit()
        {
            
            return base.DoBatchEdit();
        }
    }

	/// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class Application_BatchEdit : BaseVM
    {

        
        [Display(Name = "_Model._Application._AppType")]
        public ApplicationTypeEnum? AppType { get; set; }
        [Display(Name = "_Model._Application._StatTime")]
        public DateTime? StatTime { get; set; }
        [Display(Name = "_Model._Application._EndTime")]
        public DateTime? EndTime { get; set; }
        [Display(Name = "_Model._Application._StatusProcess")]
        public ProcessStatusEnum? StatusProcess { get; set; }

        protected override void InitVM()
        {
           
        }
    }

}