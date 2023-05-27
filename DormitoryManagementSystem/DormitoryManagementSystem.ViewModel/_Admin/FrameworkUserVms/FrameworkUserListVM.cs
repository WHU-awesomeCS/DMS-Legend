using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using DormitoryManagementSystem.Model;

namespace DormitoryManagementSystem.ViewModel._Admin.FrameworkUserVMs
{
    public partial class FrameworkUserListVM : BasePagedListVM<FrameworkUser_View, FrameworkUserSearcher>
    {
        
        protected override IEnumerable<IGridColumn<FrameworkUser_View>> InitGridHeader()
        {
            return new List<GridColumn<FrameworkUser_View>>{
                
                this.MakeGridHeader(x => x.FrameworkUser_ITCode).SetTitle(@Localizer["Sys.Account"].Value),
                this.MakeGridHeader(x => x.FrameworkUser_Name).SetTitle(@Localizer["_Admin.Name"].Value),
                this.MakeGridHeader(x => x.FrameworkUser_Gender).SetTitle(@Localizer["_Admin.Gender"].Value),
                this.MakeGridHeader(x => x.FrameworkUser_CellPhone).SetTitle(@Localizer["_Admin.CellPhone"].Value),
                this.MakeGridHeader(x => x.FrameworkUser_Role).SetTitle(@Localizer["_Admin.Role"].Value),
                this.MakeGridHeader(x => x.FrameworkUser_Group).SetTitle(@Localizer["_Admin.Group"].Value),
                this.MakeGridHeader(x => x.FrameworkUser_IsValid).SetTitle(@Localizer["_Admin.IsValid"].Value),
                this.MakeGridHeader(x => x.FrameworkUser_Photo).SetTitle(@Localizer["_Admin.Photo"].Value),

                this.MakeGridHeaderAction(width: 200)
            };
        }

        
        public override IOrderedQueryable<FrameworkUser_View> GetSearchQuery()
        {
            var query = DC.Set<FrameworkUser>()
                
                .CheckContain(Searcher.ITCode, x=>x.ITCode)
                .CheckContain(Searcher.Name, x=>x.Name)
                .CheckEqual(Searcher.IsValid, x=>x.IsValid)
                .Select(x => new FrameworkUser_View
                {
				    ID = x.ID,
                    
                    FrameworkUser_ITCode = x.ITCode,
                    FrameworkUser_Name = x.Name,
                    FrameworkUser_Gender = x.Gender,
                    FrameworkUser_CellPhone = x.CellPhone,
                    FrameworkUser_Role = DC.Set<FrameworkUserRole>().Where(y => y.UserCode == x.ITCode)
                        .Join(DC.Set<FrameworkRole>(), ur => ur.RoleCode, role => role.RoleCode, (ur, role) => role).Select(y0=>y0.RoleName).ToSepratedString(null,","),
                    FrameworkUser_Group = DC.Set<FrameworkUserGroup>().Where(y => y.UserCode == x.ITCode)
                        .Join(DC.Set<FrameworkGroup>(), ug => ug.GroupCode, group => group.GroupCode, (ug, group) => group ).Select(y0=>y0.GroupName).ToSepratedString(null,","),
                    FrameworkUser_IsValid = x.IsValid,
                    FrameworkUser_Photo = x.PhotoId,
                })
                .OrderBy(x => x.ID);
            return query;
        }

    }
    public class FrameworkUser_View: FrameworkUser
    {
        
        public string FrameworkUser_ITCode { get; set; }
        public string FrameworkUser_Name { get; set; }
        public GenderEnum? FrameworkUser_Gender { get; set; }
        public string FrameworkUser_CellPhone { get; set; }
        public string FrameworkUser_Role { get; set; }
        public string FrameworkUser_Group { get; set; }
        public bool? FrameworkUser_IsValid { get; set; }
        public Guid? FrameworkUser_Photo { get; set; }

    }

}