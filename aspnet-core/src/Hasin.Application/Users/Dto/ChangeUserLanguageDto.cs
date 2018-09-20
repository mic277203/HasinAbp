using System.ComponentModel.DataAnnotations;

namespace Hasin.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}