using ComlabManager.Core.Interfaces;
using ComlabManager.Infrastructure.Repositories;
using ComLabManager.Core.Interfaces;
using ComLabManager.UI;
using ComLabManager.UI.NavigationStrategies; // Required for your new strategies
using Dapper;
using Microsoft.Extensions.DependencyInjection;
using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace ComLabManager.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            var services = new ServiceCollection();

            services.AddTransient<IEquipmentRepository>(provider => new EquipmentRepository(connectionString));
            services.AddTransient<IUserRepository>(provider => new UserRepository(connectionString));

            services.AddTransient<MainForm>();
            services.AddTransient<LoginForm>();

            var serviceProvider = services.BuildServiceProvider();

            // Temporary Admin Password Seeding
            using (var connection = new MySqlConnection(connectionString))
            {
                string realHash = BCrypt.Net.BCrypt.HashPassword("admin123");
                string updateSql = "UPDATE Users SET PasswordHash = @Hash WHERE Username = 'admin_reaj'";
                connection.Execute(updateSql, new { Hash = realHash });
            }

            var loginForm = serviceProvider.GetRequiredService<LoginForm>();

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                var loggedInUser = loginForm.AuthenticatedUser;

                // 1. Determine the strategy based on the database user role
                IRoleNavigationStrategy roleStrategy = loggedInUser.Role switch
                {
                    "Admin" => new AdminStrategy(),
                    "Student" => new StudentStrategy(),
                    "Technician" => new TechnicianStrategy(),
                    _ => throw new UnauthorizedAccessException("Unknown user role detected.")
                };

                var mainForm = serviceProvider.GetRequiredService<MainForm>();

                // 2. Inject both the user data AND their navigation rules into the form
                mainForm.SetCurrentUser(loggedInUser, roleStrategy);

                Application.Run(mainForm);
            }
            else
            {
                Application.Exit();
            }
        }
    }
}