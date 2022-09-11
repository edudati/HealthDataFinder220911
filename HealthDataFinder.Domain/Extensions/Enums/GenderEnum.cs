using System.ComponentModel.DataAnnotations;

namespace HealthDataFinder.Domain.Extensions.Enums
{
    public enum Gender
    {
        [Display(Name = "Masculino")]
        M = 1,
        [Display(Name = "Feminino")]
        F = 2
    }
}
