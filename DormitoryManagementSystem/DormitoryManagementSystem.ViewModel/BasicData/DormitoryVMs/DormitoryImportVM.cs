
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using DormitoryManagementSystem.Model.BasicData;
using DormitoryManagementSystem.Model;

namespace DormitoryManagementSystem.ViewModel.BasicData.DormitoryVMs
{
    public partial class DormitoryTemplateVM : BaseTemplateVM
    {
        
        [Display(Name = "_Model._Dormitory._DormitoryNum")]
        public ExcelPropety DormitoryNum_Excel = ExcelPropety.CreateProperty<Dormitory>(x => x.DormitoryNum);
        [Display(Name = "_Model._Dormitory._AvailableBed")]
        public ExcelPropety AvailableBed_Excel = ExcelPropety.CreateProperty<Dormitory>(x => x.AvailableBed);
        [Display(Name = "_Model._Dormitory._SumBed")]
        public ExcelPropety SumBed_Excel = ExcelPropety.CreateProperty<Dormitory>(x => x.SumBed);
        [Display(Name = "_Model._Dormitory._RoomNum")]
        public ExcelPropety RoomNum_Excel = ExcelPropety.CreateProperty<Dormitory>(x => x.RoomNum);
        [Display(Name = "_Model._Dormitory._BedNum")]
        public ExcelPropety BedNum_Excel = ExcelPropety.CreateProperty<Dormitory>(x => x.BedNum);
        [Display(Name = "_Model._Dormitory._StudentID")]
        public ExcelPropety StudentID_Excel = ExcelPropety.CreateProperty<Dormitory>(x => x.StudentIDId);
        [Display(Name = "_Model._Dormitory._CreateTime")]
        public ExcelPropety CreateTime_Excel = ExcelPropety.CreateProperty<Dormitory>(x => x.CreateTime, true);
        [Display(Name = "_Model._Dormitory._UpdateTime")]
        public ExcelPropety UpdateTime_Excel = ExcelPropety.CreateProperty<Dormitory>(x => x.UpdateTime, true);
        [Display(Name = "_Model._Dormitory._CreateBy")]
        public ExcelPropety CreateBy_Excel = ExcelPropety.CreateProperty<Dormitory>(x => x.CreateBy);
        [Display(Name = "_Model._Dormitory._UpdateBy")]
        public ExcelPropety UpdateBy_Excel = ExcelPropety.CreateProperty<Dormitory>(x => x.UpdateBy);

	    protected override void InitVM()
        {
            
            StudentID_Excel.DataType = ColumnDataType.ComboBox;
            StudentID_Excel.ListItems = DC.Set<Student>().GetSelectListItems(Wtm, y => y.StudentName.ToString());

        }

    }

    public class DormitoryImportVM : BaseImportVM<DormitoryTemplateVM, Dormitory>
    {
        //import

    }

}