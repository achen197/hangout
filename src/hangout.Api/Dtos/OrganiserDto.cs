using System;
using System.ComponentModel.DataAnnotations;
using hangout.Domain;

namespace hangout.Api.Controllers
{
    public class OrganiserDto
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string EventName { get; set; }
        [Required]
        public DateTime DatesAvailable { get; set; }

        public Organiser MapToEntity()
        {
            return new Organiser
            {
                Id = Id,
                Name = Name,
                EventName = EventName,
                DatesAvailable = DatesAvailable
            };
        }
    }
}