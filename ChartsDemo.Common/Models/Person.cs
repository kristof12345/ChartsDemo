using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Converters;

namespace Common.Web
{
    public class Person
    {
        [Required]
        [MinLength(3)]
        public string Name { get; set; }

        public int Age { get; set; }

        public NotificationType? Type { get; set; }
    }

    public class User
    {
        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [MinLength(5)]
        [MaxLength(50)]
        public string Password { get; set; }

        [Required]
        public string District { get; set; }

        [Required]
        public UserType? Type { get; set; }
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserType
    {
        [Display(Name = "User")]
        [EnumMember(Value = "User")]
        User,
        [Display(Name = "Temporary worker")]
        [EnumMember(Value = "Temporary worker")]
        Worker,
        [Display(Name = "Permanent resident")]
        [EnumMember(Value = "Permanent resident")]
        Resident,
        [Display(Name = "Citizen")]
        [EnumMember(Value = "Citizen")]
        Citizen,
        [Display(Name = "Municipal employee")]
        [EnumMember(Value = "Municipal employee")]
        Municipal,
        [Display(Name = "Government employee")]
        [EnumMember(Value = "Government employee")]
        Government,
        [Display(Name = "Server")]
        [EnumMember(Value = "Server")]
        Server,
    }

    [JsonConverter(typeof(StringEnumConverter))]
    public enum NotificationType
    {
        [Display(Name = "Email")]
        [EnumMember(Value = "Email")]
        Email,
        [Display(Name = "Push")]
        [EnumMember(Value = "Push")]
        Push
    }
}
