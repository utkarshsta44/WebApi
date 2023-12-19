using System.ComponentModel.DataAnnotations;

namespace collegeApi.Model
{

    public class Pizza
    {
        [Required]
        public int Id { get; set; }

        [StringLength(20,ErrorMessage ="Name Should have less than 20 Charaters")]
        public string? Name { get; set; }

        [Required]
        public bool IsGlutenFree { get; set; }

        [Required]
        public string Order { get; set; }

        [Compare(nameof(Order))]
        public string ConfirmOrder {  get; set; }
    }
}
