// using System;
// using System.ComponentModel.DataAnnotations;
// using hangout.Domain;
//
// namespace hangout.Api.Controllers
// {
//     public class CreateOrganiserDto
//     {
//         public CreateOrganiserDto() {}
//
//         public CreateOrganiserDto(Organiser organiser)
//         {
//             Id = organiser.Id;
//             Name = organiser.Name;
//             EventName = organiser.EventName;
//             DatesAvailable = organiser.DatesAvailable;
//         }
//         
//         [Required]
//         public Guid Id { get; set; }
//         [Required]
//         public string Name { get; set; }
//         [Required]
//         public string EventName { get; set; }
//         [Required]
//         public DateTime DatesAvailable { get; set; }
//         
//     }
// }