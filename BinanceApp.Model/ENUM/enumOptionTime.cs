using System.ComponentModel.DataAnnotations;

namespace BinanceApp.Model.ENUM
{
    public enum enumOptionTime
    {
        [Display(Name = "3 ngày")]
        ThreeDays = 1,
        [Display(Name = "1 tháng")]
        AMonth = 2,
        [Display(Name = "3 tháng")]
        ThreeMonths = 3,
        [Display(Name = "6 tháng")]
        SixMonths = 4,
        [Display(Name = "1 năm")]
        AYear = 5
    }
}
