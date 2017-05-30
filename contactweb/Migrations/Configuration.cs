namespace contactweb.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<contactweb.Models.contactwebContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "contactweb.Models.contactwebContext";
        }

        protected override void Seed(contactweb.Models.contactwebContext context)
        {
            /*
             7918d545-a268-42d5-b748-6b6fc92a30f2
             */
            context.Contacts.AddOrUpdate(
                 p => p.Id,
                 new Models.Contact
                 {
                     Id = 1,
                     Birthday = new DateTime(1920, 01, 20),
                     City = "Chicago"
                                     ,
                     Email = "doc.mccoy@starfleet.com",
                     FirstName = "DeForest",
                     LastName = "Kelley"
                                     ,
                     PhonePrimary = "123-456-7890",
                     phoneSecondary = "234-567-8901",
                     State = "IL"
                                     ,
                     StreetAdress1 = "Sickbay",
                     StreetAdress2 = "Starship Enterprise NCC-1701"
                                     ,
                     UserId = new Guid("7918d545-a268-42d5-b748-6b6fc92a30f2")
                                     ,
                     Zip = "98765"
                 }
                 , new Models.Contact
                 {
                     Id = 2,
                     Birthday = new DateTime(1920, 03, 03),
                     City = "New York"
                                     ,
                     Email = "i.beam.you.up@starfleet.com",
                     FirstName = "James",
                     LastName = "Doohan"
                                     ,
                     PhonePrimary = "345-678-9012",
                     phoneSecondary = "456-789-0123",
                     State = "NY"
                                     ,
                     StreetAdress1 = "Engineering",
                     StreetAdress2 = "Starship Enterprise NCC-1701"
                                     ,
                     UserId = new Guid("7918d545-a268-42d5-b748-6b6fc92a30f2")
                                     ,
                     Zip = "87654"
                 }
                 , new Models.Contact
                 {
                     Id = 3,
                     Birthday = new DateTime(1931, 03, 26),
                     City = "Los Angeles"
                                     ,
                     Email = "its.only.logic@starfleet.com",
                     FirstName = "Leonard",
                     LastName = "Nimoy"
                                     ,
                     PhonePrimary = "987-654-3210",
                     phoneSecondary = "876-543-2109",
                     State = "CA"
                                     ,
                     StreetAdress1 = "Science Station 1",
                     StreetAdress2 = "Starship Enterprise NCC-1701"
                                     ,
                     UserId = new Guid("7918d545-a268-42d5-b748-6b6fc92a30f2")
                                     ,
                     Zip = "76543-2109"
                 }
                 , new Models.Contact
                 {
                     Id = 4,
                     Birthday = new DateTime(1931, 03, 22),
                     City = "Riverside"
                                     ,
                     Email = "the.captain@starfleet.com",
                     FirstName = "William",
                     LastName = "Shatner"
                                     ,
                     PhonePrimary = "765-432-1098",
                     phoneSecondary = "654-321-0987",
                     State = "IA"
                                     ,
                     StreetAdress1 = "The Bridge",
                     StreetAdress2 = "Starship Enterprise NCC-1701"
                                     ,
                     UserId = new Guid("7918d545-a268-42d5-b748-6b6fc92a30f2")
                                     ,
                     Zip = "65432-0123"
                 }
             );
        }
    }
}
