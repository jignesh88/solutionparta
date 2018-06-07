using System;
namespace SolutionPartA.Models
{
    public class JsonReturnViewModel
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public object Model { get; set; }
    }
}
