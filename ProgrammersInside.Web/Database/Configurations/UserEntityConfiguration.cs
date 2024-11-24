using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgrammersInside.Web.Core.UserContext.Models;

namespace ProgrammersInside.Web.Database.Configurations;

public class UserEntityConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(_ => _.Id);

        builder.Property(_ => _.Email)
            .IsRequired();

        builder.Property(_ => _.Password)
            .IsRequired();

        builder.Property(_ => _.Name)
            .IsRequired();

        builder.Property(_ => _.Gender)
            .IsRequired();

        builder.Property(_ => _.PlayAt)
            .IsRequired();

        builder.Property(_ => _.FavoriteGame)
            .IsRequired();

        builder.Property(_ => _.Dob)
            .HasColumnType("date")
            .IsRequired();
    }
}