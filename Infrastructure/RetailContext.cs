using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Retail.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Retail.Infrastructure
{
    public class RetailContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=LUCY\\MSSQLSERVER01;Initial Catalog=Retail;Integrated Security=True;Pooling=False;TrustServerCertificate=True");
        }

        //Agregar tablas a BD
        public DbSet<Category> Category { get; set; }

        public DbSet<Product> Product { get; set; }

        public DbSet<Sale> Sale { get; set; }

        public DbSet<SaleProduct> SaleProduct { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración de las entidades y relaciones

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.CategoryId);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                /*entity.HasMany(e => e.Productos)
                      .WithOne(p => p.Categoria)
                      .HasForeignKey(p => p.Category)
                      .OnDelete(DeleteBehavior.Restrict);*/
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductId);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Description).IsRequired().HasMaxLength(255);
                entity.Property(e => e.Price).IsRequired();
                entity.Property(e => e.Category).IsRequired();
                entity.Property(e => e.Discount).IsRequired();
                entity.Property(e => e.ImageUrl).IsRequired().HasMaxLength(255);
                entity.HasOne(e => e.Categoria)
                      .WithMany(c => c.Productos)
                      .HasForeignKey(e => e.Category)
                .OnDelete(DeleteBehavior.Restrict);

                entity.HasMany(e => e.VentaProductos)
                      .WithOne(sp => sp.Producto);
                      //.HasForeignKey(sp => sp.ProductId)
                      //.OnDelete(DeleteBehavior.Cascade); // Eliminación en cascada para las ventas relacionadas
            });


            // Cargar categorías automáticamente

            modelBuilder.Entity<Category>().HasData(
                    new Category { CategoryId = 1, Name = "Electrodomésticos" },
                    new Category { CategoryId = 2, Name = "Tecnología y Electrónica" },
                    new Category { CategoryId = 3, Name = "Moda y Accesorios" },
                    new Category { CategoryId = 4, Name = "Hogar y Decoración" },
                    new Category { CategoryId = 5, Name = "Salud y Belleza" },
                    new Category { CategoryId = 6, Name = "Deportes y Ocio" },
                    new Category { CategoryId = 7, Name = "Juguetes y Juegos" },
                    new Category { CategoryId = 8, Name = "Alimentos y Bebidas" },
                    new Category { CategoryId = 9, Name = "Libros y Material Educativo" },
                    new Category { CategoryId = 10, Name = "Jardinería y Bricolaje" });

            //Cargar productos automáticamente - 40 productos con datos verídicos
            modelBuilder.Entity<Product>().HasData(

            new Product
            {
                ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                Name = "Heladera con Freezer Drean",
                Description = "Hdr280f00b Blanca Clase A",
                Price = 590000.00m,
                Category= 1, // Asignar la categoría usando la enumeración
                Discount = 10,
                ImageUrl = "https://images.fravega.com/f300/c3cd04fe9a57248e4e02147c3a578911.jpg.webp"
            },

            new Product
            {
                ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                Name = "Lavarropas Drean Netx",
                Description = "Carga Frontal 6Kg 800 RPM Drean Next 6.08 ECO",
                Price = 670000.00m,
                Category= 1, // Asignar la categoría usando la enumeración
                Discount = 10,
                ImageUrl = "https://images.fravega.com/f300/bc553a4d53bb5eb5f9e44184047b212b.jpg.webp"
            },
            new Product
            {
                ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                Name = "Cocina Escorial Candor S2",
                Description = "Gas Natural 51 Cm",
                Price = 250000.00m,
                Category= 1, // Asignar la categoría usando la enumeración
                Discount = 10,
                ImageUrl = "https://images.fravega.com/f300/45826c7ab2451580e1ce693f2ee09679.jpg.webp"
            },

            new Product
            {
                ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                Name = "Calefón Tiro Natural Escorial",
                Description = "CE-14LBL 14Lts",
                Price = 280000.00m,
                Category= 1, // Asignar la categoría usando la enumeración
                Discount = 10,
                ImageUrl = "https://images.fravega.com/f300/50dd572c565d2d989cf43e709b626fcc.jpg.webp"
            },
            new Product
            {
                ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                Name = "Celular Motorola G23",
                Description = "128GB Azul",
                Price = 350000.00m,
                Category= 2, // Asignar la categoría usando la enumeración
                Discount = 0,
                ImageUrl = "https://images.fravega.com/f300/332a2d22382f714d26253b62446af895.png.webp"
            },
            new Product
            {
                ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                Name = "Celular Samsung Galaxy A54",
                Description = "5G 256GB Graphite",
                Price = 840000.00m,
                Category= 2, // Asignar la categoría usando la enumeración
                Discount = 0,
                ImageUrl = "https://images.fravega.com/f300/332a2d22382f714d26253b62446af895.png.webp"
            },
            new Product
            {
                ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                Name = "Xbox Serie S",
                Description = "1 TB Carbon Black",
                Price = 1050000.00m,
                Category= 2, // Asignar la categoría usando la enumeración
                Discount = 0,
                ImageUrl = "https://images.fravega.com/f300/bb99d78e3f2bffdc9ac01d6d4cc46761.jpg.webp"
            },
            new Product
            {
                ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                Name = "Notebook HP",
                Description = "14” Intel Celeron 4GB 256GB SSD 14-DQ0515LA",
                Price = 500000.00m,
                Category= 2, // Asignar la categoría usando la enumeración
                Discount = 0,
                ImageUrl = "https://images.fravega.com/f300/332a2d22382f714d26253b62446af895.png.webp"
            },
            new Product
            {
                ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                Name = "Reloj Inteligente Mujer Smartwatch Nictom",
                Description = "Malla Metal Rosa",
                Price = 35000.00m,
                Category= 3, // Asignar la categoría usando la enumeración
                Discount = 0,
                ImageUrl = "https://images.fravega.com/f300/480b83219a6b568d223a684bc320077c.jpg.webp"
            },
            new Product
            {
                ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                Name = "Reloj Digital Deportivo Gadnic Apolo",
                Description = "Sumergible negro",
                Price = 38560.00m,
                Category= 3, // Asignar la categoría usando la enumeración
                Discount = 0,
                ImageUrl = "https://images.fravega.com/f300/d3e720120971297c2af0c5e6a4d7c21d.jpg.webp"
            },
            new Product
            {
                ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                Name = "Auriculares Suono Bluetooth",
                Description = "TWS W-1 Black AYV0125, Rosa duracion bateria 4hs",
                Price = 7900.00m,
                Category= 3, // Asignar la categoría usando la enumeración
                Discount = 0,
                ImageUrl = "https://images.fravega.com/f300/de17587debfa3603efd00fc8b5211a02.jpg.webp"
            },
            new Product
            {
                ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                Name = "Auriculares Bluetooth Deportivos Suono S9",
                Description = "Negro,duracion bateria 4hs, formato vincha.",
                Price = 5000.00m,
                Category= 3, // Asignar la categoría usando la enumeración
                Discount = 10,
                ImageUrl = "https://images.fravega.com/f300/7f960ce8079a14e7b29a13eb2faf36ed.jpg.webp"
            },
            new Product
            {
                ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                Name = "Sommier y Colchón de Resortes Piero Genova",
                Description = "190 x 140 cm",
                Price = 295000.00m,
                Category= 4, // Asignar la categoría usando la enumeración
                Discount = 0,
                ImageUrl = "https://images.fravega.com/f300/1feb1913552f204a9f996da857073ff8.jpg.webp"
            },
            new Product
            {
                ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                Name = "Placard Perfileria de Aluminio Carpinteria Rivadavia Linea Delta",
                Description = "12 box de guardado de 28 x 28 - 4 cajones 59 ancho x 36 profundidad x 16 alto - Sector Colgado 171,5 x 56",
                Price = 284731.00m,
                Category= 4, // Asignar la categoría usando la enumeración
                Discount = 0,
                ImageUrl = "https://images.fravega.com/f300/dad338848c2a997aaa0b0d151d5995e2.png.webp"
            },
            new Product
            {
                ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                Name = "Silla Tulip ",
                Description = "Almohadón Pack X4 Negra Hdc Group",
                Price = 110000.00m,
                Category= 4, // Asignar la categoría usando la enumeración
                Discount = 10,
                ImageUrl = "https://images.fravega.com/f300/b5239d43444fcfb8c5cda9513a0feafc.jpg.webp"
            },
            new Product
            {
                ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                Name = "Sillón Trento",
                Description = "3 Cuerpos De Chenille Gris Oscuro Full Confort",
                Price = 488210.00m,
                Category= 4, // Asignar la categoría usando la enumeración
                Discount = 0,
                ImageUrl = "https://images.fravega.com/f300/2cd28c520d9b3fc4213e84615c348155.jpg.webp"
            },
            new Product
            {
                ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                Name = "Set 12 Pinceles Brochas para Ojos Cejas Daikon ",
                Description = "Set de 12 Pinceles y Brochas para Ojos y Cejas es un imprescindible para cualquier amante del maquillaje.",
                Price = 16800.00m,
                Category= 5, // Asignar la categoría usando la enumeración
                Discount = 10,
                ImageUrl = "https://images.fravega.com/f300/f523ff12a303961b3f297875489d1790.jpg.webp"
            },
            new Product
            {
                ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                Name = "Espejo Luz LED Maquillaje",
                Description = "Plegable Aumento Portátil Daikon BMF005",
                Price = 15200.00m,
                Category= 5, // Asignar la categoría usando la enumeración
                Discount = 10,
                ImageUrl = "https://images.fravega.com/f300/d6732cc7dab813c98be547482699fce0.jpg.webp"
            },
            new Product
            {
                ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                Name = "Cabina Uv Led Sun",
                Description = "Esta garantiza un secado y curado veloz gracias a sus 80w y 36 luces LED.",
                Price = 21600.00m,
                Category= 5, // Asignar la categoría usando la enumeración
                Discount = 0,
                ImageUrl = "https://images.fravega.com/f300/02e234f30d04bf0624f6ec2cc28a1c82.jpg.webp"
            },
            new Product
            {
                ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                Name = "Daikon Perfiladora De Cejas AE 302",
                Description = " COLORES BLANCA Y ROSA",
                Price = 9600.00m,
                Category= 5, // Asignar la categoría usando la enumeración
                Discount = 0,
                ImageUrl = "https://images.fravega.com/f300/acb620d996dd7c6d0b6404770b2c669c.jpg.webp"
            },
            new Product
            {
                ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                Name = "Kit Funcional Mancuernas + Barra 25Kg Randers",
                Description = "Mancuernas 25kg 47cm de largo, barra extensora 8 Discos de 1.25Kg ",
                Price = 9600.00m,
                Category= 6, // Asignar la categoría usando la enumeración
                Discount = 0,
                ImageUrl = "https://images.fravega.com/f300/49e2a4bd8a16dfe0681e5d78f7d83726.jpg.webp"
            },
            new Product
            {
                ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                Name = "Bicicleta Fija Gfitness L-001A Plateada",
                Description = "Peso máximo soportado 120kg",
                Price = 379000.00m,
                Category= 6, // Asignar la categoría usando la enumeración
                Discount = 10,
                ImageUrl = "https://images.fravega.com/f300/727c29cee54e6942d3804459c6c5839f.jpg.webp"
            },
            new Product
            {
                ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                Name = "Tabla para Abdominales con Mancuernas Randers",
                Description = "Mancuernas 25kg 47cm de largo",
                Price = 130000.00m,
                Category= 6, // Asignar la categoría usando la enumeración
                Discount = 0,
                ImageUrl = "https://images.fravega.com/f300/061c85fd9c81ccda6359407d911a9ed9.jpg.webp"
            },
            new Product
            {
                ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                Name = "Yoga Mat PVC 4mm MD9010-R Gfitness",
                Description = "La PVC Yoga Mat para yoga está hecha de PVC espumado.",
                Price = 9100.00m,
                Category= 6, // Asignar la categoría usando la enumeración
                Discount = 0,
                ImageUrl = "https://images.fravega.com/f300/d5adca919b008c4c12448963d74d61f4.jpg.webp"
            },
            new Product
            {
                ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                Name = "Cry Babies Dressy Fancy",
                Description = "Encantadoras muñecas",
                Price = 50000.00m,
                Category= 7, // Asignar la categoría usando la enumeración
                Discount = 10,
                ImageUrl = "https://images.fravega.com/f300/c6d0a55724ade8e6f7f6e7e83bdfaca5.png.webp"
            },
             new Product
             {
                 ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                 Name = "Juliana Tienda De Donas",
                 Description = "Edad recomendada: +3 años",
                 Price = 34482.00m,
                 Category= 7, // Asignar la categoría usando la enumeración
                 Discount = 0,
                 ImageUrl = "https://images.fravega.com/f300/31428ce9faa9608dc8f43daaf50fc299.jpg.webp"
             },
              new Product
              {
                  ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                  Name = "Bloques Magnéticos Para Armar 18 Piezas",
                  Description = "Estimula el pensamiento constructivo, espacial y abstracto.",
                  Price = 24011.00m,
                  Category= 7, // Asignar la categoría usando la enumeración
                  Discount = 0,
                  ImageUrl = "https://images.fravega.com/f300/d5adca919b008c4c12448963d74d61f4.jpg.webp"
              },
               new Product
               {
                   ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                   Name = "Duravit Mi Cocina 33 Piezas",
                   Description = "cocina infantil de juguete es una gran opción para los niños que aman cocinar.",
                   Price = 16030.00m,
                   Category= 7, // Asignar la categoría usando la enumeración
                   Discount = 10,
                   ImageUrl = "https://images.fravega.com/f300/d5adca919b008c4c12448963d74d61f4.jpg.webp"
               },
               new Product
               {
                   ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                   Name = "Yerba Mate Playadito Suave 1 Kg",
                   Description = "100% yerba mate (ilex paraguariensis)",
                   Price = 4845.00m,
                   Category= 8, // Asignar la categoría usando la enumeración
                   Discount = 0,
                   ImageUrl = "https://jumboargentina.vtexassets.com/arquivos/ids/711224-800-auto?v=637938633804770000&width=800&height=auto&aspect=true"
               },
               new Product
               {
                   ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                   Name = "Galletitas Con Chips De Chocolate Cuisine",
                   Description = "172 Gr Harina de trigo 000, hierro, ácido fólico, tiamina (b1), riboflavina (b2), niacina, azúcar, emu ins 442",
                   Price = 1350.00m,
                   Category= 8, // Asignar la categoría usando la enumeración
                   Discount = 0,
                   ImageUrl = "https://jumboargentina.vtexassets.com/arquivos/ids/791393-800-auto?v=638288337779830000&width=800&height=auto&aspect=true"
               },
               new Product
               {
                   ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                   Name = "Agua Mineral Sin Gas Cuisine-co 2 L",
                   Description = "Aguas Minerales sin Gas",
                   Price = 850.00m,
                   Category= 8, // Asignar la categoría usando la enumeración
                   Discount = 0,
                   ImageUrl = "https://jumboargentina.vtexassets.com/arquivos/ids/619126-800-auto?v=637457162754830000&width=800&height=auto&aspect=true"
               },
               new Product
               {
                   ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                   Name = "Gaseosa H2oh Naranchelo 2,25 L",
                   Description = "Aguas Saborizadas con Gas",
                   Price = 2047.50m,
                   Category= 8, // Asignar la categoría usando la enumeración
                   Discount = 10,
                   ImageUrl = "https://jumboargentina.vtexassets.com/arquivos/ids/769370-800-auto?v=638120073844000000&width=800&height=auto&aspect=true"
               },
               new Product
               {
                   ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                   Name = "CUADERNO SETTER GEOMETRY",
                   Description = "ESPIRAL A4 X 80 RAY.",
                   Price = 3700.50m,
                   Category= 9, // Asignar la categoría usando la enumeración
                   Discount = 0,
                   ImageUrl = "https://tiotomar.vtexassets.com/arquivos/ids/170536-800-800?v=637937572304970000&width=800&height=800&aspect=true"
               },
               new Product
               {
                   ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                   Name = "BLOCK SETTER DIBUJO",
                   Description = "N.5 COLOR X 24 H.",
                   Price = 3990.50m,
                   Category= 9, // Asignar la categoría usando la enumeración
                   Discount = 0,
                   ImageUrl = "https://tiotomar.vtexassets.com/arquivos/ids/226689-800-800?v=638423970202100000&width=800&height=800&aspect=true"
               },
               new Product
               {
                   ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                   Name = "LAPIZ GRAFITO BIC EVOLUTION ",
                   Description = "Cuerpo de resina plastica. No se astilla al sacarle punta",
                   Price = 1890.50m,
                   Category= 9, // Asignar la categoría usando la enumeración
                   Discount = 0,
                   ImageUrl = "https://tiotomar.vtexassets.com/arquivos/ids/167138-800-800?v=637937554688800000&width=800&height=800&aspect=true"
               },
               new Product
               {
                   ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                   Name = "LAPICES FABER CASTELL SUPERSOFT",
                   Description = "12 U Los nuevos colores SuperSoft tienen colores mucho mas vivos y ecologicos",
                   Price = 14900.50m,
                   Category= 9, // Asignar la categoría usando la enumeración
                   Discount = 10,
                   ImageUrl = "https://tiotomar.vtexassets.com/arquivos/ids/173873-800-800?v=637937587983730000&width=800&height=800&aspect=true"
               },
               new Product
               {
                   ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                   Name = "Set Kit Jardineria Sweet Garden Con Cinturon Tramontina",
                   Description = "8 piezas livianas y fabricadas con materiales de alta calidad",
                   Price = 65956.00m,
                   Category= 10, // Asignar la categoría usando la enumeración
                   Discount = 0,
                   ImageUrl = "https://images.fravega.com/f300/21cb40b3ef663bd75715a2aea63e7843.jpg.webp"
               },
               new Product
               {
                   ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                   Name = "Kit de Jardinería Gadnic",
                   Description = "Hechas de metal y plástico resistentes",
                   Price = 33000.00m,
                   Category= 10, // Asignar la categoría usando la enumeración
                   Discount = 0,
                   ImageUrl = "https://images.fravega.com/f300/6e80c3f28a89404ee55a5da927d97546.jpg.webp"
               },
               new Product
               {
                   ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                   Name = "Bordeadora Eléctrica Severbon",
                   Description = "motor eléctrico y una potencia de 1000 watts",
                   Price = 60000.00m,
                   Category= 10, // Asignar la categoría usando la enumeración
                   Discount = 10,
                   ImageUrl = "https://images.fravega.com/f300/ae1c68f705650940d5a14fdad43fdaf3.jpg.webp"
               },
               new Product
               {
                   ProductId = Guid.NewGuid(), // Generar un nuevo GUID para el Id
                   Name = "Hidrolavadora Eléctrica Daewoo",
                   Description = "Incluye: Pistola, manguera de 5 m, dispensador de detergente integrado. 2000 W",
                   Price = 220000.00m,
                   Category= 10, // Asignar la categoría usando la enumeración
                   Discount = 0,
                   ImageUrl = "https://images.fravega.com/f300/479643aca88b3f806fe312f688512467.jpg.webp"
               });

            
        }
        
}
}

