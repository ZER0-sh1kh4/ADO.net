using System;
using System.ComponentModel.DataAnnotations;

namespace IDCard.Models
{
    public class CollegeApplication
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Full name is required")]
        [RegularExpression(@"^[A-Za-z\s]{3,60}$",
            ErrorMessage = "Only letters and spaces allowed (3–60 characters)")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Roll number is required")]
        [RegularExpression(@"^\d{4}$",
            ErrorMessage = "Roll number must be exactly 4 digits")]
        [Display(Name = "Roll Number")]
        public string RollNumber { get; set; }

        [Required(ErrorMessage = "Department is required")]
        [StringLength(100, MinimumLength = 2)]
        [Display(Name = "Department")]
        public string Department { get; set; }

        [Required(ErrorMessage = "Course is required")]
        [StringLength(100, MinimumLength = 2)]
        [Display(Name = "Course")]
        public string Course { get; set; }

        [Required(ErrorMessage = "Year is required")]
        [RegularExpression(@"^(1st|2nd|3rd|4th)\sYear$",
            ErrorMessage = "Enter: 1st Year, 2nd Year, 3rd Year, or 4th Year")]
        [Display(Name = "Year")]
        public string Year { get; set; }

        [Required(ErrorMessage = "Date of birth is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        [RegularExpression(@"^(Male|Female|Other)$",
            ErrorMessage = "Select Male, Female, or Other")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Mobile number is required")]
        [RegularExpression(@"^[6-9]\d{9}$",
            ErrorMessage = "Enter a valid 10-digit Indian mobile number")]
        [Display(Name = "Mobile Number")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter a valid email address")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(300, MinimumLength = 10,
            ErrorMessage = "Address must be between 10 and 300 characters")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "PIN code is required")]
        [RegularExpression(@"^\d{6}$",
            ErrorMessage = "Enter a valid 6-digit PIN code")]
        [Display(Name = "PIN Code")]
        public string PinCode { get; set; }

        [Display(Name = "Photo")]
        public string PhotoUrl { get; set; }

        [Display(Name = "Applied On")]
        [DataType(DataType.DateTime)]
        public DateTime AppliedOn { get; set; }
    }
}