using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;

using DormitoryManagementSystem.Model;
namespace DormitoryManagementSystem.ViewModel._Admin.FrameworkUserVMs
{
    public partial class FrameworkUserVM : BaseCRUDVM<FrameworkUser>
    {
        
        [Display(Name = "_Model.FrameworkRole")]
        public List<string> SelectedFrameworkUserRolesIDs { get; set; }
        [Display(Name = "_Model.FrameworkGroup")]
        public List<string> SelectedFrameworkUserGroupsIDs { get; set; }

        public FrameworkUserVM()
        {
            

        }

        protected override void InitVM()
        {
            
            SelectedFrameworkUserRolesIDs = DC.Set<FrameworkUserRole>().Where(x => x.UserCode == Entity.ITCode).Select(x => x.RoleCode).ToList();
            SelectedFrameworkUserGroupsIDs =  DC.Set<FrameworkUserGroup>().Where(x => x.UserCode == Entity.ITCode).Select(x => x.GroupCode).ToList();

        }

        public override DuplicatedInfo<FrameworkUser> SetDuplicatedCheck()
        {
            var rv = CreateFieldsInfo(SimpleField(x => x.ITCode));
            return rv;

        }

        public override async Task DoAddAsync()        
        {
            
            if (SelectedFrameworkUserRolesIDs != null)
            {
                List<Guid> todelete = new List<Guid>();
                todelete.AddRange(DC.Set<FrameworkUserRole>().AsNoTracking().Where(x => x.UserCode == Entity.ITCode).Select(x => x.ID));
                foreach (var item in todelete)
                {
                    DC.DeleteEntity(new FrameworkUserRole { ID = item });
                }
                foreach (var id in SelectedFrameworkUserRolesIDs)
                {
                    FrameworkUserRole r = new FrameworkUserRole
                    {
                        RoleCode = id,
                        UserCode = Entity.ITCode,
                        TenantCode = LoginUserInfo.CurrentTenant
                    };
                    DC.AddEntity(r);
                }
            }

            if (SelectedFrameworkUserGroupsIDs != null)
            {
                 List<Guid> todelete = new List<Guid>();
                todelete.AddRange(DC.Set<FrameworkUserGroup>().AsNoTracking().Where(x => x.UserCode == Entity.ITCode).Select(x => x.ID));
                foreach (var item in todelete)
                {
                    DC.DeleteEntity(new FrameworkUserGroup { ID = item });
                }
                foreach (var id in SelectedFrameworkUserGroupsIDs)
                {
                    FrameworkUserGroup g = new FrameworkUserGroup
                    {
                        GroupCode = id,
                        UserCode = Entity.ITCode,
                        TenantCode = LoginUserInfo.CurrentTenant
                    };
                    DC.AddEntity(g);
                }
            }

            await base.DoAddAsync();

        }

        public override async Task DoEditAsync(bool updateAllFields = false)
        {
            
            if (SelectedFrameworkUserRolesIDs != null)
            {
                List<Guid> todelete = new List<Guid>();
                todelete.AddRange(DC.Set<FrameworkUserRole>().AsNoTracking().Where(x => x.UserCode == Entity.ITCode).Select(x => x.ID));
                foreach (var item in todelete)
                {
                    DC.DeleteEntity(new FrameworkUserRole { ID = item });
                }
                foreach (var id in SelectedFrameworkUserRolesIDs)
                {
                    FrameworkUserRole r = new FrameworkUserRole
                    {
                        RoleCode = id,
                        UserCode = Entity.ITCode,
                        TenantCode = LoginUserInfo.CurrentTenant
                    };
                    DC.AddEntity(r);
                }
            }

            if (SelectedFrameworkUserGroupsIDs != null)
            {
                 List<Guid> todelete = new List<Guid>();
                todelete.AddRange(DC.Set<FrameworkUserGroup>().AsNoTracking().Where(x => x.UserCode == Entity.ITCode).Select(x => x.ID));
                foreach (var item in todelete)
                {
                    DC.DeleteEntity(new FrameworkUserGroup { ID = item });
                }
                foreach (var id in SelectedFrameworkUserGroupsIDs)
                {
                    FrameworkUserGroup g = new FrameworkUserGroup
                    {
                        GroupCode = id,
                        UserCode = Entity.ITCode,
                        TenantCode = LoginUserInfo.CurrentTenant
                    };
                    DC.AddEntity(g);
                }
            }

            await base.DoEditAsync();
            await Wtm.RemoveUserCache(Entity.ITCode);

        }

        public override async Task DoDeleteAsync()
        {
            await base.DoDeleteAsync();

        }
    }
}
