using System;

namespace Portal.Model
{
    public abstract class BaseEntityModel
    {
        public BaseEntityModel() 
        {
            this.CreatedAt = DateTime.Now;
            this.Id = new Guid();
        }

        public BaseEntityModel(Guid id)
        {
            this.ModifiedAt = DateTime.Now;
            this.Id = id;
        }

        public Guid Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime ModifiedAt { get; private set; }

        public static bool operator == (BaseEntityModel left, BaseEntityModel rigth) =>
            left.Id.CompareTo(rigth.Id) == 0;

        public static bool operator !=(BaseEntityModel left, BaseEntityModel rigth) =>
            left?.Id.CompareTo(rigth.Id) < 0;
    }
}
