using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using WalkingTec.Mvvm.Mvc;
using DormitoryManagementSystem.Model;
using DormitoryManagementSystem.ViewModel.Summary;

using DormitoryManagementSystem.Model.BasicData;


namespace DormitoryManagementSystem.Summary.Controllers
{
    [ApiController]
    [ActionDescription("_Group._Default")]
    [Route("/api/Summary/_Default")]
    [AuthorizeJwtWithCookie]
    public partial class _DefaultController : BaseApiController
    {
                    
        [HttpPost("GetChartDatag3727868645")]    
        public IActionResult GetChartDatag3727868645(DormitoryInfoGroupVM vm)
        {
             if(vm == null)
            {
                vm = Wtm.CreateVM<DormitoryInfoGroupVM>();
            }
           var data = Wtm.DC.Set<Dormitory>()
                    .Select(y=> new {DormitoryID= y.ID,DormitoryDormitoryNum= y.DormitoryNum}).AsNoTracking()
                    .Select(x=> new { x.DormitoryDormitoryNum,_Category=(int)(x.DormitoryDormitoryNum / 1) + 1 })
                    .GroupBy(x => new {x._Category}, x => x).OrderBy(x =>x.Key._Category)
                    .Select(x => new ChartData{Category = ((x.Key._Category - 1) * 1).ToString()+"-"+(x.Key._Category * 1).ToString(),Value = x.Count(),})
                    .ToList();
            return Ok(data);
        }


        [HttpPost("GetChartDatag2718094403")]    
        public IActionResult GetChartDatag2718094403(DormitoryInfoGroupVM vm)
        {
             if(vm == null)
            {
                vm = Wtm.CreateVM<DormitoryInfoGroupVM>();
            }
           var data = Wtm.DC.Set<Dormitory>()
                    .Select(y=> new {DormitoryID= y.ID,DormitoryDormitoryNum= y.DormitoryNum}).AsNoTracking()
                    .Select(x=> new { x.DormitoryDormitoryNum,_Category=(int)(x.DormitoryDormitoryNum / 1) + 1 })
                    .GroupBy(x => new {x._Category}, x => x).OrderBy(x =>x.Key._Category)
                    .Select(x => new ChartData{Category = ((x.Key._Category - 1) * 1).ToString()+"-"+(x.Key._Category * 1).ToString(),Value = x.Count(),})
                    .ToList();
            return Ok(data);
        }


        [HttpPost("GetChartDatag5714736936")]    
        public IActionResult GetChartDatag5714736936(StudentSafetyInfoGroupVM vm)
        {
             if(vm == null)
            {
                vm = Wtm.CreateVM<StudentSafetyInfoGroupVM>();
            }
           var data = Wtm.DC.Set<Student>().Where(x => 
                    x.WhetherLeave.Equals(vm.StudentSearcher1.WhetherLeave_7556) == true)
                    .Select(y=> new {StudentID= y.ID,StudentDormitoryNum= y.DormitoryNum,StudentStudentID= y.StudentID}).AsNoTracking()
                    .Select(x=> new { x.StudentDormitoryNum,x.StudentStudentID,_Category=(int)(x.StudentDormitoryNum / 1) + 1 })
                    .GroupBy(x => new {x._Category}, x => x).OrderBy(x =>x.Key._Category)
                    .Select(x => new ChartData{Category = ((x.Key._Category - 1) * 1).ToString()+"-"+(x.Key._Category * 1).ToString(),Value = x.Count(),})
                    .ToList();
            return Ok(data);
        }


        [HttpPost("GetChartDatag8301901285")]    
        public IActionResult GetChartDatag8301901285(StudentSafetyInfoGroupVM vm)
        {
             if(vm == null)
            {
                vm = Wtm.CreateVM<StudentSafetyInfoGroupVM>();
            }
           var data = Wtm.DC.Set<Student>()
                    .Select(y=> new {StudentID= y.ID,StudentLeaveTime= y.LeaveTime,StudentStudentID= y.StudentID}).AsNoTracking()
                    .Select(x=> new { x.StudentLeaveTime,x.StudentStudentID,_Category=x.StudentLeaveTime.Value.Year * 1000 + x.StudentLeaveTime.Value.DayOfYear })
                    .GroupBy(x => new {x._Category}, x => x).OrderBy(x =>x.Key._Category)
                    .Select(x => new ChartData{Category = x.Min(y => y.StudentLeaveTime).Value.ToString("yyyy.MM.dd"),Value = x.Count(),})
                    .ToList();
            return Ok(data);
        }


    }
}



