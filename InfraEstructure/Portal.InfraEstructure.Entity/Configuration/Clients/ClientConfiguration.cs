using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Portal.Model;
using Portal.Model.Clients;

namespace Portal.InfraEstructure.Entity.Configuration.Clients
{
    public class ClientConfiguration : BaseEntityConfiguration<Client>, IEntityTypeConfiguration<Client>
    {
        public override void Configure(EntityTypeBuilder<Client> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.ClientId).IsRequired().HasMaxLength(50);
            builder.Property(p => p.ClientName).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Description).HasMaxLength(255);
            builder.Property(p => p.AcessTokenLifetime).IsRequired();
            builder.Property(p => p.Enable).IsRequired();
            builder.Property(p => p.LogoClientUri).HasMaxLength(255);
            builder.Property(p => p.ProtocolType).IsRequired().HasMaxLength(10);
            builder.Property(p => p.TokenLifetime).IsRequired();

            builder.HasDiscriminator<string>("ClientType")
                   .HasValue<WebAppClient>("WebAppClient");

            builder.HasMany(t => t.AcceptScope).WithOne(t => t.Client).HasForeignKey(t => t.IdClient);
        }
    }
}
