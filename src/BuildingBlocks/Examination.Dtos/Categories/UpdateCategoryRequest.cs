﻿using System.ComponentModel.DataAnnotations;

namespace Examination.Dtos.Categories
{
    public class UpdateCategoryRequest
    {
        [Required]
        public string Id { set; get; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string UrlPath { get; set; }
    }
}