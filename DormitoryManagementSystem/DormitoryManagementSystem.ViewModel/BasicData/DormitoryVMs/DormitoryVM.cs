using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WalkingTec.Mvvm.Core;
using WalkingTec.Mvvm.Core.Extensions;
using Microsoft.EntityFrameworkCore;

using DormitoryManagementSystem.ViewModel.BasicData.StudentVMs;
using DormitoryManagementSystem.Model.BasicData;
using DormitoryManagementSystem.Model;
namespace DormitoryManagementSystem.ViewModel.BasicData.DormitoryVMs
{
    public partial class DormitoryVM : BaseCRUDVM<Dormitory>
    {
        

        public DormitoryVM()
        {
            
            SetInclude(x => x.StudentID);

        }

        protected override void InitVM()
        {
            

        }

        public override DuplicatedInfo<Dormitory> SetDuplicatedCheck()
        {
            var rv = CreateFieldsInfo(SimpleField(x => x.DormitoryNum), SimpleField(x => x.RoomNum), SimpleField(x => x.BedNum));
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
