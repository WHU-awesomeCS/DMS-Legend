using System;
using System.ComponentModel.DataAnnotations;

namespace DormitoryManagementSystem.Model
{
    public enum DepartmentTypeEnumerateEnum
    {
        [Display(Name = "_Enum._DepartmentTypeEnumerate._Computer")]
        Computer,
        [Display(Name = "_Enum._DepartmentTypeEnumerate._News")]
        News,
        [Display(Name = "_Enum._DepartmentTypeEnumerate._Laws")]
        Laws,
        [Display(Name = "_Enum._DepartmentTypeEnumerate._Physicss")]
        Physicss,
        [Display(Name = "_Enum._DepartmentTypeEnumerate._Medicinee")]
        Medicinee,
        [Display(Name = "_Enum._DepartmentTypeEnumerate._Philosophyy")]
        Philosophyy,
        [Display(Name = "_Enum._DepartmentTypeEnumerate._Literaturee")]
        Literaturee
    }
    public enum SectorTypeEnumerateEnum
    {
        [Display(Name = "_Enum._SectorTypeEnumerate._PublicHomeM")]
        PublicHomeM,
        [Display(Name = "_Enum._SectorTypeEnumerate._ApartmentM")]
        ApartmentM,
        [Display(Name = "_Enum._SectorTypeEnumerate._ResidentM")]
        ResidentM,
        [Display(Name = "_Enum._SectorTypeEnumerate._PropertyM")]
        PropertyM,
        [Display(Name = "_Enum._SectorTypeEnumerate._RepairM")]
        RepairM,
        [Display(Name = "_Enum._SectorTypeEnumerate._WaterEleM")]
        WaterEleM,
        [Display(Name = "_Enum._SectorTypeEnumerate._EducationM")]
        EducationM
    }
    public enum RepairTypeEnum
    {
        [Display(Name = "_Enum._RepairTypeEnum._ElecError")]
        ElecError,
        [Display(Name = "_Enum._RepairTypeEnum._PlumError")]
        PlumError,
        [Display(Name = "_Enum._RepairTypeEnum._BathError")]
        BathError,
        [Display(Name = "_Enum._RepairTypeEnum._SafetyError")]
        SafetyError,
        [Display(Name = "_Enum._RepairTypeEnum._DoorError")]
        DoorError,
        [Display(Name = "_Enum._RepairTypeEnum._OtherError")]
        OtherError
    }
    public enum ProcessStatusEnum
    {
        [Display(Name = "_Enum._ProcessStatusEnum._Todoo")]
        Todoo,
        [Display(Name = "_Enum._ProcessStatusEnum._Doingg")]
        Doingg,
        [Display(Name = "_Enum._ProcessStatusEnum._Donee")]
        Donee
    }
    public enum ApplicationTypeEnum
    {
        [Display(Name = "_Enum._ApplicationTypeEnum._LeaveType")]
        LeaveType,
        [Display(Name = "_Enum._ApplicationTypeEnum._VisitorType")]
        VisitorType
    }

    public class RefDicNameAttribute : Attribute
    {
        public string Name { get; set; }
    }
}