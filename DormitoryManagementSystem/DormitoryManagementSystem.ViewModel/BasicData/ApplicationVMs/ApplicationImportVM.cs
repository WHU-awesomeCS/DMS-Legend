
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using DormitoryManagementSystem.Model.BasicData;
using DormitoryManagementSystem.Model;

namespace DormitoryManagementSystem.ViewModel.BasicData.ApplicationVMs
{
    public partial class ApplicationTemplateVM : BaseTemplateVM
    {
        
        [Display(Name = "_Model._Application._AppType")]
        public ExcelPropety AppType_Excel = ExcelPropety.CreateProperty<Application>(x => x.AppType);
        [Display(Name = "_Model._Application._AppliName")]
        public ExcelPropety AppliName_Excel = ExcelPropety.CreateProperty<Application>(x => x.AppliName);
        [Display(Name = "_Model._Application._IdentityID")]
        public ExcelPropety IdentityID_Excel = ExcelPropety.CreateProperty<Application>(x => x.IdentityID);
        [Display(Name = "_Model._Application._StatTime")]
        public ExcelPropety StatTime_Excel = ExcelPropety.CreateProperty<Application>(x => x.StatTime, true);
        [Display(Name = "_Model._Application._EndTime")]
        public ExcelPropety EndTime_Excel = ExcelPropety.CreateProperty<Application>(x => x.EndTime, true);
        [Display(Name = "_Model._Application._StatusProcess")]
        public ExcelPropety StatusProcess_Excel = ExcelPropety.CreateProperty<Application>(x => x.StatusProcess);
        [Display(Name = "_Model._Application._CreateTime")]
        public ExcelPropety CreateTime_Excel = ExcelPropety.CreateProperty<Application>(x => x.CreateTime, true);
        [Display(Name = "_Model._Application._UpdateTime")]
        public ExcelPropety UpdateTime_Excel = ExcelPropety.CreateProperty<Application>(x => x.UpdateTime, true);
        [Display(Name = "_Model._Application._CreateBy")]
        public ExcelPropety CreateBy_Excel = ExcelPropety.CreateProperty<Application>(x => x.CreateBy);
        [Display(Name = "_Model._Application._UpdateBy")]
        public ExcelPropety UpdateBy_Excel = ExcelPropety.CreateProperty<Application>(x => x.UpdateBy);

	    protected override void InitVM()
        {
            
        }

    }

    public class ApplicationImportVM : BaseImportVM<ApplicationTemplateVM, Application>
    {
        //import

    }

}