
using System;
using System.Threading.Tasks;

using project_management.Contoller;

class Program
{

    static async Task Main(string[] args)
    {

        await AdminController.Init();
    }
}