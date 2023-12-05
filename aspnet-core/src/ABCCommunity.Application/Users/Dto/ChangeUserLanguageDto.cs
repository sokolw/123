using System.ComponentModel.DataAnnotations;

namespace ABCCommunity.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}