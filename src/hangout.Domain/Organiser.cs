// using System;
// using System.ComponentModel.DataAnnotations;
//
// namespace hangout.Domain
// {
//     public class Organiser : IEntity
//     {
//         Organiser() {}
//
//         public Organiser(Guid id, string name, string eventName, DateTime datesAvailable)
//         {
//             if (string.IsNullOrWhiteSpace(name))
//                 throw new ValidationException("Name is required");
//             if (string.IsNullOrWhiteSpace(eventName))
//                 throw new ValidationException("Name is required");
//             if(datesAvailable == null)
//                 throw new ValidationException("Dates available is required");
//
//             Id = id;
//             Name = name;
//             EventName = eventName;
//             DatesAvailable = datesAvailable;
//         }
//         
//         public Guid Id { get; private set; }
//         public string Name { get; private set; }
//         public string EventName { get; private set; }
//         public DateTime DatesAvailable { get; private set; }
//     }
// }