using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Model.Clients;

namespace Portal.InfraEstructure.Entity.Configuration.Clients
{
    public class WebAppClientConfiguration : IEntityTypeConfiguration<WebAppClient>
    {
        public void Configure(EntityTypeBuilder<WebAppClient> builder)
        {
            builder.Property(t => t.ClientUri).IsRequired().HasMaxLength(255);

            builder.HasMany(t => t.AcceptRedirect).WithOne(t => t.WebAppClient).HasForeignKey(t => t.IdClient);
            builder.HasMany(t => t.AcceptRedirectLogout).WithOne(t => t.WebAppClient).HasForeignKey(t => t.IdClient);
            builder.HasMany(t => t.AcceptCorsOrigin).WithOne(t => t.WebAppClient).HasForeignKey(t => t.IdClient);
        }
    }
}
