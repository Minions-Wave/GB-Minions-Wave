using System;
using System.Collections.Generic;

namespace Seminar002
{
    public partial class Person
    {
        public int Id { get; set; }
        public string? PersonFullName { get; set; }
        public DateOnly? PersonBirthday { get; set; }
        public bool? PersonStatus { get; set; }
        public int? PersonPhone { get; set; }
        public string? PersonComment { get; set; }
        public string? PersonAddress { get; set; }
        public string? PersonGroup { get; set; }
    }
}
