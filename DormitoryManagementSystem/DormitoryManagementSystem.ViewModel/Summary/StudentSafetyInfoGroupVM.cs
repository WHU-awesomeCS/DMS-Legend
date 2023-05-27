using WalkingTec.Mvvm.Core;
using DormitoryManagementSystem.ViewModel.Summary;

namespace DormitoryManagementSystem.ViewModel.Summary
{
    public partial class StudentSafetyInfoGroupVM : BaseVM
    {
        public DormitoryManagementSystem.ViewModel.Summary.StudentSearcher1 StudentSearcher1 { get; set; } = new DormitoryManagementSystem.ViewModel.Summary.StudentSearcher1();
        public DormitoryManagementSystem.ViewModel.Summary.StudentSearcher2 StudentSearcher2 { get; set; } = new DormitoryManagementSystem.ViewModel.Summary.StudentSearcher2();
        protected override void InitVM()
        {
            StudentSearcher1 = new DormitoryManagementSystem.ViewModel.Summary.StudentSearcher1();
            StudentSearcher1.CopyContext(this);
            StudentSearcher1.DoInit();
            StudentSearcher2 = new DormitoryManagementSystem.ViewModel.Summary.StudentSearcher2();
            StudentSearcher2.CopyContext(this);
            StudentSearcher2.DoInit();
            base.InitVM();
        }
    }
}
 