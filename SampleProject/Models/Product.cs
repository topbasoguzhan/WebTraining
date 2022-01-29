using Microsoft.AspNetCore.Mvc;
using SampleProject.Models.ModelMetadataTypes;
using System;
using System.ComponentModel.DataAnnotations;

namespace SampleProject.Models
{
    [ModelMetadataType(typeof(ProductMetadata))] //Validation'ı burada yaptığımızı belirtmiş olduk.
    public class Product
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string Email { get; set; }

    }
}
