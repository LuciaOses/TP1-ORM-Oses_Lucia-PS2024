using Microsoft.VisualStudio.Web.CodeGeneration.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private readonly ProductService _productService;
        private readonly SaleService _saleService;

        public MenuHandler()
        {
            _productService = new ProductService();
            _saleService = new SaleService();
        }

        public void ListProduct()
        {
            Console.WriteLine("Listar Producto");
            Console.WriteLine("Presione enter para continuar.");
            Console.ReadLine();
            
            // Lógica para registrar un producto utilizando el servicio ProductService
        }

        public void RegisterSale()
        {
            Console.WriteLine("Registrar Venta");
            Console.WriteLine("Presione enter para continuar.");
            Console.ReadLine();
            // Lógica para registrar una venta utilizando el servicio SaleService
        }
    }

    public class ProductService
    {
        private readonly ProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new ProductRepository();
        }

        // Métodos para operaciones relacionadas con productos
    }

    public class SaleService
    {
        private readonly SaleRepository _saleRepository;

        public SaleService()
        {
            _saleRepository = new SaleRepository();
        }

        // Métodos para operaciones relacionadas con ventas
    }

    public class ProductRepository
    {
        // Implementación de métodos de persistencia para productos utilizando un ORM
    }

    public class SaleRepository
    {
        // Implementación de métodos de persistencia para ventas utilizando un ORM
    }
}

