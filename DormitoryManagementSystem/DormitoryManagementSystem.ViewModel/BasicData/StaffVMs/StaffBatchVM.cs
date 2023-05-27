
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

namespace DormitoryManagementSystem.ViewModel.BasicData.StaffVMs
{
    public partial class StaffBatchVM : BaseBatchVM<Staff, Staff_BatchEdit>
    {
        public StaffBatchVM()
        {
            ListVM = new StaffListVM();
            LinkedVM = new Staff_BatchEdit();
        }

        public override bool DoBatchEdit()
        {
            
            return base.DoBatchEdit();
        }
    }

	/// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class Staff_BatchEdit : BaseVM
    {

        
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

        protected override void InitVM()
        {
           
        }
    }

}