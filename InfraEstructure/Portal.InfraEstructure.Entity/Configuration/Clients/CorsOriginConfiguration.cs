using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Model.Clients;

namespace Portal.InfraEstructure.Entity.Configuration.Clients
{
    public class CorsOriginConfiguration : BaseEntityConfiguration<CorsOrigin>, IEntityTypeConfiguration<CorsOrigin>
    {
        public override void Configure(EntityTypeBuilder<CorsOrigin> builder)
        {
            base.Configure(builder);

            builder.Property(t => t.Uri).IsRequired().HasMaxLength(255);
            builder.Property(t => t.IdClient).IsRequired();

            builder.HasOne(t => t.WebAppClient).WithMany(t => t.AcceptCorsOrigin).HasForeignKey(t => t.IdClient);
        }
    }
}
