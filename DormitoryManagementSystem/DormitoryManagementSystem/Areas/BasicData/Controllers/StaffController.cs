using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.Mvc;
using DormitoryManagementSystem.Model;
using DormitoryManagementSystem.ViewModel.BasicData.StaffVMs;


namespace DormitoryManagementSystem.BasicData.Controllers
{
    [AuthorizeJwtWithCookie]
    public partial class StaffController : BaseApiController
    {
                                                
        [ActionDescription("Sys.Search")]
        [HttpPost("[action]")]
        public IActionResult SearchStaff(DormitoryManagementSystem.ViewModel.BasicData.StaffVMs.StaffSearcher searcher)
        {
            if (ModelState.IsValid)
            {
                var vm = Wtm.CreateVM<DormitoryManagementSystem.ViewModel.BasicData.StaffVMs.StaffListVM>();
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
        public IActionResult StaffExportExcel(DormitoryManagementSystem.ViewModel.BasicData.StaffVMs.StaffSearcher searcher)
        {
            var vm = Wtm.CreateVM<DormitoryManagementSystem.ViewModel.BasicData.StaffVMs.StaffListVM>();
            vm.Searcher = searcher;
            vm.SearcherMode = ListVMSearchModeEnum.Export;
            return vm.GetExportData();
        }

        [ActionDescription("Sys.CheckExport")]
        [HttpPost("[action]")]
        public IActionResult StaffExportExcelByIds(string[] ids)
        {
            var vm = Wtm.CreateVM<DormitoryManagementSystem.ViewModel.BasicData.StaffVMs.StaffListVM>();
            if (ids != null && ids.Count() > 0)
            {
                vm.Ids = new List<string>(ids);
                vm.SearcherMode = ListVMSearchModeEnum.CheckExport;
            }
            return vm.GetExportData();
        }
    
    }
}


