
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using DormitoryManagementSystem.Model.BasicData;
using DormitoryManagementSystem.Model;

namespace DormitoryManagementSystem.ViewModel.BasicData.StudentVMs
{
    public partial class StudentTemplateVM : BaseTemplateVM
    {
        
        [Display(Name = "_Model._Student._StudentName")]
        public ExcelPropety StudentName_Excel = ExcelPropety.CreateProperty<Student>(x => x.StudentName);
        [Display(Name = "_Model._Student._Department")]
        public ExcelPropety Department_Excel = ExcelPropety.CreateProperty<Student>(x => x.Department);
        [Display(Name = "_Model._Student._Gender")]
        public ExcelPropety Gender_Excel = ExcelPropety.CreateProperty<Student>(x => x.Gender);
        [Display(Name = "_Model._Student._BirthDate")]
        public ExcelPropety BirthDate_Excel = ExcelPropety.CreateProperty<Student>(x => x.BirthDate);
        [Display(Name = "_Model._Student._Telephone")]
        public ExcelPropety Telephone_Excel = ExcelPropety.CreateProperty<Student>(x => x.Telephone);
        [Display(Name = "_Model._Student._DormitoryNum")]
        public ExcelPropety DormitoryNum_Excel = ExcelPropety.CreateProperty<Student>(x => x.DormitoryNum);
        [Display(Name = "_Model._Student._RoomNum")]
        public ExcelPropety RoomNum_Excel = ExcelPropety.CreateProperty<Student>(x => x.RoomNum);
        [Display(Name = "_Model._Student._WhetherLeave")]
        public ExcelPropety WhetherLeave_Excel = ExcelPropety.CreateProperty<Student>(x => x.WhetherLeave);
        [Display(Name = "_Model._Student._LeaveTime")]
        public ExcelPropety LeaveTime_Excel = ExcelPropety.CreateProperty<Student>(x => x.LeaveTime, true);
        [Display(Name = "_Model._Student._StudentID")]
        public ExcelPropety StudentID_Excel = ExcelPropety.CreateProperty<Student>(x => x.StudentID);
        [Display(Name = "_Model._Student._BedNum")]
        public ExcelPropety BedNum_Excel = ExcelPropety.CreateProperty<Student>(x => x.BedNum);
        [Display(Name = "_Model._Student._CreateTime")]
        public ExcelPropety CreateTime_Excel = ExcelPropety.CreateProperty<Student>(x => x.CreateTime, true);
        [Display(Name = "_Model._Student._UpdateTime")]
        public ExcelPropety UpdateTime_Excel = ExcelPropety.CreateProperty<Student>(x => x.UpdateTime, true);
        [Display(Name = "_Model._Student._CreateBy")]
        public ExcelPropety CreateBy_Excel = ExcelPropety.CreateProperty<Student>(x => x.CreateBy);
        [Display(Name = "_Model._Student._UpdateBy")]
        public ExcelPropety UpdateBy_Excel = ExcelPropety.CreateProperty<Student>(x => x.UpdateBy);

	    protected override void InitVM()
        {
            
        }

    }

    public class StudentImportVM : BaseImportVM<StudentTemplateVM, Student>
    {
        //import

    }

}