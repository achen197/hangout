using System;

namespace hangout.Api.Models
{
    public class Organiser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Event { get; set; }
        public DateTime DatesAvailable { get; set; }
    }
}