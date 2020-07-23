using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations;

namespace PhotoSharingApplication.Models
{
    public class Photo
    {
        public int PhotoID { get; set; }

        [Required]
        public string Title { get; set; }
        [DisplayName("Picture")]
        public string ImageMimeType { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Created Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yy}")]
        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(250)]
        public string UserName { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public byte[] PhotoFile { get; internal set; }
    }

}