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
namespace DormitoryManagementSystem.ViewModel.BasicData.ApplicationVMs
{
    public partial class ApplicationVM : BaseCRUDVM<Application>
    {
        
        public ApplicationVM()
        {
            
        }

        protected override void InitVM()
        {
            
        }

        public override DuplicatedInfo<Application> SetDuplicatedCheck()
        {
            var rv = CreateFieldsInfo(SimpleField(x => x.AppliName), SimpleField(x => x.IdentityID));
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
