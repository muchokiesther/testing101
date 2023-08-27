using System;
using System.Threading.Tasks;
using project_management.Services;
using project_management.Helpers;
using project_management.Models;
using project_management.Data;

namespace project_management.Contoller
{
    class AdminController
    {
        private readonly AdminServices _adminServices;

        public AdminController(AdminServices adminServices)
        {
            _adminServices = adminServices;
        }

        public static async Task Main(string[] args)
        {
            await Init();
        }

        public static async Task Init()
        {
            var adminServices = new AdminServices(new ApplicationDbContext());
            var adminController = new AdminController(adminServices);
            await adminController.RunAdminMenu();
        }

        public async Task RunAdminMenu()
        {
            while (true)
            {
                Console.WriteLine("1. Add Project");
                Console.WriteLine("2. View All Tasks");
                Console.WriteLine("3. View Project Details");
                Console.WriteLine("4. View Task Details");
                Console.WriteLine("5. Exit");

                var input = Console.ReadLine();

                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Invalid choice. Please enter a valid menu number.");
                    continue;
                }

                await MenuRedirectAsync(choice);
            }
        }

        private async Task MenuRedirectAsync(int choice)
        {
            switch (choice)
            {
                case 1:
                   
                    break;

         

                case 5:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

      

     
    }
}
