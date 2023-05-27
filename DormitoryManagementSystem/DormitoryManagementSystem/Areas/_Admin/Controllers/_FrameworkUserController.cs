using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Mvc;
using WalkingTec.Mvvm.Core.Extensions;
using System.Linq;
using System.Collections.Generic;
using DormitoryManagementSystem.ViewModel._Admin.FrameworkUserVMs;
using DormitoryManagementSystem.Model;

namespace DormitoryManagementSystem._Admin.Controllers
{
    [AuthorizeJwtWithCookie]
    [ActionDescription("_Model.FrameworkUser")]
    [ApiController]
    [Route("/api/_Admin/FrameworkUser")]
    public partial class FrameworkUserController : BaseApiController
    {
        [ActionDescription("Sys.Get")]
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            if (ConfigInfo.HasMainHost && Wtm.LoginUserInfo?.CurrentTenant == null)
            {
                ModelState.AddModelError(" mh", Localizer["_Admin.HasMainHost"]);
                return BadRequest(ModelState.GetErrorJson());
            }
            var vm = Wtm.CreateVM<FrameworkUserVM>(id);
            vm.Entity.Password = "";
            return Ok(vm);
        }

        [ActionDescription("Sys.Create")]
        [HttpPost("[action]")]
        public async Task<IActionResult> Create(FrameworkUserVM vm)
        {
            if (ConfigInfo.HasMainHost && Wtm.LoginUserInfo?.CurrentTenant == null)
            {
                ModelState.AddModelError(" mh", Localizer["_Admin.HasMainHost"]);
                return BadRequest(ModelState.GetErrorJson());
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorJson());
            }
            else
            {
                vm.Entity.Password = Utils.GetMD5String(vm.Entity.Password);
                await vm.DoAddAsync();
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState.GetErrorJson());
                }
                else
                {
                    return Ok(vm.Entity);
                }
            }

        }

        [ActionDescription("Sys.Edit")]
        [HttpPut("[action]")]
        public async Task<IActionResult> Edit(FrameworkUserVM vm)
        {
            if (ConfigInfo.HasMainHost && Wtm.LoginUserInfo?.CurrentTenant == null)
            {
                ModelState.AddModelError(" mh", Localizer["_Admin.HasMainHost"]);
                return BadRequest(ModelState.GetErrorJson());
            }
               ModelState.Remove("Entity.Password");
          if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorJson());
            }
            else
            {
                if (string.IsNullOrEmpty(vm.Entity.Password) == false)
                {
                    vm.Entity.Password = Utils.GetMD5String(vm.Entity.Password);
                }
                else
                {
                    vm.FC.Remove("Entity.Password");
                }
                await vm.DoEditAsync(false);
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState.GetErrorJson());
                }
                else
                {
                    return Ok(vm.Entity);
                }
            }
        }

        [HttpPost("BatchEdit")]
        [ActionDescription("Sys.BatchEdit")]
        public ActionResult BatchEdit(FrameworkUserBatchVM vm)
        {
             if (ConfigInfo.HasMainHost && Wtm.LoginUserInfo?.CurrentTenant == null)
            {
                ModelState.AddModelError(" mh", Localizer["_Admin.HasMainHost"]);
                return BadRequest(ModelState.GetErrorJson());
            }
           if (!ModelState.IsValid || !vm.DoBatchEdit())
            {
                return BadRequest(ModelState.GetErrorJson());
            }
            else
            {
                return Ok(vm.Ids.Count());
            }
        }

		[HttpPost("BatchDelete")]
        [ActionDescription("Sys.Delete")]
        public IActionResult BatchDelete(string[] ids)
        {
            if (ConfigInfo.HasMainHost && Wtm.LoginUserInfo?.CurrentTenant == null)
            {
                ModelState.AddModelError(" mh", Localizer["_Admin.HasMainHost"]);
                return BadRequest(ModelState.GetErrorJson());
            }
            var vm = Wtm.CreateVM<FrameworkUserBatchVM>();
            if (ids != null && ids.Count() > 0)
            {
                vm.Ids = ids;
            }
            else
            {
                return Ok();
            }
            if (!ModelState.IsValid || !vm.DoBatchDelete())
            {
                return BadRequest(ModelState.GetErrorJson());
            }
            else
            {
                return Ok(ids.Count());
            }
        }

        [ActionDescription("Sys.DownloadTemplate")]
        [HttpGet("GetExcelTemplate")]
        public IActionResult GetExcelTemplate()
        {
            if (ConfigInfo.HasMainHost && Wtm.LoginUserInfo?.CurrentTenant == null)
            {
                ModelState.AddModelError(" mh", Localizer["_Admin.HasMainHost"]);
                return BadRequest(ModelState.GetErrorJson());
            }
            var vm = Wtm.CreateVM<FrameworkUserImportVM>();
            var qs = new Dictionary<string, string>();
            foreach (var item in Request.Query.Keys)
            {
                qs.Add(item, Request.Query[item]);
            }
            vm.SetParms(qs);
            var data = vm.GenerateTemplate(out string fileName);
            return File(data, "application/vnd.ms-excel", fileName);
        }

        [ActionDescription("Sys.Import")]
        [HttpPost("Import")]
        public ActionResult Import(FrameworkUserImportVM vm)
        {

            if (ConfigInfo.HasMainHost && Wtm.LoginUserInfo?.CurrentTenant == null)
            {
                ModelState.AddModelError(" mh", Localizer["_Admin.HasMainHost"]);
                return BadRequest(ModelState.GetErrorJson());
            }
            if (vm.ErrorListVM.EntityList.Count > 0 || !vm.BatchSaveData())
            {
                return BadRequest(vm.GetErrorJson());
            }
            else
            {
                return Ok(vm.EntityList.Count);
            }
        }

        [HttpGet("GetFrameworkRoles")]
        [ActionDescription("GetRoles")]
        [AllRights]
        public IActionResult GetFrameworkRoles()
        {
            if (ConfigInfo.HasMainHost && Wtm.LoginUserInfo?.CurrentTenant == null)
            {
                return Request.RedirectCall(Wtm, "/api/_frameworkuser/GetFrameworkRoles").Result;
            }
            return Ok(DC.Set<FrameworkRole>().GetSelectListItems(Wtm, x => x.RoleName, x => x.RoleCode));
        }

        [HttpGet("GetFrameworkGroups")]
        [ActionDescription("GetGroups")]
        [AllRights]
        public IActionResult GetFrameworkGroups()
        {
            if (ConfigInfo.HasMainHost && Wtm.LoginUserInfo?.CurrentTenant == null)
            {
                return Request.RedirectCall(Wtm, "/api/_frameworkuser/GetFrameworkGroups").Result;
            }
            return Ok(DC.Set<FrameworkGroup>().GetSelectListItems(Wtm, x => x.GroupName, x => x.GroupCode));
        }

        [HttpGet("GetFrameworkGroupsTree")]
        [ActionDescription("GetGroupsTree")]
        [AllRights]
        public IActionResult GetFrameworkGroupsTree()
        {
            if (ConfigInfo.HasMainHost && Wtm.LoginUserInfo?.CurrentTenant == null)
            {
                return Request.RedirectCall(Wtm, "/api/_frameworkuser/GetFrameworkGroupsTree").Result;
            }
            return Ok(DC.Set<FrameworkGroup>().GetTreeSelectListItems(Wtm, x => x.GroupName, x => x.GroupCode));
        }


        [HttpGet("GetUserById")]
        [AllRights]
        public IActionResult GetUserById(string keywords)
        {
            if (ConfigInfo.HasMainHost && Wtm.LoginUserInfo?.CurrentTenant == null)
            {
                return Request.RedirectCall(Wtm, "/api/_frameworkuser/GetUserById").Result;
            }
            var users = DC.Set<FrameworkUser>().Where(x => x.ITCode.ToLower().StartsWith(keywords.ToLower())).GetSelectListItems(Wtm, x => x.Name + "(" + x.ITCode + ")", x => x.ITCode);
            return Ok(users);
        }

        [HttpGet("GetUserByGroup")]
        [AllRights]
        public IActionResult GetUserByGroup(string keywords)
        {
            if (ConfigInfo.HasMainHost && Wtm.LoginUserInfo?.CurrentTenant == null)
            {
                return Request.RedirectCall(Wtm, "/api/_frameworkuser/GetUserByGroup").Result;
            }
            var users = DC.Set<FrameworkUserGroup>().Where(x => x.GroupCode == keywords).Select(x=>x.UserCode).ToList();
            return Ok(users);
        }

        [HttpGet("GetUserByRole")]
        [AllRights]
        public IActionResult GetUserByRole(string keywords)
        {
            if (ConfigInfo.HasMainHost && Wtm.LoginUserInfo?.CurrentTenant == null)
            {
                return Request.RedirectCall(Wtm, "/api/_frameworkuser/GetUserByRole").Result;
            }
            var users = DC.Set<FrameworkUserRole>().Where(x => x.RoleCode == keywords).Select(x => x.UserCode).ToList();
            return Ok(users);
        }


        
    }
}