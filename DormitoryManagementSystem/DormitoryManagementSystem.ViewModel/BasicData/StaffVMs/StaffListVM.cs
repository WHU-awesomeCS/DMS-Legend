using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using DormitoryManagementSystem.Model.BasicData;
using DormitoryManagementSystem.Model;

namespace DormitoryManagementSystem.ViewModel.BasicData.StaffVMs
{
    public partial class StaffListVM : BasePagedListVM<Staff_View, StaffSearcher>
    {
        
        protected override IEnumerable<IGridColumn<Staff_View>> InitGridHeader()
        {
            return new List<GridColumn<Staff_View>>{
                
                this.MakeGridHeader(x => x.Staff_WorkID).SetTitle(@Localizer["Page.工号"].Value),
                this.MakeGridHeader(x => x.Staff_Name).SetTitle(@Localizer["_Admin.Name"].Value),
                this.MakeGridHeader(x => x.Staff_Sector).SetTitle(@Localizer["Page.部门"].Value),
                this.MakeGridHeader(x => x.Staff_Telephone).SetTitle(@Localizer["Page.电话"].Value),
                this.MakeGridHeader(x => x.Staff_Email).SetTitle(@Localizer["_Admin.Email"].Value),
                this.MakeGridHeader(x => x.Staff_DormitoryNum).SetTitle(@Localizer["Page.管理宿舍号"].Value),
                this.MakeGridHeader(x => x.Staff_CreateTime).SetTitle(@Localizer["_Admin.CreateTime"].Value),
                this.MakeGridHeader(x => x.Staff_UpdateTime).SetTitle(@Localizer["_Admin.UpdateTime"].Value),
                this.MakeGridHeader(x => x.Staff_CreateBy).SetTitle(@Localizer["_Admin.CreateBy"].Value),
                this.MakeGridHeader(x => x.Staff_UpdateBy).SetTitle(@Localizer["_Admin.UpdateBy"].Value),

                this.MakeGridHeaderAction(width: 200)
            };
        }

        
        public override IOrderedQueryable<Staff_View> GetSearchQuery()
        {
            var query = DC.Set<Staff>()
                
                .CheckEqual(Searcher.WorkID, x=>x.WorkID)
                .CheckContain(Searcher.Name, x=>x.Name)
                .CheckEqual(Searcher.Sector, x=>x.Sector)
                .CheckEqual(Searcher.Telephone, x=>x.Telephone)
                .CheckContain(Searcher.Email, x=>x.Email)
                .CheckEqual(Searcher.DormitoryNum, x=>x.DormitoryNum)
                .CheckBetween(Searcher.CreateTime?.GetStartTime(), Searcher.CreateTime?.GetEndTime(), x => x.CreateTime, includeMax: false)
                .CheckBetween(Searcher.UpdateTime?.GetStartTime(), Searcher.UpdateTime?.GetEndTime(), x => x.UpdateTime, includeMax: false)
                .CheckContain(Searcher.CreateBy, x=>x.CreateBy)
                .CheckContain(Searcher.UpdateBy, x=>x.UpdateBy)
                .Select(x => new Staff_View
                {
				    ID = x.ID,
                    
                    Staff_WorkID = x.WorkID,
                    Staff_Name = x.Name,
                    Staff_Sector = x.Sector,
                    Staff_Telephone = x.Telephone,
                    Staff_Email = x.Email,
                    Staff_DormitoryNum = x.DormitoryNum,
                    Staff_CreateTime = x.CreateTime,
                    Staff_UpdateTime = x.UpdateTime,
                    Staff_CreateBy = x.CreateBy,
                    Staff_UpdateBy = x.UpdateBy,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }
    public class Staff_View: Staff
    {
        
        public int? Staff_WorkID { get; set; }
        public string Staff_Name { get; set; }
        public SectorTypeEnumerateEnum? Staff_Sector { get; set; }
        public string Staff_Telephone { get; set; }
        public string Staff_Email { get; set; }
        public int? Staff_DormitoryNum { get; set; }
        public DateTime? Staff_CreateTime { get; set; }
        public DateTime? Staff_UpdateTime { get; set; }
        public string Staff_CreateBy { get; set; }
        public string Staff_UpdateBy { get; set; }

    }

}