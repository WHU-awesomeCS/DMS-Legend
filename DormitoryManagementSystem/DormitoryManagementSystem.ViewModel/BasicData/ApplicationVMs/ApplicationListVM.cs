using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using DormitoryManagementSystem.Model.BasicData;
using DormitoryManagementSystem.Model;

namespace DormitoryManagementSystem.ViewModel.BasicData.ApplicationVMs
{
    public partial class ApplicationListVM : BasePagedListVM<Application_View, ApplicationSearcher>
    {
        
        protected override IEnumerable<IGridColumn<Application_View>> InitGridHeader()
        {
            return new List<GridColumn<Application_View>>{
                
                this.MakeGridHeader(x => x.Application_AppType).SetTitle(@Localizer["Page.申请类型"].Value),
                this.MakeGridHeader(x => x.Application_AppliName).SetTitle(@Localizer["Page.申请人姓名"].Value),
                this.MakeGridHeader(x => x.Application_IdentityID).SetTitle(@Localizer["Page.身份证号"].Value),
                this.MakeGridHeader(x => x.Application_StatTime).SetTitle(@Localizer["Page.开始时间"].Value),
                this.MakeGridHeader(x => x.Application_EndTime).SetTitle(@Localizer["Page.结束时间"].Value),
                this.MakeGridHeader(x => x.Application_StatusProcess).SetTitle(@Localizer["Page.申请状态"].Value),
                this.MakeGridHeader(x => x.Application_CreateTime).SetTitle(@Localizer["_Admin.CreateTime"].Value),
                this.MakeGridHeader(x => x.Application_UpdateTime).SetTitle(@Localizer["_Admin.UpdateTime"].Value),
                this.MakeGridHeader(x => x.Application_CreateBy).SetTitle(@Localizer["_Admin.CreateBy"].Value),
                this.MakeGridHeader(x => x.Application_UpdateBy).SetTitle(@Localizer["_Admin.UpdateBy"].Value),

                this.MakeGridHeaderAction(width: 200)
            };
        }

        
        public override IOrderedQueryable<Application_View> GetSearchQuery()
        {
            var query = DC.Set<Application>()
                
                .CheckEqual(Searcher.AppType, x=>x.AppType)
                .CheckContain(Searcher.AppliName, x=>x.AppliName)
                .CheckContain(Searcher.IdentityID, x=>x.IdentityID)
                .CheckBetween(Searcher.StatTime?.GetStartTime(), Searcher.StatTime?.GetEndTime(), x => x.StatTime, includeMax: false)
                .CheckBetween(Searcher.EndTime?.GetStartTime(), Searcher.EndTime?.GetEndTime(), x => x.EndTime, includeMax: false)
                .CheckEqual(Searcher.StatusProcess, x=>x.StatusProcess)
                .CheckBetween(Searcher.CreateTime?.GetStartTime(), Searcher.CreateTime?.GetEndTime(), x => x.CreateTime, includeMax: false)
                .CheckBetween(Searcher.UpdateTime?.GetStartTime(), Searcher.UpdateTime?.GetEndTime(), x => x.UpdateTime, includeMax: false)
                .CheckContain(Searcher.CreateBy, x=>x.CreateBy)
                .CheckContain(Searcher.UpdateBy, x=>x.UpdateBy)
                .Select(x => new Application_View
                {
				    ID = x.ID,
                    
                    Application_AppType = x.AppType,
                    Application_AppliName = x.AppliName,
                    Application_IdentityID = x.IdentityID,
                    Application_StatTime = x.StatTime,
                    Application_EndTime = x.EndTime,
                    Application_StatusProcess = x.StatusProcess,
                    Application_CreateTime = x.CreateTime,
                    Application_UpdateTime = x.UpdateTime,
                    Application_CreateBy = x.CreateBy,
                    Application_UpdateBy = x.UpdateBy,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }
    public class Application_View: Application
    {
        
        public ApplicationTypeEnum? Application_AppType { get; set; }
        public string Application_AppliName { get; set; }
        public string Application_IdentityID { get; set; }
        public DateTime? Application_StatTime { get; set; }
        public DateTime? Application_EndTime { get; set; }
        public ProcessStatusEnum? Application_StatusProcess { get; set; }
        public DateTime? Application_CreateTime { get; set; }
        public DateTime? Application_UpdateTime { get; set; }
        public string Application_CreateBy { get; set; }
        public string Application_UpdateBy { get; set; }

    }

}