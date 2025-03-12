using CleanArchitecture_2025.Domain.Employees;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture_2025.Infrastructure.Configuration;

internal sealed class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.OwnsOne(p => p.PersonolInformation, builder =>
        {
            builder.Property(i => i.TCNo).HasColumnName("TCNO");
            builder.Property(i => i.Phone1).HasColumnName("Phone1");
            builder.Property(i => i.Phone2).HasColumnName("Phone2");
            builder.Property(i => i.Email).HasColumnName("Email");
        });

        builder.OwnsOne(p => p.Address, builder =>
        {
            builder.Property(i => i.Country).HasColumnName("Country");
            builder.Property(i => i.City).HasColumnName("City");
            builder.Property(i => i.Town).HasColumnName("Town");
            builder.Property(i => i.FullAddress).HasColumnName("FullAddress");
        });

        builder.Property(p => p.Salary).HasColumnType("money");
    }
}
