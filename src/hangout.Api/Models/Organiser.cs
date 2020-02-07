using System;
using System.ComponentModel.DataAnnotations;

namespace hangout.Domain
{
    public class Organiser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string EventName { get; set; }
        public DateTime DatesAvailable { get; set; }
    }
}