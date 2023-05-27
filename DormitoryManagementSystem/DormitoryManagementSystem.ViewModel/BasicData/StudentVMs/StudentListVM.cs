using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using DormitoryManagementSystem.Model.BasicData;
using DormitoryManagementSystem.Model;

namespace DormitoryManagementSystem.ViewModel.BasicData.StudentVMs
{
    public partial class StudentListVM : BasePagedListVM<Student_View, StudentSearcher>
    {
        
        protected override IEnumerable<IGridColumn<Student_View>> InitGridHeader()
        {
            return new List<GridColumn<Student_View>>{
                
                this.MakeGridHeader(x => x.Student_StudentName).SetTitle(@Localizer["Page.学生姓名"].Value),
                this.MakeGridHeader(x => x.Student_Department).SetTitle(@Localizer["Page.所在院系"].Value),
                this.MakeGridHeader(x => x.Student_Gender).SetTitle(@Localizer["_Admin.Gender"].Value),
                this.MakeGridHeader(x => x.Student_BirthDate).SetTitle(@Localizer["Page.生日"].Value),
                this.MakeGridHeader(x => x.Student_Telephone).SetTitle(@Localizer["Page.电话"].Value),
                this.MakeGridHeader(x => x.Student_DormitoryNum).SetTitle(@Localizer["Page.宿舍号"].Value),
                this.MakeGridHeader(x => x.Student_RoomNum).SetTitle(@Localizer["Page.房间号"].Value),
                this.MakeGridHeader(x => x.Student_WhetherLeave).SetTitle(@Localizer["Page.是否离开"].Value),
                this.MakeGridHeader(x => x.Student_LeaveTime).SetTitle(@Localizer["Page.离开时间"].Value),
                this.MakeGridHeader(x => x.Student_StudentID).SetTitle(@Localizer["Page.学生学号"].Value),
                this.MakeGridHeader(x => x.Student_BedNum).SetTitle(@Localizer["Page.床位号"].Value),
                this.MakeGridHeader(x => x.Student_CreateTime).SetTitle(@Localizer["_Admin.CreateTime"].Value),
                this.MakeGridHeader(x => x.Student_UpdateTime).SetTitle(@Localizer["_Admin.UpdateTime"].Value),
                this.MakeGridHeader(x => x.Student_CreateBy).SetTitle(@Localizer["_Admin.CreateBy"].Value),
                this.MakeGridHeader(x => x.Student_UpdateBy).SetTitle(@Localizer["_Admin.UpdateBy"].Value),

                this.MakeGridHeaderAction(width: 200)
            };
        }

        
        public override IOrderedQueryable<Student_View> GetSearchQuery()
        {
            var query = DC.Set<Student>()
                
                .CheckContain(Searcher.StudentName, x=>x.StudentName)
                .CheckEqual(Searcher.Department, x=>x.Department)
                .CheckEqual(Searcher.Gender, x=>x.Gender)
                .CheckContain(Searcher.BirthDate, x=>x.BirthDate)
                .CheckEqual(Searcher.Telephone, x=>x.Telephone)
                .CheckEqual(Searcher.DormitoryNum, x=>x.DormitoryNum)
                .CheckEqual(Searcher.RoomNum, x=>x.RoomNum)
                .CheckEqual(Searcher.WhetherLeave, x=>x.WhetherLeave)
                .CheckBetween(Searcher.LeaveTime?.GetStartTime(), Searcher.LeaveTime?.GetEndTime(), x => x.LeaveTime, includeMax: false)
                .CheckEqual(Searcher.StudentID, x=>x.StudentID)
                .CheckEqual(Searcher.BedNum, x=>x.BedNum)
                .CheckBetween(Searcher.CreateTime?.GetStartTime(), Searcher.CreateTime?.GetEndTime(), x => x.CreateTime, includeMax: false)
                .CheckBetween(Searcher.UpdateTime?.GetStartTime(), Searcher.UpdateTime?.GetEndTime(), x => x.UpdateTime, includeMax: false)
                .CheckContain(Searcher.CreateBy, x=>x.CreateBy)
                .CheckContain(Searcher.UpdateBy, x=>x.UpdateBy)
                .DPWhere(Wtm, x => x.ID)
                .Select(x => new Student_View
                {
				    ID = x.ID,
                    
                    Student_StudentName = x.StudentName,
                    Student_Department = x.Department,
                    Student_Gender = x.Gender,
                    Student_BirthDate = x.BirthDate,
                    Student_Telephone = x.Telephone,
                    Student_DormitoryNum = x.DormitoryNum,
                    Student_RoomNum = x.RoomNum,
                    Student_WhetherLeave = x.WhetherLeave,
                    Student_LeaveTime = x.LeaveTime,
                    Student_StudentID = x.StudentID,
                    Student_BedNum = x.BedNum,
                    Student_CreateTime = x.CreateTime,
                    Student_UpdateTime = x.UpdateTime,
                    Student_CreateBy = x.CreateBy,
                    Student_UpdateBy = x.UpdateBy,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }
    public class Student_View: Student
    {
        
        public string Student_StudentName { get; set; }
        public DepartmentTypeEnumerateEnum? Student_Department { get; set; }
        public GenderEnum? Student_Gender { get; set; }
        public string Student_BirthDate { get; set; }
        public string Student_Telephone { get; set; }
        public int? Student_DormitoryNum { get; set; }
        public int? Student_RoomNum { get; set; }
        public bool? Student_WhetherLeave { get; set; }
        public DateTime? Student_LeaveTime { get; set; }
        public long? Student_StudentID { get; set; }
        public int? Student_BedNum { get; set; }
        public DateTime? Student_CreateTime { get; set; }
        public DateTime? Student_UpdateTime { get; set; }
        public string Student_CreateBy { get; set; }
        public string Student_UpdateBy { get; set; }

    }

}