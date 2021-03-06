﻿namespace GST.Web.InputModels.PagesInputModels
{
    using System.ComponentModel.DataAnnotations;

    public class EditPageInputModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string OldName { get; set; }
    }
}
