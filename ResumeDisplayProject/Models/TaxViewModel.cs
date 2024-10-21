namespace ResumeDisplayProject.Models
{
    using System.ComponentModel.DataAnnotations;
    public class TaxViewModel
    {
        [Required(ErrorMessage = "Please enter your income.")]
        [Range(0, double.MaxValue, ErrorMessage = "Income must be a positive number.")]
        public decimal Income { get; set; }

        public decimal? Tax { get; set; }
    }

}
