
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;
using DormitoryManagementSystem.Model;

namespace DormitoryManagementSystem.ViewModel._Admin.FrameworkUserVMs
{
    public partial class FrameworkUserBatchVM : BaseBatchVM<FrameworkUser, FrameworkUser_BatchEdit>
    {
        public FrameworkUserBatchVM()
        {
            ListVM = new FrameworkUserListVM();
            LinkedVM = new FrameworkUser_BatchEdit();
        }

        public override bool DoBatchEdit()
        {
            var entityList = DC.Set<FrameworkUser>().AsNoTracking().CheckIDs(Ids.ToList()).ToList();
                List<Guid> todelete = new List<Guid>();
                foreach (var entity in entityList)
            {

                if (LinkedVM.SelectedFrameworkUserRolesIDs != null)
                {
                    
                    var newids = LinkedVM.SelectedFrameworkUserRolesIDs;
                    todelete = new List<Guid>();
                    todelete.AddRange(DC.Set<FrameworkUserRole>().AsNoTracking().Where(x => x.UserCode == entity.ITCode).Select(x => x.ID));
                    foreach (var item in todelete)
                    {
                        DC.DeleteEntity(new FrameworkUserRole { ID = item });
                    }
                    foreach (var id in newids)
                    {
                        FrameworkUserRole r = new FrameworkUserRole
                        {
                            RoleCode = id,
                            UserCode = entity.ITCode
                        };
                         r.SetPropertyValue("TenantCode", LoginUserInfo.CurrentTenant);
                        DC.AddEntity(r);
                    }
                }

                if (LinkedVM.SelectedFrameworkUserGroupsIDs != null)
                {
                    
                    var newids = LinkedVM.SelectedFrameworkUserGroupsIDs;
                    todelete = new List<Guid>();
                    todelete.AddRange(DC.Set<FrameworkUserGroup>().AsNoTracking().Where(x => x.UserCode == entity.ITCode).Select(x => x.ID));
                    foreach (var item in todelete)
                    {
                        DC.DeleteEntity(new FrameworkUserGroup { ID = item });
                    }
                    foreach (var id in newids)
                    {
                        FrameworkUserGroup r = new FrameworkUserGroup
                        {
                            GroupCode = id,
                            UserCode = entity.ITCode
                        };
                         r.SetPropertyValue("TenantCode", LoginUserInfo.CurrentTenant);
                        DC.AddEntity(r);
                    }
                }
            }

            return base.DoBatchEdit();
        }
    }

	/// <summary>
    /// Class to define batch edit fields
    /// </summary>
    public class FrameworkUser_BatchEdit : BaseVM
    {

        
        [Display(Name = "_Model._FrameworkUser._Email")]
        public string Email { get; set; }
        [Display(Name = "_Model._FrameworkUser._Gender")]
        public GenderEnum? Gender { get; set; }
        [Display(Name = "_Model._FrameworkUser._CellPhone")]
        public string CellPhone { get; set; }
        [Display(Name = "_Model._FrameworkUser._HomePhone")]
        public string HomePhone { get; set; }
        [Display(Name = "_Model._FrameworkUser._Address")]
        public string Address { get; set; }
        [Display(Name = "_Model._FrameworkUser._ZipCode")]
        public string ZipCode { get; set; }
        [Display(Name = "_Model._FrameworkUser._Role")]
        public string RoleId { get; set; }
        [Display(Name = "_Model.FrameworkRole")]
        public List<string> SelectedFrameworkUserRolesIDs { get; set; }
        [Display(Name = "_Model._FrameworkUser._Group")]
        public string GroupId { get; set; }
        [Display(Name = "_Model.FrameworkGroup")]
        public List<string> SelectedFrameworkUserGroupsIDs { get; set; }

        protected override void InitVM()
        {
           
        }
    }

}