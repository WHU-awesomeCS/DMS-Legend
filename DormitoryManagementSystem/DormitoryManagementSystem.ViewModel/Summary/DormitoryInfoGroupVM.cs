using WalkingTec.Mvvm.Core;
using DormitoryManagementSystem.ViewModel.Summary;

namespace DormitoryManagementSystem.ViewModel.Summary
{
    public partial class DormitoryInfoGroupVM : BaseVM
    {
        public DormitoryManagementSystem.ViewModel.Summary.DormitorySearcher1 DormitorySearcher1 { get; set; } = new DormitoryManagementSystem.ViewModel.Summary.DormitorySearcher1();
        public DormitoryManagementSystem.ViewModel.Summary.DormitorySearcher2 DormitorySearcher2 { get; set; } = new DormitoryManagementSystem.ViewModel.Summary.DormitorySearcher2();
        protected override void InitVM()
        {
            DormitorySearcher1 = new DormitoryManagementSystem.ViewModel.Summary.DormitorySearcher1();
            DormitorySearcher1.CopyContext(this);
            DormitorySearcher1.DoInit();
            DormitorySearcher2 = new DormitoryManagementSystem.ViewModel.Summary.DormitorySearcher2();
            DormitorySearcher2.CopyContext(this);
            DormitorySearcher2.DoInit();
            base.InitVM();
        }
    }
}
 