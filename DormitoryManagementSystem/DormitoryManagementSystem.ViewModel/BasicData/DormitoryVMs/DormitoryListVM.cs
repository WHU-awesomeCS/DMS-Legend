using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using DormitoryManagementSystem.Model.BasicData;
using DormitoryManagementSystem.Model;

namespace DormitoryManagementSystem.ViewModel.BasicData.DormitoryVMs
{
    public partial class DormitoryListVM : BasePagedListVM<Dormitory_View, DormitorySearcher>
    {
        
        protected override IEnumerable<IGridColumn<Dormitory_View>> InitGridHeader()
        {
            return new List<GridColumn<Dormitory_View>>{
                
                this.MakeGridHeader(x => x.Dormitory_DormitoryNum).SetTitle(@Localizer["Page.宿舍号"].Value),
                this.MakeGridHeader(x => x.Dormitory_AvailableBed).SetTitle(@Localizer["Page.可用床位数"].Value),
                this.MakeGridHeader(x => x.Dormitory_SumBed).SetTitle(@Localizer["Page.总床位数"].Value),
                this.MakeGridHeader(x => x.Dormitory_RoomNum).SetTitle(@Localizer["Page.房间号"].Value),
                this.MakeGridHeader(x => x.Dormitory_BedNum).SetTitle(@Localizer["Page.床位号"].Value),
                this.MakeGridHeader(x => x.Dormitory_StudentID).SetTitle(@Localizer["Page.学生学号"].Value),
                this.MakeGridHeader(x => x.Dormitory_CreateTime).SetTitle(@Localizer["_Admin.CreateTime"].Value),
                this.MakeGridHeader(x => x.Dormitory_UpdateTime).SetTitle(@Localizer["_Admin.UpdateTime"].Value),
                this.MakeGridHeader(x => x.Dormitory_CreateBy).SetTitle(@Localizer["_Admin.CreateBy"].Value),
                this.MakeGridHeader(x => x.Dormitory_UpdateBy).SetTitle(@Localizer["_Admin.UpdateBy"].Value),

                this.MakeGridHeaderAction(width: 200)
            };
        }

        
        public override IOrderedQueryable<Dormitory_View> GetSearchQuery()
        {
            var query = DC.Set<Dormitory>()
                
                .CheckEqual(Searcher.DormitoryNum, x=>x.DormitoryNum)
                .CheckEqual(Searcher.AvailableBed, x=>x.AvailableBed)
                .CheckEqual(Searcher.SumBed, x=>x.SumBed)
                .CheckEqual(Searcher.RoomNum, x=>x.RoomNum)
                .CheckEqual(Searcher.BedNum, x=>x.BedNum)
                .CheckEqual(Searcher.StudentIDId, x=>x.StudentIDId)
                .CheckBetween(Searcher.CreateTime?.GetStartTime(), Searcher.CreateTime?.GetEndTime(), x => x.CreateTime, includeMax: false)
                .CheckBetween(Searcher.UpdateTime?.GetStartTime(), Searcher.UpdateTime?.GetEndTime(), x => x.UpdateTime, includeMax: false)
                .CheckContain(Searcher.CreateBy, x=>x.CreateBy)
                .CheckContain(Searcher.UpdateBy, x=>x.UpdateBy)
                .DPWhere(Wtm, x => x.StudentIDId)
                .Select(x => new Dormitory_View
                {
				    ID = x.ID,
                    
                    Dormitory_DormitoryNum = x.DormitoryNum,
                    Dormitory_AvailableBed = x.AvailableBed,
                    Dormitory_SumBed = x.SumBed,
                    Dormitory_RoomNum = x.RoomNum,
                    Dormitory_BedNum = x.BedNum,
                    Dormitory_StudentID = x.StudentID.StudentName,
                    Dormitory_CreateTime = x.CreateTime,
                    Dormitory_UpdateTime = x.UpdateTime,
                    Dormitory_CreateBy = x.CreateBy,
                    Dormitory_UpdateBy = x.UpdateBy,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }
    public class Dormitory_View: Dormitory
    {
        
        public int? Dormitory_DormitoryNum { get; set; }
        public int? Dormitory_AvailableBed { get; set; }
        public int? Dormitory_SumBed { get; set; }
        public int? Dormitory_RoomNum { get; set; }
        public int? Dormitory_BedNum { get; set; }
        public string Dormitory_StudentID { get; set; }
        public DateTime? Dormitory_CreateTime { get; set; }
        public DateTime? Dormitory_UpdateTime { get; set; }
        public string Dormitory_CreateBy { get; set; }
        public string Dormitory_UpdateBy { get; set; }

    }

}