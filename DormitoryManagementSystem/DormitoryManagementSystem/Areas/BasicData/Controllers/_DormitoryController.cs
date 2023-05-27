using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Mvc;
using WalkingTec.Mvvm.Core.Extensions;
using System.Linq;
using System.Collections.Generic;
using DormitoryManagementSystem.Model.BasicData;
using DormitoryManagementSystem.ViewModel.BasicData.DormitoryVMs;
using DormitoryManagementSystem.Model;

namespace DormitoryManagementSystem.BasicData.Controllers
{
    [AuthorizeJwtWithCookie]
    [ActionDescription("_Model.Dormitory")]
    [ApiController]
    [Route("/api/BasicData/Dormitory")]
    public partial class DormitoryController : BaseApiController
    {
        [ActionDescription("Sys.Get")]
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var vm = Wtm.CreateVM<DormitoryVM>(id);
            return Ok(vm);
        }

        [ActionDescription("Sys.Create")]
        [HttpPost("[action]")]
        public async Task<IActionResult> Create(DormitoryVM vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorJson());
            }
            else
            {
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
        public async Task<IActionResult> Edit(DormitoryVM vm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorJson());
            }
            else
            {
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
        public ActionResult BatchEdit(DormitoryBatchVM vm)
        {
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
            var vm = Wtm.CreateVM<DormitoryBatchVM>();
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
            var vm = Wtm.CreateVM<DormitoryImportVM>();
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
        public ActionResult Import(DormitoryImportVM vm)
        {

            if (vm.ErrorListVM.EntityList.Count > 0 || !vm.BatchSaveData())
            {
                return BadRequest(vm.GetErrorJson());
            }
            else
            {
                return Ok(vm.EntityList.Count);
            }
        }



        
        [HttpGet("GetStudents")]
        public ActionResult GetStudents()
        {
            return Ok(DC.Set<Student>().GetSelectListItems(Wtm, x => x.StudentName));
        }
        [HttpPost("[action]")]
        public ActionResult Select_GetStudentByStudentId(List<string> id)
        {
            var rv = DC.Set<Student>().CheckIDs(id).GetSelectListItems(Wtm, x => x.StudentName);
            return Ok(rv);
        }

        [HttpPost("[action]")]
        public ActionResult Select_GetDormitoryByStudent(List<string> id)
        {
            var rv = DC.Set<Dormitory>().CheckIDs(id, x => x.StudentIDId).GetSelectListItems(Wtm,x=>x.ID.ToString());
            return Ok(rv);
        }


    }
}