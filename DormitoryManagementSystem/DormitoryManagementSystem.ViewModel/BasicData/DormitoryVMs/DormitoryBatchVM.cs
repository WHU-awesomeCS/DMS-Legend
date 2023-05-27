
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

namespace DormitoryManagementSystem.ViewModel.BasicData.DormitoryVMs
{
    public partial class DormitoryBatchVM : BaseBatchVM<Dormitory, Dormitory_BatchEdit>
    {
        public DormitoryBatchVM()
        {
            ListVM = new DormitoryListVM();
            LinkedVM = new Dormitory_BatchEdit();
        }

        public override bool DoBatchEdit()
        {
            
            return base.DoBatchEdit();
        }
    }

	/// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class Dormitory_BatchEdit : BaseVM
    {

        
        [Display(Name = "_Model._Dormitory._AvailableBed")]
        public int? AvailableBed { get; set; }
        [Display(Name = "_Model._Dormitory._SumBed")]
        public int? SumBed { get; set; }
        [Display(Name = "_Model._Dormitory._StudentID")]
        public int? StudentIDId { get; set; }

        protected override void InitVM()
        {
           
        }
    }

}