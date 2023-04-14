using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Social.Network.DTO
{
    public class UserDTO
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [StringLength(50)]
        [Display(Name = "Логин")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [StringLength(50)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [StringLength(50)]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [StringLength(50)]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        [Display(Name = "Дата рождения")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [Display(Name = "Пол")]
        public Gender Gender { get; set; }

        [StringLength(100)]
        public string StatusText { get; set; }

        public byte[] ProfileImage { get; set; }

        [Display(Name = "Номер телефона")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"((\+38)?\(?\d{3}\)?[\s\.-]?(\d{7}|\d{3}[\s\.-]\d{2}[\s\.-]\d{2}|\d{3}-\d{4}))$", ErrorMessage = "Не правильно введен номер")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Электронный адрес")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[^@ \t\r\n]+@[^@ \t\r\n]+\.[^@ \t\r\n]+", ErrorMessage = "Не правильно введен электронный адрес")]
        public string Email { get; set; }

        public bool EmailConfirmed { get; set; }

        public DateTime RegistrationDate { get; set; }

        public bool IsDeleted { get; set; }
    }
    public enum Gender
    {
        Female,
        Male
    }
}
