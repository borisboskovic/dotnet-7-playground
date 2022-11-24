using System.ComponentModel.DataAnnotations;

namespace dotnet_7_playground.Data.Models
{
    public class Example
    {
        [Key]
        public int Id { get; set; }
        public string Value { get; set; }
    }
}
