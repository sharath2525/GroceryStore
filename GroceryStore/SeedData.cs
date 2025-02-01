using GroceryStore.Models;
using Microsoft.AspNetCore.Identity;

namespace GroceryStore
{
    public static class SeedData
    {
            public static async Task Initialize(IServiceProvider serviceProvider)
            {
                using (var scope = serviceProvider.CreateScope())
                {
                    var scopedProvider = scope.ServiceProvider;
                    var roleManager = scopedProvider.GetRequiredService<RoleManager<IdentityRole>>();
                    var userManager = scopedProvider.GetRequiredService<UserManager<IdentityUser>>();

                    // Ensure the roles exist
                    if (!await roleManager.RoleExistsAsync("Admin"))
                    {
                        await roleManager.CreateAsync(new IdentityRole("Admin"));
                    }
                    if (!await roleManager.RoleExistsAsync("Customer"))
                    {
                        await roleManager.CreateAsync(new IdentityRole("Customer"));
                    }


                    // Ensure the admin user exists
                    var adminEmail = "admin@example.com";
                    var adminUser = await userManager.FindByEmailAsync(adminEmail);
                    
                    if (adminUser == null)
                    {
                        adminUser = new ApplicationUser
                        {
                            UserName = adminEmail,
                            Email = adminEmail,
                            PhoneNumber = "1234567890",
                            Name="Admin"
                        
                          
                        };
                        var result = await userManager.CreateAsync(adminUser, "Admin@123");
                        if (result.Succeeded)
                        {
                            await userManager.AddToRoleAsync(adminUser, "Admin");
                        }
                    }
                }
            }

    }
}
