using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Model.Clients;

namespace Portal.InfraEstructure.Entity.Configuration.Clients
{
    public class ClientScopeConfiguration : BaseEntityConfiguration<ClientScope>, IEntityTypeConfiguration<ClientScope>
    {
        public override void Configure(EntityTypeBuilder<ClientScope> builder)
        {
            base.Configure(builder);

            builder.Property(t => t.ScopeLabel).IsRequired().HasMaxLength(255);
            builder.Property(t => t.IdClient).IsRequired();

            builder.HasOne(t => t.Client).WithMany(t => t.AcceptScope).HasForeignKey(t => t.IdClient);
        }
    }
}
