using System;

namespace hangout.Api.Controllers.Organiser
{
    public class OrganiserDto
    {
        public OrganiserDto
        {
            public Guid Id { get; set; }
            public string Name { get; set; }
            public string Event { get; set; }
            public DateTime DatesAvailable { get; set; }

            public Organiser MapToEntity()
            {
                return new Models.Organiser
                {
                    Id = Id,
                    Name = Name,
                    Event = Event,
                    DatesAvailable = DatesAvailable
                };
            }
        }
}
}