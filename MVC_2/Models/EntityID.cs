using System;
namespace MVC_2.Models
{
    public class EntityID
    {
        public Guid Id { get; set; }


        public EntityID()
        {
            Id = Guid.NewGuid();
        }
    }
}

