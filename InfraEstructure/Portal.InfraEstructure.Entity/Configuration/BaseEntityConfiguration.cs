using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Model;

namespace Portal.InfraEstructure.Entity.Configuration
{
    public abstract class BaseEntityConfiguration<TEntity> where TEntity : BaseEntityModel
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.Id).ValueGeneratedOnAdd();

            builder.Property(t => t.CreatedAt)
                   .IsRequired();
            builder.Property(t => t.ModifiedAt)
                   .IsRequired();
        }
    }
}
