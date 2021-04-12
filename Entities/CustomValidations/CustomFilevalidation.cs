using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Web;

namespace Entities.CustomValidations
{
    internal class CustomFilevalidation : ValidationAttribute
    {
        private int _maxFileSize;
        public string[] AllowedFormats { get; set; }
        public int MaxFileSize
        {
            get => _maxFileSize * 1024 * 1024; 
            set => _maxFileSize = value; 
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (!(value is HttpPostedFileBase file))
                return new ValidationResult("No file to upload.");

            string end = Path.GetExtension(file.FileName);

            if (!AllowedFormats.Contains(end))
            {
                string formats = AllowedFormats.Aggregate((a, b) => a + "--" + b);
                return new ValidationResult($"File should be any of [ {formats} ]");
            }

            bool result = file.ContentLength >= MaxFileSize;

            if (result)
                return new ValidationResult($"File size should not be greater than {_maxFileSize} Mb");

            return ValidationResult.Success;
        }
    }
}
