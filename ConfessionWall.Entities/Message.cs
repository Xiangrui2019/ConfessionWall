using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace ConfessionWall.Entities
{
    public class Message
    {
        public int Id { get; set; }

        [Required]
        [Display(Description = "你的名字")]
        public string YourName { get; set; }
        [Required]
        [EmailAddress]
        [Display(Description = "你的电子邮件")]
        public string YourEmail { get; set; }
        [Required]
        [Display(Description = "你的QQ")]
        public string YourQq { get; set; }
        [Required]
        [Display(Description = "她的名字")]
        public string TaName { get; set; }
        [Required]
        [Display(Description = "表白内容")]
        public string Content { get; set; }
        [Display(Description = "附加图片")]
        public string Image { get; set; }
        public DateTime PublishTime { get; set; } = DateTime.Now;
    }
}
