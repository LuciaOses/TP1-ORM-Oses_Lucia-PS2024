using Microsoft.VisualStudio.Web.CodeGeneration.Design;
using System;
using Retail.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Humanizer;
using Retail.Application.Services;

namespace Retail.Application
{
    public class ProgramMenuRetail
    {
        private readonly MenuHandler _menuHandler;

        public ProgramMenuRetail(MenuHandler menuHandler)
        {
            _menuHandler = menuHandler;
        }

        static void Main(string[] args)
        {
            var menuHandler = new MenuHandler();
            var program = new ProgramMenuRetail(menuHandler);
            program.MenuRetail();
        }

        void MenuRetail()
        {
            string? op;
            do
            {
                Console.Clear();
                ShowMainMenu();

                Console.WriteLine("La opción ingresada:");
                op = Console.ReadLine();

                switch (op)
                {
                    case "1":
                        _menuHandler.ListProduct();
                        break;

                    case "2":
                        _menuHandler.RegisterSale();
                        break;

                    case "3":
                        Console.WriteLine("Saliendo del programa");
                        break;

                    default:
                        ShowInvalidOptionMessage();
                        break;
                }
            } while (op != "3");
        }

        private void ShowMainMenu()
        {
            Console.WriteLine("*******************************************************************\n" +
                              "****                     Tienda Retail                         ****\n" +
                              "*******************************************************************\n");
            Console.WriteLine("BIENVENI@. Por favor, seleccione una opción del menú: \n\n");
            Console.WriteLine("1) Listar Producto\n" +
                              "2) Registrar Venta\n" +
                              "3) Salir del programa.");
        }

        private void ShowInvalidOptionMessage()
        {
            Console.Clear();
            Console.WriteLine("La opción ingresada no es correcta, por favor inténtelo nuevamente.");
            Console.WriteLine("Presione enter para continuar.");
            Console.ReadLine();
        }
    }

    public class MenuHandler
    {

        public void ListProduct()
        {
            // Supongamos que RetailContext es tu contexto de base de datos
            var dbContext = new RetailContext();
            var productService = new ServiceProducto(dbContext);

            int indice = 1;
            Console.WriteLine("Listar Productos");
            

            // Lógica para listar productos utilizando el servicio ProductService
            foreach (var productoItem in productService.GetAll())
            {
                Console.WriteLine("| " + indice + ". " + productoItem.Name + " / $" + productoItem.Price);
                indice++;
            }
            Console.WriteLine("Presione enter para continuar.");
            Console.ReadLine();
        }

        public void RegisterSale()
        {
            Console.WriteLine("Registrar Venta");
            Console.WriteLine("Presione enter para continuar.");
            Console.ReadLine();
            // Lógica para registrar una venta utilizando el servicio SaleService
        }
    }
}

