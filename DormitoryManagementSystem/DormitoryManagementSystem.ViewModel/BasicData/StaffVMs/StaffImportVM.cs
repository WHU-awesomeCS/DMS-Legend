
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using DormitoryManagementSystem.Model.BasicData;
using DormitoryManagementSystem.Model;

namespace DormitoryManagementSystem.ViewModel.BasicData.StaffVMs
{
    public partial class StaffTemplateVM : BaseTemplateVM
    {
        
        [Display(Name = "_Model._Staff._WorkID")]
        public ExcelPropety WorkID_Excel = ExcelPropety.CreateProperty<Staff>(x => x.WorkID);
        [Display(Name = "_Model._Staff._Name")]
        public ExcelPropety Name_Excel = ExcelPropety.CreateProperty<Staff>(x => x.Name);
        [Display(Name = "_Model._Staff._Sector")]
        public ExcelPropety Sector_Excel = ExcelPropety.CreateProperty<Staff>(x => x.Sector);
        [Display(Name = "_Model._Staff._Telephone")]
        public ExcelPropety Telephone_Excel = ExcelPropety.CreateProperty<Staff>(x => x.Telephone);
        [Display(Name = "_Model._Staff._Email")]
        public ExcelPropety Email_Excel = ExcelPropety.CreateProperty<Staff>(x => x.Email);
        [Display(Name = "_Model._Staff._DormitoryNum")]
        public ExcelPropety DormitoryNum_Excel = ExcelPropety.CreateProperty<Staff>(x => x.DormitoryNum);
        [Display(Name = "_Model._Staff._CreateTime")]
        public ExcelPropety CreateTime_Excel = ExcelPropety.CreateProperty<Staff>(x => x.CreateTime, true);
        [Display(Name = "_Model._Staff._UpdateTime")]
        public ExcelPropety UpdateTime_Excel = ExcelPropety.CreateProperty<Staff>(x => x.UpdateTime, true);
        [Display(Name = "_Model._Staff._CreateBy")]
        public ExcelPropety CreateBy_Excel = ExcelPropety.CreateProperty<Staff>(x => x.CreateBy);
        [Display(Name = "_Model._Staff._UpdateBy")]
        public ExcelPropety UpdateBy_Excel = ExcelPropety.CreateProperty<Staff>(x => x.UpdateBy);

	    protected override void InitVM()
        {
            
        }

    }

    public class StaffImportVM : BaseImportVM<StaffTemplateVM, Staff>
    {
        //import

    }

}