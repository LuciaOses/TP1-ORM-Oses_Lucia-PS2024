using System;
using System.Collections.Generic;
using Retail.Application.Services;
using Retail.Domain;
using Retail.Infrastructure;

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
            var dbContext = new RetailContext(); // Crear el contexto de la base de datos
            var productService = new ServiceProducto(dbContext);
            var menuHandler = new MenuHandler(productService); // Inyectar dependencia del servicio
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
        private readonly ServiceProducto _productService;
        private List<Product> products;

        public MenuHandler(ServiceProducto productService)
        {
            _productService = productService;
            products = _productService.GetAll();
        }

        public void ListProduct()
        {
            int indice = 1;
            Console.WriteLine("Listar Productos");

            foreach (var productoItem in products)
            {
                Console.WriteLine("| " + indice + ". " + productoItem.Name + " / $" + productoItem.Price);
                indice++;
            }
            Console.WriteLine("Presione enter para continuar.");
            Console.ReadLine();
        }

        public void RegisterSale()
        {
            Console.Clear();
            Console.WriteLine("Seleccione Producto de Compra:");

            if (products == null || products.Count == 0)
            {
                Console.WriteLine("No hay productos disponibles para la venta.");
                Console.WriteLine("Presione enter para volver al menú principal.");
                Console.ReadLine();
                return;
            }

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i].Name} - Precio: ${products[i].Price} ");
            }

            List<SaleProduct> selectedSaleProducts = new List<SaleProduct>();
            bool addProducts = true;

            while (addProducts)
            {
                Console.Write("Seleccione un producto por su índice (1-" + products.Count + "): ");
                if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= products.Count)
                {
                    var selectedProduct = products[index - 1];
                    var saleProduct = new SaleProduct
                    {
                        Product = selectedProduct.ProductId,
                        Quantity = 1,
                        Price = selectedProduct.Price,
                        Discount = selectedProduct.Discount,
                        Venta = null,
                        Producto = null,
                    };
                    selectedSaleProducts.Add(saleProduct);
                }
                else
                {
                    Console.WriteLine("Índice inválido. Intente de nuevo.");
                }

                Console.Write("¿Desea agregar otro producto? (S/N): ");
                addProducts = Console.ReadLine().Trim().ToUpper() == "S";
            }

            CalculateAndPrintSaleDetails(selectedSaleProducts);
        }

        public void CalculateAndPrintSaleDetails(List<SaleProduct> selectedSaleProducts)
        {
            try
            {
                decimal subtotal = selectedSaleProducts.Sum(s => s.Quantity * s.Price);
                decimal totalDiscount = selectedSaleProducts.Sum(s => s.Price * s.Discount / 100);
                decimal taxes = 1.21m; // IVA del 21%
                decimal totalPayment = (subtotal - totalDiscount) * taxes;

                Console.WriteLine("Detalle de la Venta:");
                Console.WriteLine("-------------------");

                foreach (var saleProduct in selectedSaleProducts)
                {
                    Console.WriteLine($"Producto: {saleProduct.Product}- Cantidad: {saleProduct.Quantity} - Precio Unitario: ${saleProduct.Price} - Descuento: %{saleProduct.Discount}");
                }

                Console.WriteLine($"Subtotal: ${subtotal}");
                Console.WriteLine($"Descuento Total: % {totalDiscount}");
                Console.WriteLine($"Total de Pago: ${totalPayment}");

                Console.WriteLine("Presione enter para continuar.");
                Console.ReadLine();
                Console.WriteLine("Venta registrada correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al registrar la venta: {ex.Message}");
                Console.WriteLine("Presione enter para continuar.");
                Console.ReadLine();
            }
        }
    }
}


