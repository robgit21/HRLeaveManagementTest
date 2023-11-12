using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.LeaveManagement.Identity.Configuration;

public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
{
    public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
    {
        builder.HasData(
            new IdentityUserRole<string>
            {
                RoleId = "b42a4a6c-3129-4fb7-b2d9-c98415011e7b",
                UserId = "1d8cc678-9a2a-4615-9c70-e2beff2539d3",
            },
            new IdentityUserRole<string>
            {
                RoleId = "104f7148-f8c6-4e04-aa5e-06e61c173191",
                UserId = "1def4d15-25ca-4beb-9736-c927ebd068d5",
            }
        );
    }
}