using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;

using DormitoryManagementSystem.Model.BasicData;
using DormitoryManagementSystem.Model;
namespace DormitoryManagementSystem.ViewModel.BasicData.StaffVMs
{
    public partial class StaffVM : BaseCRUDVM<Staff>
    {
        
        public StaffVM()
        {
            
        }

        protected override void InitVM()
        {
            
        }

        public override DuplicatedInfo<Staff> SetDuplicatedCheck()
        {
            var rv = CreateFieldsInfo(SimpleField(x => x.WorkID));
            return rv;

        }

        public override async Task DoAddAsync()        
        {
            
            await base.DoAddAsync();

        }

        public override async Task DoEditAsync(bool updateAllFields = false)
        {
            
            await base.DoEditAsync();

        }

        public override async Task DoDeleteAsync()
        {
            await base.DoDeleteAsync();

        }
    }
}
