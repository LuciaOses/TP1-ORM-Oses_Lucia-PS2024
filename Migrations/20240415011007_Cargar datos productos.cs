using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Retail.Migrations
{
    /// <inheritdoc />
    public partial class Cargardatosproductos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Category", "Description", "Discount", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("02ad0b96-26e5-43c1-ac10-17f06b5dba34"), 6, "Mancuernas 25kg 47cm de largo", 10, "https://images.fravega.com/f300/061c85fd9c81ccda6359407d911a9ed9.jpg.webp", "Tabla para Abdominales con Mancuernas Randers", 130000.00m },
                    { new Guid("03c2cc0d-071a-4de5-b091-e5d06f10ee04"), 6, "La PVC Yoga Mat para yoga está hecha de PVC espumado.", 10, "https://images.fravega.com/f300/d5adca919b008c4c12448963d74d61f4.jpg.webp", "Yoga Mat PVC 4mm MD9010-R Gfitness", 9100.00m },
                    { new Guid("06ed7287-3021-464f-8f36-1abc0e5c848e"), 5, "Esta garantiza un secado y curado veloz gracias a sus 80w y 36 luces LED.", 10, "https://images.fravega.com/f300/02e234f30d04bf0624f6ec2cc28a1c82.jpg.webp", "Cabina Uv Led Sun", 21600.00m },
                    { new Guid("0dad3207-b1dd-4733-a439-fbef82c4f6b2"), 7, "Estimula el pensamiento constructivo, espacial y abstracto.", 10, "https://images.fravega.com/f300/d5adca919b008c4c12448963d74d61f4.jpg.webp", "Bloques Magnéticos Para Armar 18 Piezas", 24011.00m },
                    { new Guid("1364cf0d-fb53-4013-9a3a-90d0700c3cf8"), 1, "Gas Natural 51 Cm", 10, "https://images.fravega.com/f300/45826c7ab2451580e1ce693f2ee09679.jpg.webp", "Cocina Escorial Candor S2", 250000.00m },
                    { new Guid("1817167f-42cd-4e5b-ad87-592d63ff01d8"), 7, "Encantadoras muñecas", 10, "https://images.fravega.com/f300/c6d0a55724ade8e6f7f6e7e83bdfaca5.png.webp", "Cry Babies Dressy Fancy", 50000.00m },
                    { new Guid("1adf1af7-041f-4a92-ac5d-f2059dc8bc20"), 7, "Edad recomendada: +3 años", 10, "https://images.fravega.com/f300/31428ce9faa9608dc8f43daaf50fc299.jpg.webp", "Juliana Tienda De Donas", 34482.00m },
                    { new Guid("2c1fe04e-d248-4786-9aac-00e75a79a771"), 5, " COLORES BLANCA Y ROSA", 10, "https://images.fravega.com/f300/acb620d996dd7c6d0b6404770b2c669c.jpg.webp", "Daikon Perfiladora De Cejas AE 302", 9600.00m },
                    { new Guid("31b23593-4a27-4616-9b73-f80053b92c45"), 8, "172 Gr Harina de trigo 000, hierro, ácido fólico, tiamina (b1), riboflavina (b2), niacina, azúcar, emu ins 442", 10, "https://jumboargentina.vtexassets.com/arquivos/ids/791393-800-auto?v=638288337779830000&width=800&height=auto&aspect=true", "Galletitas Con Chips De Chocolate Cuisine", 1350.00m },
                    { new Guid("350408cf-c437-4b8a-8ef6-641b03e56ef2"), 10, "8 piezas livianas y fabricadas con materiales de alta calidad", 10, "https://images.fravega.com/f300/21cb40b3ef663bd75715a2aea63e7843.jpg.webp", "Set Kit Jardineria Sweet Garden Con Cinturon Tramontina", 65956.00m },
                    { new Guid("39248fec-e949-40d9-be22-f92533c08f82"), 5, "Plegable Aumento Portátil Daikon BMF005", 10, "https://images.fravega.com/f300/d6732cc7dab813c98be547482699fce0.jpg.webp", "Espejo Luz LED Maquillaje", 15200.00m },
                    { new Guid("3bdcf679-4fee-47d3-ad78-7d0e0a64b8e3"), 6, "Mancuernas 25kg 47cm de largo, barra extensora 8 Discos de 1.25Kg ", 10, "https://images.fravega.com/f300/49e2a4bd8a16dfe0681e5d78f7d83726.jpg.webp", "Kit Funcional Mancuernas + Barra 25Kg Randers", 9600.00m },
                    { new Guid("4aca5e34-b9c8-47a8-85ef-f19cd711a1de"), 4, "Almohadón Pack X4 Negra Hdc Group", 10, "https://images.fravega.com/f300/b5239d43444fcfb8c5cda9513a0feafc.jpg.webp", "Silla Tulip ", 110000.00m },
                    { new Guid("537b6897-94e1-4284-91a4-228982a9bcde"), 3, "TWS W-1 Black AYV0125, Rosa duracion bateria 4hs", 10, "https://images.fravega.com/f300/de17587debfa3603efd00fc8b5211a02.jpg.webp", "Auriculares Suono Bluetooth", 7900.00m },
                    { new Guid("5504945a-19b6-4ba3-a76a-ebf609be1da2"), 4, "12 box de guardado de 28 x 28 - 4 cajones 59 ancho x 36 profundidad x 16 alto - Sector Colgado 171,5 x 56", 10, "https://images.fravega.com/f300/dad338848c2a997aaa0b0d151d5995e2.png.webp", "Placard Perfileria de Aluminio Carpinteria Rivadavia Linea Delta", 284731.00m },
                    { new Guid("5afd5f87-daa9-4e33-a302-5d8728b361a7"), 10, "Incluye: Pistola, manguera de 5 m, dispensador de detergente integrado. 2000 W", 10, "https://images.fravega.com/f300/479643aca88b3f806fe312f688512467.jpg.webp", "Hidrolavadora Eléctrica Daewoo", 220000.00m },
                    { new Guid("62fa6192-5272-4ebb-8aa8-b2c1e717906f"), 4, "3 Cuerpos De Chenille Gris Oscuro Full Confort", 10, "https://images.fravega.com/f300/2cd28c520d9b3fc4213e84615c348155.jpg.webp", "Sillón Trento", 488210.00m },
                    { new Guid("639d6f36-0412-4191-a49f-eebb20082734"), 3, "Sumergible negro", 10, "https://images.fravega.com/f300/d3e720120971297c2af0c5e6a4d7c21d.jpg.webp", "Reloj Digital Deportivo Gadnic Apolo", 38560.00m },
                    { new Guid("67d70676-decf-4f08-8aa8-bbe77db48eee"), 7, "cocina infantil de juguete es una gran opción para los niños que aman cocinar.", 10, "https://images.fravega.com/f300/d5adca919b008c4c12448963d74d61f4.jpg.webp", "Duravit Mi Cocina 33 Piezas", 16030.00m },
                    { new Guid("6e72c92b-6043-4286-af8e-085ce3002100"), 4, "190 x 140 cm", 10, "https://images.fravega.com/f300/1feb1913552f204a9f996da857073ff8.jpg.webp", "Sommier y Colchón de Resortes Piero Genova", 295000.00m },
                    { new Guid("7420e468-b41b-4ccd-942e-0a00413bca15"), 2, "5G 256GB Graphite", 10, "https://images.fravega.com/f300/332a2d22382f714d26253b62446af895.png.webp", "Celular Samsung Galaxy A54", 840000.00m },
                    { new Guid("78436472-8d7e-418c-9ff7-f9f6a56bea5b"), 8, "100% yerba mate (ilex paraguariensis)", 10, "https://jumboargentina.vtexassets.com/arquivos/ids/711224-800-auto?v=637938633804770000&width=800&height=auto&aspect=true", "Yerba Mate Playadito Suave 1 Kg", 4845.00m },
                    { new Guid("7cc333fa-b924-49df-928a-f138236cc42c"), 9, "N.5 COLOR X 24 H.", 10, "https://tiotomar.vtexassets.com/arquivos/ids/226689-800-800?v=638423970202100000&width=800&height=800&aspect=true", "BLOCK SETTER DIBUJO", 3990.50m },
                    { new Guid("83cf0519-76f8-4b67-ae12-7a9285373251"), 10, "motor eléctrico y una potencia de 1000 watts", 10, "https://images.fravega.com/f300/ae1c68f705650940d5a14fdad43fdaf3.jpg.webp", "Bordeadora Eléctrica Severbon", 60000.00m },
                    { new Guid("88f03a3f-0131-4a81-9e15-5861e3c26c17"), 9, "12 U Los nuevos colores SuperSoft tienen colores mucho mas vivos y ecologicos", 9, "https://tiotomar.vtexassets.com/arquivos/ids/173873-800-800?v=637937587983730000&width=800&height=800&aspect=true", "LAPICES FABER CASTELL SUPERSOFT", 14900.50m },
                    { new Guid("965376b8-8f5d-4a6b-a971-7ed3de5019cf"), 1, "Carga Frontal 6Kg 800 RPM Drean Next 6.08 ECO", 10, "https://images.fravega.com/f300/bc553a4d53bb5eb5f9e44184047b212b.jpg.webp", "Lavarropas Drean Netx", 670000.00m },
                    { new Guid("993edbc6-32c9-4bd5-9f99-5dd5288fa709"), 6, "Peso máximo soportado 120kg", 10, "https://images.fravega.com/f300/727c29cee54e6942d3804459c6c5839f.jpg.webp", "Bicicleta Fija Gfitness L-001A Plateada", 379000.00m },
                    { new Guid("a513c9d1-c238-4e2c-866f-bce0294a2a64"), 2, "14” Intel Celeron 4GB 256GB SSD 14-DQ0515LA", 10, "https://images.fravega.com/f300/332a2d22382f714d26253b62446af895.png.webp", "Notebook HP", 500000.00m },
                    { new Guid("b6710fa6-80f6-4919-aeec-1636976b297e"), 8, "Aguas Saborizadas con Gas", 10, "https://jumboargentina.vtexassets.com/arquivos/ids/769370-800-auto?v=638120073844000000&width=800&height=auto&aspect=true", "Gaseosa H2oh Naranchelo 2,25 L", 2047.50m },
                    { new Guid("bca166c8-635c-4162-b276-034bc410db17"), 3, "Malla Metal Rosa", 10, "https://images.fravega.com/f300/480b83219a6b568d223a684bc320077c.jpg.webp", "Reloj Inteligente Mujer Smartwatch Nictom", 35000.00m },
                    { new Guid("cd1671d1-67bf-45c3-8a7b-a7d34dfb0b2e"), 1, "Hdr280f00b Blanca Clase A", 10, "https://images.fravega.com/f300/c3cd04fe9a57248e4e02147c3a578911.jpg.webp", "Heladera con Freezer Drean", 590000.00m },
                    { new Guid("d4fa0a52-da00-4cfb-b6ec-9d5f106594ab"), 1, "CE-14LBL 14Lts", 10, "https://images.fravega.com/f300/50dd572c565d2d989cf43e709b626fcc.jpg.webp", "Calefón Tiro Natural Escorial", 280000.00m },
                    { new Guid("d811150c-9f20-4262-bc3c-fe822c817525"), 9, "Cuerpo de resina plastica. No se astilla al sacarle punta", 9, "https://tiotomar.vtexassets.com/arquivos/ids/167138-800-800?v=637937554688800000&width=800&height=800&aspect=true", "LAPIZ GRAFITO BIC EVOLUTION ", 1890.50m },
                    { new Guid("da0c87bb-3ebd-4253-b88b-c11315367195"), 2, "1 TB Carbon Black", 10, "https://images.fravega.com/f300/bb99d78e3f2bffdc9ac01d6d4cc46761.jpg.webp", "Xbox Serie S", 1050000.00m },
                    { new Guid("dc587fe0-cb79-4ed4-9e54-0fceb253bc2b"), 5, "Set de 12 Pinceles y Brochas para Ojos y Cejas es un imprescindible para cualquier amante del maquillaje.", 10, "https://images.fravega.com/f300/f523ff12a303961b3f297875489d1790.jpg.webp", "Set 12 Pinceles Brochas para Ojos Cejas Daikon ", 16800.00m },
                    { new Guid("dd7c0794-320b-48b5-a634-fb33a5ed5b1a"), 9, "ESPIRAL A4 X 80 RAY.", 10, "https://tiotomar.vtexassets.com/arquivos/ids/170536-800-800?v=637937572304970000&width=800&height=800&aspect=true", "CUADERNO SETTER GEOMETRY", 3700.50m },
                    { new Guid("dfb064d4-1fee-41c7-a4ee-4d53f97a007c"), 10, "Hechas de metal y plástico resistentes", 10, "https://images.fravega.com/f300/6e80c3f28a89404ee55a5da927d97546.jpg.webp", "Kit de Jardinería Gadnic", 33000.00m },
                    { new Guid("e992942a-080b-4833-b7d5-775de466133f"), 3, "Negro,duracion bateria 4hs, formato vincha.", 10, "https://images.fravega.com/f300/7f960ce8079a14e7b29a13eb2faf36ed.jpg.webp", "Auriculares Bluetooth Deportivos Suono S9", 5000.00m },
                    { new Guid("ee1425ad-4935-49b4-9c73-f10061dccbe0"), 8, "Aguas Minerales sin Gas", 10, "https://jumboargentina.vtexassets.com/arquivos/ids/619126-800-auto?v=637457162754830000&width=800&height=auto&aspect=true", "Agua Mineral Sin Gas Cuisine-co 2 L", 850.00m },
                    { new Guid("f400ab17-dc48-4494-b38d-7a63c08c409d"), 2, "128GB Azul", 10, "https://images.fravega.com/f300/332a2d22382f714d26253b62446af895.png.webp", "Celular Motorola G23", 350000.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("02ad0b96-26e5-43c1-ac10-17f06b5dba34"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("03c2cc0d-071a-4de5-b091-e5d06f10ee04"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("06ed7287-3021-464f-8f36-1abc0e5c848e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("0dad3207-b1dd-4733-a439-fbef82c4f6b2"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("1364cf0d-fb53-4013-9a3a-90d0700c3cf8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("1817167f-42cd-4e5b-ad87-592d63ff01d8"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("1adf1af7-041f-4a92-ac5d-f2059dc8bc20"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("2c1fe04e-d248-4786-9aac-00e75a79a771"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("31b23593-4a27-4616-9b73-f80053b92c45"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("350408cf-c437-4b8a-8ef6-641b03e56ef2"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("39248fec-e949-40d9-be22-f92533c08f82"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("3bdcf679-4fee-47d3-ad78-7d0e0a64b8e3"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("4aca5e34-b9c8-47a8-85ef-f19cd711a1de"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("537b6897-94e1-4284-91a4-228982a9bcde"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("5504945a-19b6-4ba3-a76a-ebf609be1da2"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("5afd5f87-daa9-4e33-a302-5d8728b361a7"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("62fa6192-5272-4ebb-8aa8-b2c1e717906f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("639d6f36-0412-4191-a49f-eebb20082734"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("67d70676-decf-4f08-8aa8-bbe77db48eee"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("6e72c92b-6043-4286-af8e-085ce3002100"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("7420e468-b41b-4ccd-942e-0a00413bca15"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("78436472-8d7e-418c-9ff7-f9f6a56bea5b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("7cc333fa-b924-49df-928a-f138236cc42c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("83cf0519-76f8-4b67-ae12-7a9285373251"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("88f03a3f-0131-4a81-9e15-5861e3c26c17"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("965376b8-8f5d-4a6b-a971-7ed3de5019cf"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("993edbc6-32c9-4bd5-9f99-5dd5288fa709"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("a513c9d1-c238-4e2c-866f-bce0294a2a64"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("b6710fa6-80f6-4919-aeec-1636976b297e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("bca166c8-635c-4162-b276-034bc410db17"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("cd1671d1-67bf-45c3-8a7b-a7d34dfb0b2e"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("d4fa0a52-da00-4cfb-b6ec-9d5f106594ab"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("d811150c-9f20-4262-bc3c-fe822c817525"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("da0c87bb-3ebd-4253-b88b-c11315367195"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("dc587fe0-cb79-4ed4-9e54-0fceb253bc2b"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("dd7c0794-320b-48b5-a634-fb33a5ed5b1a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("dfb064d4-1fee-41c7-a4ee-4d53f97a007c"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("e992942a-080b-4833-b7d5-775de466133f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("ee1425ad-4935-49b4-9c73-f10061dccbe0"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("f400ab17-dc48-4494-b38d-7a63c08c409d"));
        }
    }
}
