using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.Mvc;
using DormitoryManagementSystem.Model;
using DormitoryManagementSystem.ViewModel.BasicData.ApplicationVMs;


namespace DormitoryManagementSystem.BasicData.Controllers
{
    [AuthorizeJwtWithCookie]
    public partial class ApplicationController : BaseApiController
    {
                                                
        [ActionDescription("Sys.Search")]
        [HttpPost("[action]")]
        public IActionResult SearchApplication(ApplicationSearcher searcher)
        {
            if (ModelState.IsValid)
            {
                var vm = Wtm.CreateVM<ApplicationListVM>();
                vm.Searcher = searcher;
                return Content(vm.GetJson(enumToString: false));
            }
            else
            {
                return BadRequest(ModelState.GetErrorJson());
            }
        }

        [ActionDescription("Sys.Export")]
        [HttpPost("[action]")]
        public IActionResult ApplicationExportExcel(ApplicationSearcher searcher)
        {
            var vm = Wtm.CreateVM<ApplicationListVM>();
            vm.Searcher = searcher;
            vm.SearcherMode = ListVMSearchModeEnum.Export;
            return vm.GetExportData();
        }

        [ActionDescription("Sys.CheckExport")]
        [HttpPost("[action]")]
        public IActionResult ApplicationExportExcelByIds(string[] ids)
        {
            var vm = Wtm.CreateVM<ApplicationListVM>();
            if (ids != null && ids.Count() > 0)
            {
                vm.Ids = new List<string>(ids);
                vm.SearcherMode = ListVMSearchModeEnum.CheckExport;
            }
            return vm.GetExportData();
        }
    
    }
}


