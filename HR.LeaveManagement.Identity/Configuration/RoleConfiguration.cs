using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.LeaveManagement.Identity.Configuration;

public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(
            new IdentityRole
            {
                Id = "104f7148-f8c6-4e04-aa5e-06e61c173191",
                Name = "Employee",
                NormalizedName = "EMPLOYEE",
            },
            new IdentityRole
            {
                Id = "b42a4a6c-3129-4fb7-b2d9-c98415011e7b",
                Name = "Administrator",
                NormalizedName = "ADMINISTRATOR",
            }
        );
    }
}
