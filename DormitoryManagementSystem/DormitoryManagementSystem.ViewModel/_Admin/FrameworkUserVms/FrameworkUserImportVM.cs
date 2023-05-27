
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using DormitoryManagementSystem.Model;

namespace DormitoryManagementSystem.ViewModel._Admin.FrameworkUserVMs
{
    public partial class FrameworkUserTemplateVM : BaseTemplateVM
    {
        
        [Display(Name = "_Model._FrameworkUser._Email")]
        public ExcelPropety Email_Excel = ExcelPropety.CreateProperty<FrameworkUser>(x => x.Email);
        [Display(Name = "_Model._FrameworkUser._Gender")]
        public ExcelPropety Gender_Excel = ExcelPropety.CreateProperty<FrameworkUser>(x => x.Gender);
        [Display(Name = "_Model._FrameworkUser._CellPhone")]
        public ExcelPropety CellPhone_Excel = ExcelPropety.CreateProperty<FrameworkUser>(x => x.CellPhone);
        [Display(Name = "_Model._FrameworkUser._HomePhone")]
        public ExcelPropety HomePhone_Excel = ExcelPropety.CreateProperty<FrameworkUser>(x => x.HomePhone);
        [Display(Name = "_Model._FrameworkUser._Address")]
        public ExcelPropety Address_Excel = ExcelPropety.CreateProperty<FrameworkUser>(x => x.Address);
        [Display(Name = "_Model._FrameworkUser._ZipCode")]
        public ExcelPropety ZipCode_Excel = ExcelPropety.CreateProperty<FrameworkUser>(x => x.ZipCode);
        [Display(Name = "_Model._FrameworkUser._ITCode")]
        public ExcelPropety ITCode_Excel = ExcelPropety.CreateProperty<FrameworkUser>(x => x.ITCode);
        [Display(Name = "_Model._FrameworkUser._Password")]
        public ExcelPropety Password_Excel = ExcelPropety.CreateProperty<FrameworkUser>(x => x.Password);
        [Display(Name = "_Model._FrameworkUser._Name")]
        public ExcelPropety Name_Excel = ExcelPropety.CreateProperty<FrameworkUser>(x => x.Name);
        [Display(Name = "_Model._FrameworkUser._IsValid")]
        public ExcelPropety IsValid_Excel = ExcelPropety.CreateProperty<FrameworkUser>(x => x.IsValid);
        [Display(Name = "_Model._FrameworkUser._CreateTime")]
        public ExcelPropety CreateTime_Excel = ExcelPropety.CreateProperty<FrameworkUser>(x => x.CreateTime, true);
        [Display(Name = "_Model._FrameworkUser._UpdateTime")]
        public ExcelPropety UpdateTime_Excel = ExcelPropety.CreateProperty<FrameworkUser>(x => x.UpdateTime, true);
        [Display(Name = "_Model._FrameworkUser._CreateBy")]
        public ExcelPropety CreateBy_Excel = ExcelPropety.CreateProperty<FrameworkUser>(x => x.CreateBy);
        [Display(Name = "_Model._FrameworkUser._UpdateBy")]
        public ExcelPropety UpdateBy_Excel = ExcelPropety.CreateProperty<FrameworkUser>(x => x.UpdateBy);

	    protected override void InitVM()
        {
            
        }

    }

    public class FrameworkUserImportVM : BaseImportVM<FrameworkUserTemplateVM, FrameworkUser>
    {
        //import

    }

}