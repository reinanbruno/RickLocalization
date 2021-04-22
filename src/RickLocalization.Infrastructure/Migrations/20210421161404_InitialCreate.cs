using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RickLocalization.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dimensions",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "TEXT", nullable: false),
                    name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimensions", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Morties",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "TEXT", nullable: false),
                    name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    url_image = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Morties", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Ricks",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "TEXT", nullable: false),
                    id_morty = table.Column<Guid>(type: "TEXT", nullable: false),
                    id_dimension_origin = table.Column<Guid>(type: "TEXT", nullable: false),
                    name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true),
                    url = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    url_image = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    registration_date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ricks", x => x.id);
                    table.ForeignKey(
                        name: "FK_Ricks_Dimensions_id_dimension_origin",
                        column: x => x.id_dimension_origin,
                        principalTable: "Dimensions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Ricks_Morties_id_morty",
                        column: x => x.id_morty,
                        principalTable: "Morties",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DimensionsTravelled",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "TEXT", nullable: false),
                    id_rick = table.Column<Guid>(type: "TEXT", nullable: false),
                    id_dimension_before = table.Column<Guid>(type: "TEXT", nullable: true),
                    id_dimension_current = table.Column<Guid>(type: "TEXT", nullable: false),
                    registration_date = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimensionsTravelled", x => x.id);
                    table.ForeignKey(
                        name: "FK_DimensionsTravelled_Dimensions_id_dimension_before",
                        column: x => x.id_dimension_before,
                        principalTable: "Dimensions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DimensionsTravelled_Dimensions_id_dimension_current",
                        column: x => x.id_dimension_current,
                        principalTable: "Dimensions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DimensionsTravelled_Ricks_id_rick",
                        column: x => x.id_rick,
                        principalTable: "Ricks",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Dimensions",
                columns: new[] { "id", "name" },
                values: new object[] { new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), "C-130" });

            migrationBuilder.InsertData(
                table: "Dimensions",
                columns: new[] { "id", "name" },
                values: new object[] { new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), "C-148" });

            migrationBuilder.InsertData(
                table: "Dimensions",
                columns: new[] { "id", "name" },
                values: new object[] { new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), "C-147" });

            migrationBuilder.InsertData(
                table: "Dimensions",
                columns: new[] { "id", "name" },
                values: new object[] { new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), "C-146" });

            migrationBuilder.InsertData(
                table: "Dimensions",
                columns: new[] { "id", "name" },
                values: new object[] { new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), "C-145" });

            migrationBuilder.InsertData(
                table: "Dimensions",
                columns: new[] { "id", "name" },
                values: new object[] { new Guid("8314eeb6-1a7a-4e8f-adee-4f95b1b37e1a"), "C-144" });

            migrationBuilder.InsertData(
                table: "Dimensions",
                columns: new[] { "id", "name" },
                values: new object[] { new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), "C-143" });

            migrationBuilder.InsertData(
                table: "Dimensions",
                columns: new[] { "id", "name" },
                values: new object[] { new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), "C-142" });

            migrationBuilder.InsertData(
                table: "Dimensions",
                columns: new[] { "id", "name" },
                values: new object[] { new Guid("8158bf46-2e3c-4790-b8fa-559f54f9bda7"), "C-141" });

            migrationBuilder.InsertData(
                table: "Dimensions",
                columns: new[] { "id", "name" },
                values: new object[] { new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), "C-140" });

            migrationBuilder.InsertData(
                table: "Dimensions",
                columns: new[] { "id", "name" },
                values: new object[] { new Guid("fd95e867-b447-4b09-9b36-42b89eb2ebf8"), "C-149" });

            migrationBuilder.InsertData(
                table: "Dimensions",
                columns: new[] { "id", "name" },
                values: new object[] { new Guid("3dee27e7-2a6e-4953-80c5-9b4f3a175688"), "C-138" });

            migrationBuilder.InsertData(
                table: "Dimensions",
                columns: new[] { "id", "name" },
                values: new object[] { new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), "C-137" });

            migrationBuilder.InsertData(
                table: "Dimensions",
                columns: new[] { "id", "name" },
                values: new object[] { new Guid("4a707f05-b269-460e-abc0-4cbb511c2546"), "C-136" });

            migrationBuilder.InsertData(
                table: "Dimensions",
                columns: new[] { "id", "name" },
                values: new object[] { new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), "C-135" });

            migrationBuilder.InsertData(
                table: "Dimensions",
                columns: new[] { "id", "name" },
                values: new object[] { new Guid("3c09eaf7-b837-4996-b119-26a426cb8919"), "C-134" });

            migrationBuilder.InsertData(
                table: "Dimensions",
                columns: new[] { "id", "name" },
                values: new object[] { new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), "C-133" });

            migrationBuilder.InsertData(
                table: "Dimensions",
                columns: new[] { "id", "name" },
                values: new object[] { new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), "C-132" });

            migrationBuilder.InsertData(
                table: "Dimensions",
                columns: new[] { "id", "name" },
                values: new object[] { new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), "C-131" });

            migrationBuilder.InsertData(
                table: "Dimensions",
                columns: new[] { "id", "name" },
                values: new object[] { new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), "C-139" });

            migrationBuilder.InsertData(
                table: "Morties",
                columns: new[] { "id", "name", "url_image" },
                values: new object[] { new Guid("34e0e5b6-c352-4286-9a88-f0b8a2482c20"), "Morty 12", "https://i.pinimg.com/originals/ca/fb/06/cafb06c6485985c56e9ac0e616791fae.png" });

            migrationBuilder.InsertData(
                table: "Morties",
                columns: new[] { "id", "name", "url_image" },
                values: new object[] { new Guid("776be263-55bc-4b1b-95f3-45822c6e10f1"), "Morty 13", "https://comicvine1.cbsistatic.com/uploads/scale_small/6/66303/4469088-tumblr_inline_n0aleph3fl1r8rr6o.jpg" });

            migrationBuilder.InsertData(
                table: "Morties",
                columns: new[] { "id", "name", "url_image" },
                values: new object[] { new Guid("a5042853-2b23-4c00-bdcd-61a40918e359"), "Morty 14", "https://i.pinimg.com/originals/ca/fb/06/cafb06c6485985c56e9ac0e616791fae.png" });

            migrationBuilder.InsertData(
                table: "Morties",
                columns: new[] { "id", "name", "url_image" },
                values: new object[] { new Guid("3521e6ec-f1e8-403b-8f98-1fb5c0627b6a"), "Morty 18", "https://i.pinimg.com/originals/ca/fb/06/cafb06c6485985c56e9ac0e616791fae.png" });

            migrationBuilder.InsertData(
                table: "Morties",
                columns: new[] { "id", "name", "url_image" },
                values: new object[] { new Guid("4ba413d2-f7de-4622-9068-3b3e22f3ff41"), "Morty 16", "https://i.pinimg.com/originals/ca/fb/06/cafb06c6485985c56e9ac0e616791fae.png" });

            migrationBuilder.InsertData(
                table: "Morties",
                columns: new[] { "id", "name", "url_image" },
                values: new object[] { new Guid("18d40939-b99d-4e55-8460-17d9012ca6fa"), "Morty 17", "https://comicvine1.cbsistatic.com/uploads/scale_small/6/66303/4469088-tumblr_inline_n0aleph3fl1r8rr6o.jpg" });

            migrationBuilder.InsertData(
                table: "Morties",
                columns: new[] { "id", "name", "url_image" },
                values: new object[] { new Guid("62ced4f4-2560-4896-bd5a-8ef48cecca17"), "Morty 11", "https://comicvine1.cbsistatic.com/uploads/scale_small/6/66303/4469088-tumblr_inline_n0aleph3fl1r8rr6o.jpg" });

            migrationBuilder.InsertData(
                table: "Morties",
                columns: new[] { "id", "name", "url_image" },
                values: new object[] { new Guid("626a6c1e-c3fa-47ca-83ee-ea04ba29838d"), "Morty 15", "https://comicvine1.cbsistatic.com/uploads/scale_small/6/66303/4469088-tumblr_inline_n0aleph3fl1r8rr6o.jpg" });

            migrationBuilder.InsertData(
                table: "Morties",
                columns: new[] { "id", "name", "url_image" },
                values: new object[] { new Guid("6a197ecf-2efd-4678-98cd-3bca0d9f67eb"), "Morty 10", "https://i.pinimg.com/originals/ca/fb/06/cafb06c6485985c56e9ac0e616791fae.png" });

            migrationBuilder.InsertData(
                table: "Morties",
                columns: new[] { "id", "name", "url_image" },
                values: new object[] { new Guid("ec3ba674-d7e9-4772-afef-7aef0acacca0"), "Morty 6", "https://i.pinimg.com/originals/ca/fb/06/cafb06c6485985c56e9ac0e616791fae.png" });

            migrationBuilder.InsertData(
                table: "Morties",
                columns: new[] { "id", "name", "url_image" },
                values: new object[] { new Guid("dbc620d6-0ff0-48b5-a1db-34fb2a84f511"), "Morty 8", "https://i.pinimg.com/originals/ca/fb/06/cafb06c6485985c56e9ac0e616791fae.png" });

            migrationBuilder.InsertData(
                table: "Morties",
                columns: new[] { "id", "name", "url_image" },
                values: new object[] { new Guid("fa1ff2c3-1fc9-4bb5-8046-7aba1a5a05a4"), "Morty 7", "https://comicvine1.cbsistatic.com/uploads/scale_small/6/66303/4469088-tumblr_inline_n0aleph3fl1r8rr6o.jpg" });

            migrationBuilder.InsertData(
                table: "Morties",
                columns: new[] { "id", "name", "url_image" },
                values: new object[] { new Guid("2e5be4bc-9fc9-4d14-957b-407aefd59227"), "Morty 5", "https://comicvine1.cbsistatic.com/uploads/scale_small/6/66303/4469088-tumblr_inline_n0aleph3fl1r8rr6o.jpg" });

            migrationBuilder.InsertData(
                table: "Morties",
                columns: new[] { "id", "name", "url_image" },
                values: new object[] { new Guid("c64a8114-eb19-4496-beaa-4c4013e7b73d"), "Morty 4", "https://i.pinimg.com/originals/ca/fb/06/cafb06c6485985c56e9ac0e616791fae.png" });

            migrationBuilder.InsertData(
                table: "Morties",
                columns: new[] { "id", "name", "url_image" },
                values: new object[] { new Guid("7ea16013-26e7-4eeb-954f-ad499de29bcd"), "Morty 3", "https://comicvine1.cbsistatic.com/uploads/scale_small/6/66303/4469088-tumblr_inline_n0aleph3fl1r8rr6o.jpg" });

            migrationBuilder.InsertData(
                table: "Morties",
                columns: new[] { "id", "name", "url_image" },
                values: new object[] { new Guid("707e86ad-01e1-4eed-b493-e82ca72ed0e3"), "Morty 2", "https://i.pinimg.com/originals/ca/fb/06/cafb06c6485985c56e9ac0e616791fae.png" });

            migrationBuilder.InsertData(
                table: "Morties",
                columns: new[] { "id", "name", "url_image" },
                values: new object[] { new Guid("d72aaa6a-2b39-473a-b7e9-eb2d903372b7"), "Morty 1", "https://comicvine1.cbsistatic.com/uploads/scale_small/6/66303/4469088-tumblr_inline_n0aleph3fl1r8rr6o.jpg" });

            migrationBuilder.InsertData(
                table: "Morties",
                columns: new[] { "id", "name", "url_image" },
                values: new object[] { new Guid("8fcba7bc-ea77-44b7-a64c-06c7acbb13b3"), "Morty 19", "https://comicvine1.cbsistatic.com/uploads/scale_small/6/66303/4469088-tumblr_inline_n0aleph3fl1r8rr6o.jpg" });

            migrationBuilder.InsertData(
                table: "Morties",
                columns: new[] { "id", "name", "url_image" },
                values: new object[] { new Guid("24806545-4755-49dc-8e1a-580232fa8e04"), "Morty 9", "https://comicvine1.cbsistatic.com/uploads/scale_small/6/66303/4469088-tumblr_inline_n0aleph3fl1r8rr6o.jpg" });

            migrationBuilder.InsertData(
                table: "Morties",
                columns: new[] { "id", "name", "url_image" },
                values: new object[] { new Guid("f57e4c94-53fc-45fd-bd84-14423ac48cf2"), "Morty 20", "https://i.pinimg.com/originals/ca/fb/06/cafb06c6485985c56e9ac0e616791fae.png" });

            migrationBuilder.InsertData(
                table: "Ricks",
                columns: new[] { "id", "description", "id_dimension_origin", "id_morty", "name", "registration_date", "url", "url_image" },
                values: new object[] { new Guid("5304f7be-ccf6-44c4-9289-f34f26f4b27d"), "O brilhante cientista beberrão Rick 1 sequestra o Morty 1, seu neto aborrescente, para viver loucuras em outros mundos e dimensões alternativas, o Rick 1 e o Morty 1 tem como origem a dimensão C-130.", new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("d72aaa6a-2b39-473a-b7e9-eb2d903372b7"), "Rick 1", new DateTime(2021, 4, 21, 13, 14, 2, 487, DateTimeKind.Local).AddTicks(8128), "rick-1", "https://i.pinimg.com/originals/b8/41/4d/b8414d1d7e72068a3ee64ed58044d26b.jpg" });

            migrationBuilder.InsertData(
                table: "Ricks",
                columns: new[] { "id", "description", "id_dimension_origin", "id_morty", "name", "registration_date", "url", "url_image" },
                values: new object[] { new Guid("cd28ab25-5c7f-41a5-8e09-7a117c2f31cc"), "O brilhante cientista beberrão Rick 18 sequestra o Morty 18, seu neto aborrescente, para viver loucuras em outros mundos e dimensões alternativas, o Rick 18 e o Morty 18 tem como origem a dimensão C-147.", new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("3521e6ec-f1e8-403b-8f98-1fb5c0627b6a"), "Rick 18", new DateTime(2021, 4, 21, 13, 14, 2, 489, DateTimeKind.Local).AddTicks(9791), "rick-18", "https://i.pinimg.com/originals/ac/51/52/ac5152b9f7f50781b2b01e35463fc4e6.jpg" });

            migrationBuilder.InsertData(
                table: "Ricks",
                columns: new[] { "id", "description", "id_dimension_origin", "id_morty", "name", "registration_date", "url", "url_image" },
                values: new object[] { new Guid("28ac9691-07f9-4dfc-b2b3-cf9926de06e8"), "O brilhante cientista beberrão Rick 17 sequestra o Morty 17, seu neto aborrescente, para viver loucuras em outros mundos e dimensões alternativas, o Rick 17 e o Morty 17 tem como origem a dimensão C-146.", new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("18d40939-b99d-4e55-8460-17d9012ca6fa"), "Rick 17", new DateTime(2021, 4, 21, 13, 14, 2, 489, DateTimeKind.Local).AddTicks(9753), "rick-17", "https://i.pinimg.com/originals/b8/41/4d/b8414d1d7e72068a3ee64ed58044d26b.jpg" });

            migrationBuilder.InsertData(
                table: "Ricks",
                columns: new[] { "id", "description", "id_dimension_origin", "id_morty", "name", "registration_date", "url", "url_image" },
                values: new object[] { new Guid("696fcff0-d69a-42b9-8c88-52f603b4b93e"), "O brilhante cientista beberrão Rick 16 sequestra o Morty 16, seu neto aborrescente, para viver loucuras em outros mundos e dimensões alternativas, o Rick 16 e o Morty 16 tem como origem a dimensão C-145.", new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("4ba413d2-f7de-4622-9068-3b3e22f3ff41"), "Rick 16", new DateTime(2021, 4, 21, 13, 14, 2, 489, DateTimeKind.Local).AddTicks(9712), "rick-16", "https://i.pinimg.com/originals/ac/51/52/ac5152b9f7f50781b2b01e35463fc4e6.jpg" });

            migrationBuilder.InsertData(
                table: "Ricks",
                columns: new[] { "id", "description", "id_dimension_origin", "id_morty", "name", "registration_date", "url", "url_image" },
                values: new object[] { new Guid("49901db3-556a-4397-8d60-02f4bb4f8fab"), "O brilhante cientista beberrão Rick 15 sequestra o Morty 15, seu neto aborrescente, para viver loucuras em outros mundos e dimensões alternativas, o Rick 15 e o Morty 15 tem como origem a dimensão C-144.", new Guid("8314eeb6-1a7a-4e8f-adee-4f95b1b37e1a"), new Guid("626a6c1e-c3fa-47ca-83ee-ea04ba29838d"), "Rick 15", new DateTime(2021, 4, 21, 13, 14, 2, 489, DateTimeKind.Local).AddTicks(9680), "rick-15", "https://i.pinimg.com/originals/b8/41/4d/b8414d1d7e72068a3ee64ed58044d26b.jpg" });

            migrationBuilder.InsertData(
                table: "Ricks",
                columns: new[] { "id", "description", "id_dimension_origin", "id_morty", "name", "registration_date", "url", "url_image" },
                values: new object[] { new Guid("1c7754c1-5e85-4bfe-aacb-0869501a27b2"), "O brilhante cientista beberrão Rick 14 sequestra o Morty 14, seu neto aborrescente, para viver loucuras em outros mundos e dimensões alternativas, o Rick 14 e o Morty 14 tem como origem a dimensão C-143.", new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("a5042853-2b23-4c00-bdcd-61a40918e359"), "Rick 14", new DateTime(2021, 4, 21, 13, 14, 2, 489, DateTimeKind.Local).AddTicks(9645), "rick-14", "https://i.pinimg.com/originals/ac/51/52/ac5152b9f7f50781b2b01e35463fc4e6.jpg" });

            migrationBuilder.InsertData(
                table: "Ricks",
                columns: new[] { "id", "description", "id_dimension_origin", "id_morty", "name", "registration_date", "url", "url_image" },
                values: new object[] { new Guid("996028c2-e392-465a-bfe6-bc52bac2ef61"), "O brilhante cientista beberrão Rick 13 sequestra o Morty 13, seu neto aborrescente, para viver loucuras em outros mundos e dimensões alternativas, o Rick 13 e o Morty 13 tem como origem a dimensão C-142.", new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("776be263-55bc-4b1b-95f3-45822c6e10f1"), "Rick 13", new DateTime(2021, 4, 21, 13, 14, 2, 489, DateTimeKind.Local).AddTicks(9530), "rick-13", "https://i.pinimg.com/originals/b8/41/4d/b8414d1d7e72068a3ee64ed58044d26b.jpg" });

            migrationBuilder.InsertData(
                table: "Ricks",
                columns: new[] { "id", "description", "id_dimension_origin", "id_morty", "name", "registration_date", "url", "url_image" },
                values: new object[] { new Guid("dcaa5963-22a0-4c53-9374-cfe3abf985cb"), "O brilhante cientista beberrão Rick 12 sequestra o Morty 12, seu neto aborrescente, para viver loucuras em outros mundos e dimensões alternativas, o Rick 12 e o Morty 12 tem como origem a dimensão C-141.", new Guid("8158bf46-2e3c-4790-b8fa-559f54f9bda7"), new Guid("34e0e5b6-c352-4286-9a88-f0b8a2482c20"), "Rick 12", new DateTime(2021, 4, 21, 13, 14, 2, 489, DateTimeKind.Local).AddTicks(9498), "rick-12", "https://i.pinimg.com/originals/ac/51/52/ac5152b9f7f50781b2b01e35463fc4e6.jpg" });

            migrationBuilder.InsertData(
                table: "Ricks",
                columns: new[] { "id", "description", "id_dimension_origin", "id_morty", "name", "registration_date", "url", "url_image" },
                values: new object[] { new Guid("4b13b543-027b-430c-b80c-cd48c694d2cd"), "O brilhante cientista beberrão Rick 11 sequestra o Morty 11, seu neto aborrescente, para viver loucuras em outros mundos e dimensões alternativas, o Rick 11 e o Morty 11 tem como origem a dimensão C-140.", new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("62ced4f4-2560-4896-bd5a-8ef48cecca17"), "Rick 11", new DateTime(2021, 4, 21, 13, 14, 2, 489, DateTimeKind.Local).AddTicks(9466), "rick-11", "https://i.pinimg.com/originals/b8/41/4d/b8414d1d7e72068a3ee64ed58044d26b.jpg" });

            migrationBuilder.InsertData(
                table: "Ricks",
                columns: new[] { "id", "description", "id_dimension_origin", "id_morty", "name", "registration_date", "url", "url_image" },
                values: new object[] { new Guid("973c7965-bafe-4499-a7c4-af578234baa5"), "O brilhante cientista beberrão Rick 10 sequestra o Morty 10, seu neto aborrescente, para viver loucuras em outros mundos e dimensões alternativas, o Rick 10 e o Morty 10 tem como origem a dimensão C-139.", new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("6a197ecf-2efd-4678-98cd-3bca0d9f67eb"), "Rick 10", new DateTime(2021, 4, 21, 13, 14, 2, 489, DateTimeKind.Local).AddTicks(9432), "rick-10", "https://i.pinimg.com/originals/ac/51/52/ac5152b9f7f50781b2b01e35463fc4e6.jpg" });

            migrationBuilder.InsertData(
                table: "Ricks",
                columns: new[] { "id", "description", "id_dimension_origin", "id_morty", "name", "registration_date", "url", "url_image" },
                values: new object[] { new Guid("14878ba3-9fd8-4789-8862-5f0706d30ed1"), "O brilhante cientista beberrão Rick 9 sequestra o Morty 9, seu neto aborrescente, para viver loucuras em outros mundos e dimensões alternativas, o Rick 9 e o Morty 9 tem como origem a dimensão C-138.", new Guid("3dee27e7-2a6e-4953-80c5-9b4f3a175688"), new Guid("24806545-4755-49dc-8e1a-580232fa8e04"), "Rick 9", new DateTime(2021, 4, 21, 13, 14, 2, 489, DateTimeKind.Local).AddTicks(9392), "rick-9", "https://i.pinimg.com/originals/b8/41/4d/b8414d1d7e72068a3ee64ed58044d26b.jpg" });

            migrationBuilder.InsertData(
                table: "Ricks",
                columns: new[] { "id", "description", "id_dimension_origin", "id_morty", "name", "registration_date", "url", "url_image" },
                values: new object[] { new Guid("4e7f049f-a09c-4353-aa4e-fc502bfcf10c"), "O brilhante cientista beberrão Rick 8 sequestra o Morty 8, seu neto aborrescente, para viver loucuras em outros mundos e dimensões alternativas, o Rick 8 e o Morty 8 tem como origem a dimensão C-137.", new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("dbc620d6-0ff0-48b5-a1db-34fb2a84f511"), "Rick 8", new DateTime(2021, 4, 21, 13, 14, 2, 489, DateTimeKind.Local).AddTicks(9267), "rick-8", "https://i.pinimg.com/originals/ac/51/52/ac5152b9f7f50781b2b01e35463fc4e6.jpg" });

            migrationBuilder.InsertData(
                table: "Ricks",
                columns: new[] { "id", "description", "id_dimension_origin", "id_morty", "name", "registration_date", "url", "url_image" },
                values: new object[] { new Guid("c6c033a8-364a-42c9-b54d-f7cc4b89b213"), "O brilhante cientista beberrão Rick 7 sequestra o Morty 7, seu neto aborrescente, para viver loucuras em outros mundos e dimensões alternativas, o Rick 7 e o Morty 7 tem como origem a dimensão C-136.", new Guid("4a707f05-b269-460e-abc0-4cbb511c2546"), new Guid("fa1ff2c3-1fc9-4bb5-8046-7aba1a5a05a4"), "Rick 7", new DateTime(2021, 4, 21, 13, 14, 2, 489, DateTimeKind.Local).AddTicks(9237), "rick-7", "https://i.pinimg.com/originals/b8/41/4d/b8414d1d7e72068a3ee64ed58044d26b.jpg" });

            migrationBuilder.InsertData(
                table: "Ricks",
                columns: new[] { "id", "description", "id_dimension_origin", "id_morty", "name", "registration_date", "url", "url_image" },
                values: new object[] { new Guid("66319a55-002b-4180-bbf3-0b6095a31aca"), "O brilhante cientista beberrão Rick 6 sequestra o Morty 6, seu neto aborrescente, para viver loucuras em outros mundos e dimensões alternativas, o Rick 6 e o Morty 6 tem como origem a dimensão C-135.", new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("ec3ba674-d7e9-4772-afef-7aef0acacca0"), "Rick 6", new DateTime(2021, 4, 21, 13, 14, 2, 489, DateTimeKind.Local).AddTicks(9206), "rick-6", "https://i.pinimg.com/originals/ac/51/52/ac5152b9f7f50781b2b01e35463fc4e6.jpg" });

            migrationBuilder.InsertData(
                table: "Ricks",
                columns: new[] { "id", "description", "id_dimension_origin", "id_morty", "name", "registration_date", "url", "url_image" },
                values: new object[] { new Guid("8ad33092-762c-4d08-a4d9-0596735dbec0"), "O brilhante cientista beberrão Rick 5 sequestra o Morty 5, seu neto aborrescente, para viver loucuras em outros mundos e dimensões alternativas, o Rick 5 e o Morty 5 tem como origem a dimensão C-134.", new Guid("3c09eaf7-b837-4996-b119-26a426cb8919"), new Guid("2e5be4bc-9fc9-4d14-957b-407aefd59227"), "Rick 5", new DateTime(2021, 4, 21, 13, 14, 2, 489, DateTimeKind.Local).AddTicks(9166), "rick-5", "https://i.pinimg.com/originals/b8/41/4d/b8414d1d7e72068a3ee64ed58044d26b.jpg" });

            migrationBuilder.InsertData(
                table: "Ricks",
                columns: new[] { "id", "description", "id_dimension_origin", "id_morty", "name", "registration_date", "url", "url_image" },
                values: new object[] { new Guid("31cbea4f-252c-4269-ad28-1ad03549149b"), "O brilhante cientista beberrão Rick 4 sequestra o Morty 4, seu neto aborrescente, para viver loucuras em outros mundos e dimensões alternativas, o Rick 4 e o Morty 4 tem como origem a dimensão C-133.", new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("c64a8114-eb19-4496-beaa-4c4013e7b73d"), "Rick 4", new DateTime(2021, 4, 21, 13, 14, 2, 489, DateTimeKind.Local).AddTicks(9135), "rick-4", "https://i.pinimg.com/originals/ac/51/52/ac5152b9f7f50781b2b01e35463fc4e6.jpg" });

            migrationBuilder.InsertData(
                table: "Ricks",
                columns: new[] { "id", "description", "id_dimension_origin", "id_morty", "name", "registration_date", "url", "url_image" },
                values: new object[] { new Guid("1109a910-6b51-4944-ae6d-b402eb3356a5"), "O brilhante cientista beberrão Rick 3 sequestra o Morty 3, seu neto aborrescente, para viver loucuras em outros mundos e dimensões alternativas, o Rick 3 e o Morty 3 tem como origem a dimensão C-132.", new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("7ea16013-26e7-4eeb-954f-ad499de29bcd"), "Rick 3", new DateTime(2021, 4, 21, 13, 14, 2, 489, DateTimeKind.Local).AddTicks(9098), "rick-3", "https://i.pinimg.com/originals/b8/41/4d/b8414d1d7e72068a3ee64ed58044d26b.jpg" });

            migrationBuilder.InsertData(
                table: "Ricks",
                columns: new[] { "id", "description", "id_dimension_origin", "id_morty", "name", "registration_date", "url", "url_image" },
                values: new object[] { new Guid("db9e3447-c7bb-432f-8ae7-462ed2365c7c"), "O brilhante cientista beberrão Rick 2 sequestra o Morty 2, seu neto aborrescente, para viver loucuras em outros mundos e dimensões alternativas, o Rick 2 e o Morty 2 tem como origem a dimensão C-131.", new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("707e86ad-01e1-4eed-b493-e82ca72ed0e3"), "Rick 2", new DateTime(2021, 4, 21, 13, 14, 2, 489, DateTimeKind.Local).AddTicks(8881), "rick-2", "https://i.pinimg.com/originals/ac/51/52/ac5152b9f7f50781b2b01e35463fc4e6.jpg" });

            migrationBuilder.InsertData(
                table: "Ricks",
                columns: new[] { "id", "description", "id_dimension_origin", "id_morty", "name", "registration_date", "url", "url_image" },
                values: new object[] { new Guid("bba94711-5a5a-4e8c-b612-23f5aeb3578b"), "O brilhante cientista beberrão Rick 19 sequestra o Morty 19, seu neto aborrescente, para viver loucuras em outros mundos e dimensões alternativas, o Rick 19 e o Morty 19 tem como origem a dimensão C-148.", new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("8fcba7bc-ea77-44b7-a64c-06c7acbb13b3"), "Rick 19", new DateTime(2021, 4, 21, 13, 14, 2, 489, DateTimeKind.Local).AddTicks(9826), "rick-19", "https://i.pinimg.com/originals/b8/41/4d/b8414d1d7e72068a3ee64ed58044d26b.jpg" });

            migrationBuilder.InsertData(
                table: "Ricks",
                columns: new[] { "id", "description", "id_dimension_origin", "id_morty", "name", "registration_date", "url", "url_image" },
                values: new object[] { new Guid("328966f7-336f-41eb-8304-ae4dd82296f3"), "O brilhante cientista beberrão Rick 20 sequestra o Morty 20, seu neto aborrescente, para viver loucuras em outros mundos e dimensões alternativas, o Rick 20 e o Morty 20 tem como origem a dimensão C-149.", new Guid("fd95e867-b447-4b09-9b36-42b89eb2ebf8"), new Guid("f57e4c94-53fc-45fd-bd84-14423ac48cf2"), "Rick 20", new DateTime(2021, 4, 21, 13, 14, 2, 489, DateTimeKind.Local).AddTicks(9961), "rick-20", "https://i.pinimg.com/originals/ac/51/52/ac5152b9f7f50781b2b01e35463fc4e6.jpg" });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("4884847c-28ea-45a6-a048-11eba12c6611"), null, new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("5304f7be-ccf6-44c4-9289-f34f26f4b27d"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(962) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("099a61dd-402f-4ee4-9d5a-745608304867"), new Guid("3c09eaf7-b837-4996-b119-26a426cb8919"), new Guid("3dee27e7-2a6e-4953-80c5-9b4f3a175688"), new Guid("1c7754c1-5e85-4bfe-aacb-0869501a27b2"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(8777) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("9ba2aac9-2ea6-4462-8ae4-b127690e7e7a"), new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("3c09eaf7-b837-4996-b119-26a426cb8919"), new Guid("1c7754c1-5e85-4bfe-aacb-0869501a27b2"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(8728) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("6cb81cc8-0975-494f-b51f-ddbf02b6462c"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("1c7754c1-5e85-4bfe-aacb-0869501a27b2"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(8508) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("19319bae-955c-4d58-8ef7-d0dde147e7a4"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("1c7754c1-5e85-4bfe-aacb-0869501a27b2"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(8457) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("712b96fe-8413-4b72-95da-f0755b0ac29e"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("1c7754c1-5e85-4bfe-aacb-0869501a27b2"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(8406) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("e94acd02-9693-49b8-aa94-53178bdbe9d3"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("1c7754c1-5e85-4bfe-aacb-0869501a27b2"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(8355) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("1a9176c9-f310-42ea-b2bc-88f863298b12"), new Guid("3c09eaf7-b837-4996-b119-26a426cb8919"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("1c7754c1-5e85-4bfe-aacb-0869501a27b2"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(8311) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("b7cf1449-101b-46f6-9260-e6d49108f5f3"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("3c09eaf7-b837-4996-b119-26a426cb8919"), new Guid("1c7754c1-5e85-4bfe-aacb-0869501a27b2"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(8263) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("38e9dd1c-0d47-4f41-8770-ff4fa2b6dc14"), new Guid("8314eeb6-1a7a-4e8f-adee-4f95b1b37e1a"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("1c7754c1-5e85-4bfe-aacb-0869501a27b2"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(8213) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("a0b4e427-fd6e-44cb-8935-30d01938b5e1"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("8314eeb6-1a7a-4e8f-adee-4f95b1b37e1a"), new Guid("1c7754c1-5e85-4bfe-aacb-0869501a27b2"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("66ef0a7d-f6f7-4670-ad91-973dd11855db"), null, new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("1c7754c1-5e85-4bfe-aacb-0869501a27b2"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(7947) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("f38a0bb3-fe66-43d4-842d-78a4d2cbc02f"), new Guid("4a707f05-b269-460e-abc0-4cbb511c2546"), new Guid("8314eeb6-1a7a-4e8f-adee-4f95b1b37e1a"), new Guid("996028c2-e392-465a-bfe6-bc52bac2ef61"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(7942) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("55515172-e6d6-4d72-b3d0-c985c82f12ce"), new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("4a707f05-b269-460e-abc0-4cbb511c2546"), new Guid("996028c2-e392-465a-bfe6-bc52bac2ef61"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(7887) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("1e76cde1-6be0-4f3b-b69d-1e15d2f37add"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("996028c2-e392-465a-bfe6-bc52bac2ef61"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(7794) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("5d48a69e-02de-4c6b-8405-16c583bf9fee"), new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("996028c2-e392-465a-bfe6-bc52bac2ef61"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(7747) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("620ea41d-8110-4bc5-bdb4-7a12a1f0754f"), null, new Guid("8314eeb6-1a7a-4e8f-adee-4f95b1b37e1a"), new Guid("49901db3-556a-4397-8d60-02f4bb4f8fab"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(8782) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("708085c5-1744-4607-8fd8-48b1f4056f84"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("49901db3-556a-4397-8d60-02f4bb4f8fab"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(8912) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("72885da3-af19-43ee-bbb0-080a146c645f"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("49901db3-556a-4397-8d60-02f4bb4f8fab"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(8958) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("5631bdb7-b7e6-45eb-be96-995074235bff"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("49901db3-556a-4397-8d60-02f4bb4f8fab"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(9007) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("ea45056b-060e-46a0-b420-865d4a5ad946"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("696fcff0-d69a-42b9-8c88-52f603b4b93e"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(9993) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("1c4ee63d-4bad-4d3b-93a4-d886f41675bf"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("696fcff0-d69a-42b9-8c88-52f603b4b93e"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(9944) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("adb28eb9-258a-4121-a749-988c2de0bc8b"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("696fcff0-d69a-42b9-8c88-52f603b4b93e"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(9896) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("50b1ac23-9af6-41d1-bf69-0dcf3325564d"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("696fcff0-d69a-42b9-8c88-52f603b4b93e"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(9846) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("f66e9899-5bc6-43a4-9766-88579cf8379d"), null, new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("696fcff0-d69a-42b9-8c88-52f603b4b93e"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(9636) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("e9db1340-63cd-4e1f-bf84-524049eaab12"), new Guid("3dee27e7-2a6e-4953-80c5-9b4f3a175688"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("49901db3-556a-4397-8d60-02f4bb4f8fab"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(9631) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("fb0e8562-5516-42c0-a6f5-a2006b26083d"), new Guid("4a707f05-b269-460e-abc0-4cbb511c2546"), new Guid("3dee27e7-2a6e-4953-80c5-9b4f3a175688"), new Guid("49901db3-556a-4397-8d60-02f4bb4f8fab"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(9582) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("3a61dc4a-efa5-4d9c-9abf-d1448cacf00b"), new Guid("8314eeb6-1a7a-4e8f-adee-4f95b1b37e1a"), new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("996028c2-e392-465a-bfe6-bc52bac2ef61"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(7703) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("aae8c460-f48b-4395-a198-51687755be2c"), new Guid("8314eeb6-1a7a-4e8f-adee-4f95b1b37e1a"), new Guid("4a707f05-b269-460e-abc0-4cbb511c2546"), new Guid("49901db3-556a-4397-8d60-02f4bb4f8fab"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(9533) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("62c271f5-b91c-4594-8e82-a752b156c9a6"), new Guid("8158bf46-2e3c-4790-b8fa-559f54f9bda7"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("49901db3-556a-4397-8d60-02f4bb4f8fab"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(9344) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("629977d8-44c9-4633-89ab-94c386146fe6"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("8158bf46-2e3c-4790-b8fa-559f54f9bda7"), new Guid("49901db3-556a-4397-8d60-02f4bb4f8fab"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(9297) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("86f378f0-1e8b-49a5-b80b-22a339cb81fa"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("49901db3-556a-4397-8d60-02f4bb4f8fab"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(9250) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("067291a1-19c7-45b1-9e51-a1199fe2e1f9"), new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("49901db3-556a-4397-8d60-02f4bb4f8fab"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(9202) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("33573344-4383-471c-82fa-3e134d88d4e5"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("49901db3-556a-4397-8d60-02f4bb4f8fab"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("83033f39-4f53-4459-af6b-025ee5636db1"), new Guid("8314eeb6-1a7a-4e8f-adee-4f95b1b37e1a"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("49901db3-556a-4397-8d60-02f4bb4f8fab"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("c11cb51e-40c8-404b-84ca-cc47b1ea697f"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("8314eeb6-1a7a-4e8f-adee-4f95b1b37e1a"), new Guid("49901db3-556a-4397-8d60-02f4bb4f8fab"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(9057) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("f84b9a37-d267-43c5-91f9-46a2b56ad1d4"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("8314eeb6-1a7a-4e8f-adee-4f95b1b37e1a"), new Guid("49901db3-556a-4397-8d60-02f4bb4f8fab"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(9438) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("adeed134-02d3-4829-8e5b-5853259dbf1d"), new Guid("8158bf46-2e3c-4790-b8fa-559f54f9bda7"), new Guid("8314eeb6-1a7a-4e8f-adee-4f95b1b37e1a"), new Guid("996028c2-e392-465a-bfe6-bc52bac2ef61"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(7655) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("9fb9655d-2c0b-450b-bf0a-29b9965184e8"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("8158bf46-2e3c-4790-b8fa-559f54f9bda7"), new Guid("996028c2-e392-465a-bfe6-bc52bac2ef61"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(7607) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("da2afdbf-14ac-4d0d-b485-2104d34b5356"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("996028c2-e392-465a-bfe6-bc52bac2ef61"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(7513) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("e13a152c-470f-49cf-9b25-4f0c992f13ec"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("dcaa5963-22a0-4c53-9374-cfe3abf985cb"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(6259) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("a444d744-63b5-4749-99d6-70e5f3a97981"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("dcaa5963-22a0-4c53-9374-cfe3abf985cb"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(6216) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("7a3e4096-8e27-4fe7-8877-72d6e41df361"), new Guid("3dee27e7-2a6e-4953-80c5-9b4f3a175688"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("dcaa5963-22a0-4c53-9374-cfe3abf985cb"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(6167) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("5a5cfe45-005f-43a2-bf24-da6c6c95559a"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("3dee27e7-2a6e-4953-80c5-9b4f3a175688"), new Guid("dcaa5963-22a0-4c53-9374-cfe3abf985cb"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(6120) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("0fc705c6-db7c-4304-addf-24ed09e7ec00"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("dcaa5963-22a0-4c53-9374-cfe3abf985cb"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(6070) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("f31f8845-fac7-4726-8c5c-975a898aaf0e"), new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("dcaa5963-22a0-4c53-9374-cfe3abf985cb"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(6018) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("8d3cedb3-4b6f-45a1-b206-38f176255449"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("dcaa5963-22a0-4c53-9374-cfe3abf985cb"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(5923) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("ceb0d4dc-7d66-4903-baf3-c01a14949e2f"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("dcaa5963-22a0-4c53-9374-cfe3abf985cb"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(6386) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("2066549f-0c6a-446d-b1a8-fa0ca221f8e2"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("dcaa5963-22a0-4c53-9374-cfe3abf985cb"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(5877) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("f9c08b2b-4d5d-4d7a-a44e-abcc7c60ebf0"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("4b13b543-027b-430c-b80c-cd48c694d2cd"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(5741) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("8334980e-193f-46dd-a094-9b969400064c"), new Guid("3dee27e7-2a6e-4953-80c5-9b4f3a175688"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("4b13b543-027b-430c-b80c-cd48c694d2cd"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(5693) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("2dab9732-b24a-49e3-af64-467e056cc154"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("3dee27e7-2a6e-4953-80c5-9b4f3a175688"), new Guid("4b13b543-027b-430c-b80c-cd48c694d2cd"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(5644) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("5f7a4239-9bf0-4d98-a5b2-2879e142b6e5"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("4b13b543-027b-430c-b80c-cd48c694d2cd"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("3c494964-9708-41f0-9351-9e30786ff8d0"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("4b13b543-027b-430c-b80c-cd48c694d2cd"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(5541) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("b651a2ba-1b0d-4101-bb7f-0ea2a1599367"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("4b13b543-027b-430c-b80c-cd48c694d2cd"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(5491) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("8634980f-a922-49fc-b94d-9a6156250832"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("4b13b543-027b-430c-b80c-cd48c694d2cd"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(5446) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("b2328bfa-d898-4b06-aad3-e91d906cb3fd"), null, new Guid("8158bf46-2e3c-4790-b8fa-559f54f9bda7"), new Guid("dcaa5963-22a0-4c53-9374-cfe3abf985cb"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(5746) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("90b6b915-de77-4ace-8157-0e31c3ac2365"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("8314eeb6-1a7a-4e8f-adee-4f95b1b37e1a"), new Guid("696fcff0-d69a-42b9-8c88-52f603b4b93e"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(47) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("bf74741a-c710-4306-a0b9-e034b66b83e7"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("dcaa5963-22a0-4c53-9374-cfe3abf985cb"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(6436) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("949b03cc-8077-49dd-90d9-1f92e6696e79"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("dcaa5963-22a0-4c53-9374-cfe3abf985cb"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(6534) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("fb124dd3-de56-4a35-bb9d-15049f4b4694"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("996028c2-e392-465a-bfe6-bc52bac2ef61"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(7367) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("f3c0eb2e-caf9-410d-a8ef-1332939b0863"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("996028c2-e392-465a-bfe6-bc52bac2ef61"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(7314) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("b9a12218-a0e9-4ce2-b96f-0cb38fb8a736"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("996028c2-e392-465a-bfe6-bc52bac2ef61"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(7263) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("3f865adb-020a-4556-b4b4-077da61e22d4"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("996028c2-e392-465a-bfe6-bc52bac2ef61"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(7216) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("1b16e913-4168-43cb-926d-f16aaef121fc"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("996028c2-e392-465a-bfe6-bc52bac2ef61"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(7168) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("f3fe7b59-69a5-4e98-9e1b-9fbaff4ec919"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("996028c2-e392-465a-bfe6-bc52bac2ef61"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(7122) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("894a6e5f-ccc3-4ee4-b00e-22b858ad3d92"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("996028c2-e392-465a-bfe6-bc52bac2ef61"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(7072) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("056a69bd-f9c0-40dd-8ebb-d8ef6c9e642e"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("dcaa5963-22a0-4c53-9374-cfe3abf985cb"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(6483) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("bf99becc-dbf9-4364-8686-d3c859eed70c"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("996028c2-e392-465a-bfe6-bc52bac2ef61"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("bc82000f-5353-45cc-9029-c3babd3bde60"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("3dee27e7-2a6e-4953-80c5-9b4f3a175688"), new Guid("dcaa5963-22a0-4c53-9374-cfe3abf985cb"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(6874) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("10105885-26d3-42be-9050-f72383f3cde2"), new Guid("8158bf46-2e3c-4790-b8fa-559f54f9bda7"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("dcaa5963-22a0-4c53-9374-cfe3abf985cb"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(6824) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("db052e5a-5058-44dc-9522-e0797918e33a"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("8158bf46-2e3c-4790-b8fa-559f54f9bda7"), new Guid("dcaa5963-22a0-4c53-9374-cfe3abf985cb"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(6774) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("26aa20b4-f9fd-4cb9-a1c3-6316fee27da3"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("dcaa5963-22a0-4c53-9374-cfe3abf985cb"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(6726) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("218653fc-fa45-43ea-8e91-8bb0df62e930"), new Guid("8158bf46-2e3c-4790-b8fa-559f54f9bda7"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("dcaa5963-22a0-4c53-9374-cfe3abf985cb"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(6678) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("478e62e9-142a-43be-840b-b56bd60ef180"), new Guid("4a707f05-b269-460e-abc0-4cbb511c2546"), new Guid("8158bf46-2e3c-4790-b8fa-559f54f9bda7"), new Guid("dcaa5963-22a0-4c53-9374-cfe3abf985cb"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(6632) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("3609d465-9f0e-4fea-9cb7-c401b40aa52f"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("4a707f05-b269-460e-abc0-4cbb511c2546"), new Guid("dcaa5963-22a0-4c53-9374-cfe3abf985cb"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(6583) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("de7d093f-0f1b-4fda-8ba2-e755505dea53"), null, new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("996028c2-e392-465a-bfe6-bc52bac2ef61"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(6884) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("251262a4-d88a-4fd8-b93b-150c0a1d7241"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("4b13b543-027b-430c-b80c-cd48c694d2cd"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(5398) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("7c6ea339-3894-45c4-b605-68e8895fe939"), new Guid("8314eeb6-1a7a-4e8f-adee-4f95b1b37e1a"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("696fcff0-d69a-42b9-8c88-52f603b4b93e"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(96) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("dd891770-0703-4305-a45b-d77d23cfb593"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("696fcff0-d69a-42b9-8c88-52f603b4b93e"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(193) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("343851a6-c99d-4e17-9427-0dd60fe261c4"), new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("bba94711-5a5a-4e8c-b612-23f5aeb3578b"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(3635) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("76436004-692e-4ed5-8fc1-51f3ab63cbdd"), new Guid("4a707f05-b269-460e-abc0-4cbb511c2546"), new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("bba94711-5a5a-4e8c-b612-23f5aeb3578b"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(3589) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("61228c9b-fb27-4fa1-967f-e48f7d57619e"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("4a707f05-b269-460e-abc0-4cbb511c2546"), new Guid("bba94711-5a5a-4e8c-b612-23f5aeb3578b"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(3540) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("38b81b2d-3e98-49a3-8fa5-2163d28ec447"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("bba94711-5a5a-4e8c-b612-23f5aeb3578b"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(3487) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("701f8628-df44-4b15-b14a-21c4c33fb34b"), new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("bba94711-5a5a-4e8c-b612-23f5aeb3578b"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(3440) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("cc84e2a2-2234-4752-9272-bb7b59856f31"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("bba94711-5a5a-4e8c-b612-23f5aeb3578b"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(3392) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("bbe85cd3-0cc0-4996-afc8-4f3898ded24f"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("bba94711-5a5a-4e8c-b612-23f5aeb3578b"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(3348) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("065b714e-3ced-447c-8917-3ca6c675a3a6"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("bba94711-5a5a-4e8c-b612-23f5aeb3578b"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(3300) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("26ddd6f6-2551-4c93-ad22-fe76727689dc"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("bba94711-5a5a-4e8c-b612-23f5aeb3578b"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(3253) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("5af6f9cd-c461-4472-a569-8cceeadbcd23"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("bba94711-5a5a-4e8c-b612-23f5aeb3578b"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(3205) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("2e2a0ca5-9207-4757-b1ec-2db685d32d2d"), new Guid("8158bf46-2e3c-4790-b8fa-559f54f9bda7"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("bba94711-5a5a-4e8c-b612-23f5aeb3578b"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(3160) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("93c98dc0-326f-4448-a339-73419f40c79b"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("8158bf46-2e3c-4790-b8fa-559f54f9bda7"), new Guid("bba94711-5a5a-4e8c-b612-23f5aeb3578b"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(3108) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("ca82c727-bc42-4da4-b173-350830420ca9"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("bba94711-5a5a-4e8c-b612-23f5aeb3578b"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(3059) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("94dea48e-f28b-4b64-b0c9-f05ca8c23ca6"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("bba94711-5a5a-4e8c-b612-23f5aeb3578b"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(3011) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("eb8d4b5e-086b-4efd-bed3-da93b58ab0ab"), new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("bba94711-5a5a-4e8c-b612-23f5aeb3578b"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(2959) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("14267156-4143-40ab-84e7-ebc63040dcf3"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("bba94711-5a5a-4e8c-b612-23f5aeb3578b"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(3685) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("63d28294-80b0-4b76-ac06-4ec877786c43"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("8314eeb6-1a7a-4e8f-adee-4f95b1b37e1a"), new Guid("bba94711-5a5a-4e8c-b612-23f5aeb3578b"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(3813) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("9361d357-0bec-47ee-b932-04d9d500774a"), null, new Guid("fd95e867-b447-4b09-9b36-42b89eb2ebf8"), new Guid("328966f7-336f-41eb-8304-ae4dd82296f3"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(3819) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("8df910c1-aeea-42b3-a8a5-765c3f2ad1be"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("328966f7-336f-41eb-8304-ae4dd82296f3"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(3999) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("667b2bfc-c458-4be4-8e9f-25e328997355"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("328966f7-336f-41eb-8304-ae4dd82296f3"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(4917) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("08a7f2fc-6dd5-4a6e-a264-ce6f25ce99aa"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("328966f7-336f-41eb-8304-ae4dd82296f3"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(4770) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("86db6950-961e-4c29-82e0-13d2e5daa531"), new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("328966f7-336f-41eb-8304-ae4dd82296f3"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(4722) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("baebf38e-36df-4475-a0e4-d3059f4bfef0"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("328966f7-336f-41eb-8304-ae4dd82296f3"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(4676) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("8db2b585-0100-4011-80f4-51a07b919fc3"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("328966f7-336f-41eb-8304-ae4dd82296f3"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(4627) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("e899a16c-2bef-4536-84f7-d308042e478d"), new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("328966f7-336f-41eb-8304-ae4dd82296f3"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(4579) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("d8152305-8baa-41b5-9a32-c83bf98d126c"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("328966f7-336f-41eb-8304-ae4dd82296f3"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(4531) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("ccdbdba4-a75d-4cbe-a0ca-81269eb84e7c"), null, new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("bba94711-5a5a-4e8c-b612-23f5aeb3578b"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(2821) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("f6dc3a65-eb27-4368-b573-c5f4f00f6371"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("328966f7-336f-41eb-8304-ae4dd82296f3"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(4478) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("7b81d324-e3ba-4e91-8292-eed8cb3eb856"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("328966f7-336f-41eb-8304-ae4dd82296f3"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(4381) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("d905568c-49fa-456c-8d7a-c47c9b8aef17"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("328966f7-336f-41eb-8304-ae4dd82296f3"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("cf5ef4b9-ad04-4356-ab13-8ac95939dbaf"), new Guid("4a707f05-b269-460e-abc0-4cbb511c2546"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("328966f7-336f-41eb-8304-ae4dd82296f3"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(4240) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("c2dc9cd9-5c8f-48b5-af1b-52f6d91ac197"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("4a707f05-b269-460e-abc0-4cbb511c2546"), new Guid("328966f7-336f-41eb-8304-ae4dd82296f3"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("2d60ae60-1578-43a5-b3b2-d1b18b257479"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("328966f7-336f-41eb-8304-ae4dd82296f3"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(4148) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("0a5d288a-b3c5-4d68-941e-6cf37945ad29"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("328966f7-336f-41eb-8304-ae4dd82296f3"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(4100) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("7290b2f9-a4ec-4c88-b812-c057ef2a5c28"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("328966f7-336f-41eb-8304-ae4dd82296f3"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(4046) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("48703eca-b2bf-44ea-96fb-962018f9d9b6"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("328966f7-336f-41eb-8304-ae4dd82296f3"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(4430) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("8ecfa816-c7bd-47c9-95fa-f1128d7ef5e4"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("8314eeb6-1a7a-4e8f-adee-4f95b1b37e1a"), new Guid("cd28ab25-5c7f-41a5-8e09-7a117c2f31cc"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(2817) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("36750486-2a21-495c-826a-d38269c1c505"), new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("cd28ab25-5c7f-41a5-8e09-7a117c2f31cc"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(2771) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("b77c96e5-9f3c-48e4-8a86-0fc766cce029"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("cd28ab25-5c7f-41a5-8e09-7a117c2f31cc"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("7fa9a6fe-7d2c-4c8a-96a1-09ac78b927c7"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("28ac9691-07f9-4dfc-b2b3-cf9926de06e8"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(1267) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("73e32707-eba7-4132-bdd2-556292d2d463"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("28ac9691-07f9-4dfc-b2b3-cf9926de06e8"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(1220) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("abc2fb1d-a8cf-4fa2-a07d-1d48ba7a4616"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("28ac9691-07f9-4dfc-b2b3-cf9926de06e8"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(1171) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("bc0f8575-369a-40dd-8083-8c8a428f6a96"), new Guid("8158bf46-2e3c-4790-b8fa-559f54f9bda7"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("28ac9691-07f9-4dfc-b2b3-cf9926de06e8"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(1118) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("b740ef49-2c7e-4ea2-af58-d14a04be0ebd"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("8158bf46-2e3c-4790-b8fa-559f54f9bda7"), new Guid("28ac9691-07f9-4dfc-b2b3-cf9926de06e8"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(1065) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("4da41508-b49f-4d83-ab9c-6df7542e5c0c"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("28ac9691-07f9-4dfc-b2b3-cf9926de06e8"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(1016) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("63f6afc6-2223-4e9d-a8e5-4845710aab21"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("28ac9691-07f9-4dfc-b2b3-cf9926de06e8"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(966) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("5c380178-d16f-400e-895f-a912ab2f57af"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("28ac9691-07f9-4dfc-b2b3-cf9926de06e8"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(1314) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("306deae1-a394-43e8-a829-8609da2646bd"), null, new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("28ac9691-07f9-4dfc-b2b3-cf9926de06e8"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(716) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("c2b2ac54-7944-44a5-a9d9-c2b7994e1a9c"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("696fcff0-d69a-42b9-8c88-52f603b4b93e"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(661) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("1da96249-731e-41c9-955a-53ead2309f44"), new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("696fcff0-d69a-42b9-8c88-52f603b4b93e"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(616) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("63e30df5-65c4-4a39-b3a5-1d741f52f8f5"), new Guid("8158bf46-2e3c-4790-b8fa-559f54f9bda7"), new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("696fcff0-d69a-42b9-8c88-52f603b4b93e"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(567) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("d836b650-1cb0-4b51-b7cc-baa801db5123"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("8158bf46-2e3c-4790-b8fa-559f54f9bda7"), new Guid("696fcff0-d69a-42b9-8c88-52f603b4b93e"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(513) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("9c37bcda-d162-4793-9884-2b1c8aa65709"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("696fcff0-d69a-42b9-8c88-52f603b4b93e"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(424) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("e0752dfb-ba4a-4929-8bfa-901e45998744"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("696fcff0-d69a-42b9-8c88-52f603b4b93e"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(335) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("5e4058ea-24e3-4503-bd11-aa6475088f52"), new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("696fcff0-d69a-42b9-8c88-52f603b4b93e"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(243) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("74193fe7-93b5-438b-aa7f-7ac4f1866dc1"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("3dee27e7-2a6e-4953-80c5-9b4f3a175688"), new Guid("696fcff0-d69a-42b9-8c88-52f603b4b93e"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(711) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("11d2f608-fa17-47f3-8646-73ba2386bc70"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("696fcff0-d69a-42b9-8c88-52f603b4b93e"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(146) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("550916ac-6574-48cc-9c5b-5acddfc1b22a"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("28ac9691-07f9-4dfc-b2b3-cf9926de06e8"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(1360) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("32d33cc5-21b9-4036-9cf3-27b0b56d94c0"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("28ac9691-07f9-4dfc-b2b3-cf9926de06e8"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(1593) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("f59e5077-4356-4aa0-a6ff-1dc8cca42139"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("cd28ab25-5c7f-41a5-8e09-7a117c2f31cc"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(2564) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("8eda44ac-3143-4a62-9d61-62628ace0a3d"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("cd28ab25-5c7f-41a5-8e09-7a117c2f31cc"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(2514) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("a8834d94-b8d4-44d5-892d-946dcd76b1c9"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("cd28ab25-5c7f-41a5-8e09-7a117c2f31cc"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(2464) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("0d40ab38-c140-46de-91b0-e701b222e8eb"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("cd28ab25-5c7f-41a5-8e09-7a117c2f31cc"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(2416) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("8248cb98-1c9a-4789-a9fc-5848372c4823"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("cd28ab25-5c7f-41a5-8e09-7a117c2f31cc"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(2321) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("1f6868eb-a6a6-48a1-8898-2cbb84d40d87"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("cd28ab25-5c7f-41a5-8e09-7a117c2f31cc"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(2273) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("5670c325-522b-462b-9b59-248f47979d12"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("cd28ab25-5c7f-41a5-8e09-7a117c2f31cc"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("d834ca25-a4c8-47e7-8d30-c457b6042d3c"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("28ac9691-07f9-4dfc-b2b3-cf9926de06e8"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(1541) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("1a0c125f-c7b6-4bac-bbf1-b92fae78a640"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("cd28ab25-5c7f-41a5-8e09-7a117c2f31cc"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(2173) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("d276e960-9116-4f4e-9e00-2b23f08ce77c"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("cd28ab25-5c7f-41a5-8e09-7a117c2f31cc"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(2069) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("df2cd6be-5be4-4b1b-b68c-23668ccd8425"), null, new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("cd28ab25-5c7f-41a5-8e09-7a117c2f31cc"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(1932) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("56d4307e-1b92-422b-bac5-f31ee31f32d0"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("28ac9691-07f9-4dfc-b2b3-cf9926de06e8"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(1927) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("82444cb6-96e6-41a9-8323-48fe14684129"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("28ac9691-07f9-4dfc-b2b3-cf9926de06e8"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(1835) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("92587bcc-9b39-4a58-9a4b-9482a4adeba4"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("28ac9691-07f9-4dfc-b2b3-cf9926de06e8"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(1785) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("a56fdee6-d3ef-4a16-971f-05e18511f282"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("28ac9691-07f9-4dfc-b2b3-cf9926de06e8"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(1736) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("cf7c6429-bbcd-4bbf-89f0-cb2ff96358f3"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("28ac9691-07f9-4dfc-b2b3-cf9926de06e8"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(1646) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("96918e0a-2158-4894-8199-c33a61be1a4e"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("cd28ab25-5c7f-41a5-8e09-7a117c2f31cc"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(2119) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("606bd6fb-6b3b-4afb-99ca-dc5ab324a854"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("4b13b543-027b-430c-b80c-cd48c694d2cd"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(5349) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("443d2623-8767-4fcb-85c0-297b6abb9955"), new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("4b13b543-027b-430c-b80c-cd48c694d2cd"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(5147) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("a9ae539b-3591-4aae-ac70-230ccc017f4b"), null, new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("4b13b543-027b-430c-b80c-cd48c694d2cd"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(5006) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("144c629b-f1c6-422e-a112-2cb68534ace0"), new Guid("3c09eaf7-b837-4996-b119-26a426cb8919"), new Guid("8158bf46-2e3c-4790-b8fa-559f54f9bda7"), new Guid("31cbea4f-252c-4269-ad28-1ad03549149b"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(9087) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("43ca6d99-56e3-47c6-be9e-35c75fa9f326"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("3c09eaf7-b837-4996-b119-26a426cb8919"), new Guid("31cbea4f-252c-4269-ad28-1ad03549149b"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("ac92a11f-c4be-42c7-ba22-be8d3d3676ae"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("31cbea4f-252c-4269-ad28-1ad03549149b"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(8991) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("feeaead8-a41c-4786-9f83-85c34336197b"), new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("31cbea4f-252c-4269-ad28-1ad03549149b"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(8943) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("c9a4cd53-ed6d-4cde-88f5-152c21a7046b"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("31cbea4f-252c-4269-ad28-1ad03549149b"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(8892) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("469b3bde-97cd-460c-95ad-1f82681ffc3d"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("31cbea4f-252c-4269-ad28-1ad03549149b"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(8835) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("e22aae79-f9f9-4048-b2f3-3b365e9f77cd"), new Guid("3c09eaf7-b837-4996-b119-26a426cb8919"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("31cbea4f-252c-4269-ad28-1ad03549149b"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(8785) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("c2105e20-9d42-4c8a-9935-01e489f49666"), new Guid("4a707f05-b269-460e-abc0-4cbb511c2546"), new Guid("3c09eaf7-b837-4996-b119-26a426cb8919"), new Guid("31cbea4f-252c-4269-ad28-1ad03549149b"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("e6f851cc-c0c3-4e44-a281-af608308ff33"), null, new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("31cbea4f-252c-4269-ad28-1ad03549149b"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(8512) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("59ee836c-c21b-452d-a0eb-9b85dad5b8e6"), new Guid("3c09eaf7-b837-4996-b119-26a426cb8919"), new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("1109a910-6b51-4944-ae6d-b402eb3356a5"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(8506) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("39fee5e1-d803-482f-9b88-43792ab2f6cc"), new Guid("8314eeb6-1a7a-4e8f-adee-4f95b1b37e1a"), new Guid("3c09eaf7-b837-4996-b119-26a426cb8919"), new Guid("1109a910-6b51-4944-ae6d-b402eb3356a5"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(8454) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("d9de4f36-b5f4-47f9-8755-7e259f64afed"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("8314eeb6-1a7a-4e8f-adee-4f95b1b37e1a"), new Guid("1109a910-6b51-4944-ae6d-b402eb3356a5"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(8405) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("91e152c9-e63f-4580-9acf-cfcea7fe516c"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("1109a910-6b51-4944-ae6d-b402eb3356a5"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(8354) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("48c35dea-152a-4177-b342-3cd42cf54ecf"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("1109a910-6b51-4944-ae6d-b402eb3356a5"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(8272) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("11d7887c-69f0-4a4c-9bf9-b02601d1b7cb"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("1109a910-6b51-4944-ae6d-b402eb3356a5"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(8224) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("2295ebb4-73d9-4aba-abe8-3b8fff0016f1"), new Guid("8158bf46-2e3c-4790-b8fa-559f54f9bda7"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("31cbea4f-252c-4269-ad28-1ad03549149b"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(9137) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("0d5e5add-7a1a-4af1-8b7c-82001febb22e"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("31cbea4f-252c-4269-ad28-1ad03549149b"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(9188) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("63796b0c-01fb-45af-a49e-479f6ecdb913"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("4a707f05-b269-460e-abc0-4cbb511c2546"), new Guid("31cbea4f-252c-4269-ad28-1ad03549149b"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(9235) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("ce80c4c7-1dac-4e87-baef-2148a8ab0183"), new Guid("4a707f05-b269-460e-abc0-4cbb511c2546"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("31cbea4f-252c-4269-ad28-1ad03549149b"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(9291) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("6abacfe4-e5aa-4055-b36b-0f214037ecc1"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("8314eeb6-1a7a-4e8f-adee-4f95b1b37e1a"), new Guid("8ad33092-762c-4d08-a4d9-0596735dbec0"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("723af244-83ae-4bbc-8094-ffcf06b0d2bf"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("8ad33092-762c-4d08-a4d9-0596735dbec0"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(215) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("a2d73b8d-8bcd-4fe2-80b7-985d74a6e630"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("8ad33092-762c-4d08-a4d9-0596735dbec0"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(167) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("c1d35e62-5b5f-4b2c-9b97-efa7ce357558"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("8ad33092-762c-4d08-a4d9-0596735dbec0"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(118) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("8c531647-2c14-42e2-ac0c-344ec1fdb18f"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("8ad33092-762c-4d08-a4d9-0596735dbec0"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(68) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("e61f4f29-7b3d-4777-b2ef-db87de252ff9"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("8ad33092-762c-4d08-a4d9-0596735dbec0"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(21) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("3d947370-d15c-42ae-b3e0-7da3c642be4a"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("8ad33092-762c-4d08-a4d9-0596735dbec0"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(9973) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("0d0e237d-d5a3-4e2d-9ba8-e1d7d27619d2"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("1109a910-6b51-4944-ae6d-b402eb3356a5"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(8177) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("2a9d0b37-d64d-4364-ab70-57ac9e03975b"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("8ad33092-762c-4d08-a4d9-0596735dbec0"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(9923) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("c323c179-ecd2-4b6d-a81a-c1d107f7d862"), new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("4a707f05-b269-460e-abc0-4cbb511c2546"), new Guid("8ad33092-762c-4d08-a4d9-0596735dbec0"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(9819) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("2fca44d6-2125-4c8a-a5a7-1fe99e08fc90"), null, new Guid("3c09eaf7-b837-4996-b119-26a426cb8919"), new Guid("8ad33092-762c-4d08-a4d9-0596735dbec0"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(9545) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("882296bb-f8b5-47ff-bbac-e4e388d74208"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("3dee27e7-2a6e-4953-80c5-9b4f3a175688"), new Guid("31cbea4f-252c-4269-ad28-1ad03549149b"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(9536) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("7af931de-357f-4b8b-90b7-92f4a2791502"), new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("31cbea4f-252c-4269-ad28-1ad03549149b"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(9487) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("2f4a5a97-56fe-4d83-a388-47661371d0bd"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("31cbea4f-252c-4269-ad28-1ad03549149b"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(9439) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("5b0e8de7-25af-48b7-b80c-ba111f4d39a5"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("31cbea4f-252c-4269-ad28-1ad03549149b"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(9388) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("24b45e66-57d2-4487-ab2b-d47b5e57185c"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("31cbea4f-252c-4269-ad28-1ad03549149b"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(9339) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("ecc9bcfb-d5dd-49e3-87ee-d5316b72895b"), new Guid("4a707f05-b269-460e-abc0-4cbb511c2546"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("8ad33092-762c-4d08-a4d9-0596735dbec0"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(9874) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("9d976461-a3cd-4a0a-b787-3ff65300c2ae"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("1109a910-6b51-4944-ae6d-b402eb3356a5"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(8126) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("122818d6-3798-4804-ac38-fda8d0d12754"), new Guid("3c09eaf7-b837-4996-b119-26a426cb8919"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("1109a910-6b51-4944-ae6d-b402eb3356a5"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(8075) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("1e4286f5-60ea-4689-88e8-bdb376d8852f"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("3c09eaf7-b837-4996-b119-26a426cb8919"), new Guid("1109a910-6b51-4944-ae6d-b402eb3356a5"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(8025) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("6c4114cd-af0e-4285-8c96-f4936a3a4c83"), new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("db9e3447-c7bb-432f-8ae7-462ed2365c7c"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(6716) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("4bf65ac6-27da-4fb4-897a-f8402d7a561b"), new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("db9e3447-c7bb-432f-8ae7-462ed2365c7c"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(6666) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("1cc680fa-6015-4bb7-903d-b576f40c9f2d"), null, new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("db9e3447-c7bb-432f-8ae7-462ed2365c7c"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(6525) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("f87d5250-0309-48ce-af5b-bae5e7301cf0"), new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("8158bf46-2e3c-4790-b8fa-559f54f9bda7"), new Guid("5304f7be-ccf6-44c4-9289-f34f26f4b27d"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(6519) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("edc09341-aba5-4de4-9aab-edb43db2b6dd"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("5304f7be-ccf6-44c4-9289-f34f26f4b27d"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(6466) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("ddf7197e-d644-4db8-9453-ae6f4fb03f97"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("5304f7be-ccf6-44c4-9289-f34f26f4b27d"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(6303) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("bc070ab8-eb21-4f10-a84f-23052ab2cafd"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("5304f7be-ccf6-44c4-9289-f34f26f4b27d"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(6245) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("2f3bf3b7-aedb-498e-a472-301a78bdb90a"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("8314eeb6-1a7a-4e8f-adee-4f95b1b37e1a"), new Guid("db9e3447-c7bb-432f-8ae7-462ed2365c7c"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(6767) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("de1fc657-0ad0-4d0d-aa14-ebd5f6e4041b"), new Guid("8314eeb6-1a7a-4e8f-adee-4f95b1b37e1a"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("5304f7be-ccf6-44c4-9289-f34f26f4b27d"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(6193) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("1b11ca78-1fdb-42ee-95fe-6eb68ee94528"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("5304f7be-ccf6-44c4-9289-f34f26f4b27d"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(6088) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("e95f1bd1-6a69-459a-a3f8-1433a65a9978"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("5304f7be-ccf6-44c4-9289-f34f26f4b27d"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(6038) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("c683e739-5a3d-4017-b7f9-b68bd81dc290"), new Guid("8314eeb6-1a7a-4e8f-adee-4f95b1b37e1a"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("5304f7be-ccf6-44c4-9289-f34f26f4b27d"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(5986) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("b02125dc-38c5-4537-8aa1-4cdb51894123"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("8314eeb6-1a7a-4e8f-adee-4f95b1b37e1a"), new Guid("5304f7be-ccf6-44c4-9289-f34f26f4b27d"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(5910) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("0d3410c4-a140-47c6-a46d-811ca37c8fe5"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("5304f7be-ccf6-44c4-9289-f34f26f4b27d"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(5806) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("0aa92a68-9fe8-43d2-9fe8-018647eba7e3"), new Guid("3c09eaf7-b837-4996-b119-26a426cb8919"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("5304f7be-ccf6-44c4-9289-f34f26f4b27d"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(5734) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("18d9131a-f408-4a88-a154-1ec29281d1db"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("3c09eaf7-b837-4996-b119-26a426cb8919"), new Guid("5304f7be-ccf6-44c4-9289-f34f26f4b27d"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(5349) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("52d7435b-aa28-4e7b-a2c4-8fff041abb64"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("8314eeb6-1a7a-4e8f-adee-4f95b1b37e1a"), new Guid("5304f7be-ccf6-44c4-9289-f34f26f4b27d"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(6138) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("53266519-fd86-4bad-8f8a-6828bb1ad0d0"), new Guid("8314eeb6-1a7a-4e8f-adee-4f95b1b37e1a"), new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("8ad33092-762c-4d08-a4d9-0596735dbec0"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(315) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("262d6477-129d-4d69-b7a3-e33603966603"), new Guid("8314eeb6-1a7a-4e8f-adee-4f95b1b37e1a"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("db9e3447-c7bb-432f-8ae7-462ed2365c7c"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(6817) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("b84e2ec3-3c75-4c0a-a5ae-c038d32e6678"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("db9e3447-c7bb-432f-8ae7-462ed2365c7c"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(6921) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("41cd1c84-4851-4871-84d7-49c49f0ad1fb"), new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("1109a910-6b51-4944-ae6d-b402eb3356a5"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(7976) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("f35a8205-6a13-46a5-914e-2f4ba380aa0f"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("1109a910-6b51-4944-ae6d-b402eb3356a5"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(7927) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("66b52807-ba51-4efb-96fc-683ab3c7159b"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("1109a910-6b51-4944-ae6d-b402eb3356a5"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(7823) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("0c993c72-1fe3-46d8-86bc-f9dba050c6da"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("1109a910-6b51-4944-ae6d-b402eb3356a5"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(7773) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("85697b84-5541-46cd-911f-5e0b33970d1f"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("1109a910-6b51-4944-ae6d-b402eb3356a5"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(7720) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("64ba4b63-ee98-4f99-9f4d-14b1bef1cef5"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("1109a910-6b51-4944-ae6d-b402eb3356a5"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(7665) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("39268db8-5f8f-4484-aace-fc21067d857b"), null, new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("1109a910-6b51-4944-ae6d-b402eb3356a5"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(7380) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("599e564e-c81b-42ac-926f-04594b4c1b97"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("db9e3447-c7bb-432f-8ae7-462ed2365c7c"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(6871) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("c24bdc0a-1a01-4f51-a669-dd2467c5824e"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("db9e3447-c7bb-432f-8ae7-462ed2365c7c"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("ca04f62e-b475-411c-87f2-570afd6b94ed"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("db9e3447-c7bb-432f-8ae7-462ed2365c7c"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(7276) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("fa35c6ae-20c2-4d6f-9c3c-1bebc040f758"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("db9e3447-c7bb-432f-8ae7-462ed2365c7c"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(7220) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("daaaf66e-25ea-4b67-8917-c6397d3d0443"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("db9e3447-c7bb-432f-8ae7-462ed2365c7c"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(7172) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("304e1c20-a151-46e7-8e50-014ea8439dfe"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("db9e3447-c7bb-432f-8ae7-462ed2365c7c"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(7122) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("97714d79-9208-42a2-a7ba-a4fa84ba781c"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("db9e3447-c7bb-432f-8ae7-462ed2365c7c"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(7072) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("9c2a58fc-469b-4efa-b088-986b7165d569"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("db9e3447-c7bb-432f-8ae7-462ed2365c7c"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(7023) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("e556114a-a719-4678-8815-60b0e9c8affb"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("db9e3447-c7bb-432f-8ae7-462ed2365c7c"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("0c58ace7-3d47-4406-b810-3b0129a85206"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("db9e3447-c7bb-432f-8ae7-462ed2365c7c"), new DateTime(2021, 4, 21, 13, 14, 2, 492, DateTimeKind.Local).AddTicks(7325) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("7a75ee3a-bdab-4455-ac69-f4b115c8492c"), new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("3c09eaf7-b837-4996-b119-26a426cb8919"), new Guid("8ad33092-762c-4d08-a4d9-0596735dbec0"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(363) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("be30ac67-d3fe-45c6-a6d6-547ef991bd70"), null, new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("66319a55-002b-4180-bbf3-0b6095a31aca"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(370) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("1eba7e88-94a0-411b-982f-51dbb09f637b"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("66319a55-002b-4180-bbf3-0b6095a31aca"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(508) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("3cb14c8e-48e0-46e2-9656-0b86d674249c"), new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("14878ba3-9fd8-4789-8862-5f0706d30ed1"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(3729) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("f128c5a8-ad28-4e7c-a414-57ba091fc1a6"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("14878ba3-9fd8-4789-8862-5f0706d30ed1"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(3680) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("2218fcec-6146-4f43-948f-3455803acd40"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("14878ba3-9fd8-4789-8862-5f0706d30ed1"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("0b7640f2-5713-4644-9fcf-a55a6e7e3726"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("14878ba3-9fd8-4789-8862-5f0706d30ed1"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(3581) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("4ca16a70-1541-4d80-9681-1268ac2fd9b2"), new Guid("8158bf46-2e3c-4790-b8fa-559f54f9bda7"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("14878ba3-9fd8-4789-8862-5f0706d30ed1"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(3532) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("2d636da9-a5e7-445c-b518-f59fa4a300d2"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("8158bf46-2e3c-4790-b8fa-559f54f9bda7"), new Guid("14878ba3-9fd8-4789-8862-5f0706d30ed1"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(3480) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("440555f6-10cb-4010-8718-e8e5e1727835"), new Guid("3c09eaf7-b837-4996-b119-26a426cb8919"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("14878ba3-9fd8-4789-8862-5f0706d30ed1"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(3431) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("011f64f5-3757-4398-b7a9-32161114d6b2"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("14878ba3-9fd8-4789-8862-5f0706d30ed1"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(3778) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("68357724-553e-4851-9419-c3e0275a9a2b"), new Guid("3dee27e7-2a6e-4953-80c5-9b4f3a175688"), new Guid("3c09eaf7-b837-4996-b119-26a426cb8919"), new Guid("14878ba3-9fd8-4789-8862-5f0706d30ed1"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(3374) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("2be60f3b-26d6-4180-a107-d4b79aafc38c"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("4e7f049f-a09c-4353-aa4e-fc502bfcf10c"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("e47fce21-6fc8-4c3e-a0e5-7a698dd17dc3"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("4e7f049f-a09c-4353-aa4e-fc502bfcf10c"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(3181) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("5647c146-e34a-4802-b15c-964309ec8ca8"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("4e7f049f-a09c-4353-aa4e-fc502bfcf10c"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(3056) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("8661e963-f33a-4447-84b7-ab4316745e8c"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("4e7f049f-a09c-4353-aa4e-fc502bfcf10c"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(2987) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("475b7a6c-f56c-4428-b502-6a13004e0afb"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("4e7f049f-a09c-4353-aa4e-fc502bfcf10c"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(2935) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("581a96e9-bf4d-4e61-91fb-184a8fca5bd7"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("4e7f049f-a09c-4353-aa4e-fc502bfcf10c"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(2886) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("8c3339f9-a26e-4a82-a239-3148e3a42fa3"), new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("4e7f049f-a09c-4353-aa4e-fc502bfcf10c"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(2838) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("3841527d-c558-461f-a1b7-336667b094c5"), null, new Guid("3dee27e7-2a6e-4953-80c5-9b4f3a175688"), new Guid("14878ba3-9fd8-4789-8862-5f0706d30ed1"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(3236) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("0cfac09f-663c-4abb-afb7-490e9891c1ad"), new Guid("3dee27e7-2a6e-4953-80c5-9b4f3a175688"), new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("4e7f049f-a09c-4353-aa4e-fc502bfcf10c"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(2789) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("5c483b39-2437-49f8-90a8-3cfc93bb7828"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("14878ba3-9fd8-4789-8862-5f0706d30ed1"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(3829) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("63bffebc-91c7-4aa7-a8c9-fa7b1e5778c6"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("973c7965-bafe-4499-a7c4-af578234baa5"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(4173) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("76c68ed3-3741-4c55-96a8-ffb49bfce99b"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("3dee27e7-2a6e-4953-80c5-9b4f3a175688"), new Guid("973c7965-bafe-4499-a7c4-af578234baa5"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(5000) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("bee13c89-4926-445e-a711-80abc01596ee"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("973c7965-bafe-4499-a7c4-af578234baa5"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(4947) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("eaba41c4-3d7d-47b0-aed8-d1bd9e726101"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("973c7965-bafe-4499-a7c4-af578234baa5"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(4902) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("a0778d90-8acc-48a9-bc84-07b9d6000068"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("973c7965-bafe-4499-a7c4-af578234baa5"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("587c0228-6783-4538-a83c-9b16a90132a3"), new Guid("3dee27e7-2a6e-4953-80c5-9b4f3a175688"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("973c7965-bafe-4499-a7c4-af578234baa5"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("0cb31f68-7c97-4cf9-a6e4-e7d1d56d55f7"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("3dee27e7-2a6e-4953-80c5-9b4f3a175688"), new Guid("973c7965-bafe-4499-a7c4-af578234baa5"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(4756) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("d3c55062-dd63-496f-bbc7-41efd6025411"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("973c7965-bafe-4499-a7c4-af578234baa5"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(4708) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("dfad8d58-19d9-4beb-9ba3-ee60960a297e"), null, new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("973c7965-bafe-4499-a7c4-af578234baa5"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(3834) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("f6455d36-bf33-46ee-a0b0-a398380f1eed"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("973c7965-bafe-4499-a7c4-af578234baa5"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("ceaf60c0-8e57-4b6f-a737-52eea25f3821"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("973c7965-bafe-4499-a7c4-af578234baa5"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(4560) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("6647ddf8-f320-43e7-af02-2bf5c6cc32cd"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("973c7965-bafe-4499-a7c4-af578234baa5"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("f89e5a2d-d0af-4b4d-9d88-49b2906ebf11"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("973c7965-bafe-4499-a7c4-af578234baa5"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(4424) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("0bd97a66-def0-449b-a509-d9703a024fd6"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("973c7965-bafe-4499-a7c4-af578234baa5"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(4374) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("0cd85123-0ff0-49b4-ad5b-48f0fb4b59d2"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("973c7965-bafe-4499-a7c4-af578234baa5"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(4323) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("52a44be3-61bb-45f3-909e-3149c5e46587"), new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("973c7965-bafe-4499-a7c4-af578234baa5"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(4273) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("734ec257-73c5-4341-bb5e-a6c11ed7f79b"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("973c7965-bafe-4499-a7c4-af578234baa5"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(4224) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("984ed5f8-da11-4803-9a00-28ad31953ae7"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("973c7965-bafe-4499-a7c4-af578234baa5"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(4613) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("9cbb5172-3b1d-4143-98d0-a5008cc1637d"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("328966f7-336f-41eb-8304-ae4dd82296f3"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(5009) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("74937be3-55c2-4361-8b1f-60e719e87472"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("3dee27e7-2a6e-4953-80c5-9b4f3a175688"), new Guid("4e7f049f-a09c-4353-aa4e-fc502bfcf10c"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(2741) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("4bddd6d9-f1b0-49a8-9d06-23bd52ce2bcc"), new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("4e7f049f-a09c-4353-aa4e-fc502bfcf10c"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(2645) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("8e0e683f-c9e1-4d02-bdff-52dbdabcd5b6"), new Guid("3dee27e7-2a6e-4953-80c5-9b4f3a175688"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("c6c033a8-364a-42c9-b54d-f7cc4b89b213"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(1489) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("3f195e32-f4d8-4f1e-98fe-1068fa9a0d8f"), new Guid("8158bf46-2e3c-4790-b8fa-559f54f9bda7"), new Guid("3dee27e7-2a6e-4953-80c5-9b4f3a175688"), new Guid("c6c033a8-364a-42c9-b54d-f7cc4b89b213"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(1439) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("19a570e9-4ac4-44fe-9157-e7cec37dc345"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("8158bf46-2e3c-4790-b8fa-559f54f9bda7"), new Guid("c6c033a8-364a-42c9-b54d-f7cc4b89b213"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(1390) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("fce82f59-8312-4c41-8259-e899fc67807c"), null, new Guid("4a707f05-b269-460e-abc0-4cbb511c2546"), new Guid("c6c033a8-364a-42c9-b54d-f7cc4b89b213"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(1259) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("d6c6f29a-4a65-4f86-a09b-17302e6eae60"), new Guid("4a707f05-b269-460e-abc0-4cbb511c2546"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("66319a55-002b-4180-bbf3-0b6095a31aca"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(1253) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("99077542-86d5-4e77-8ce4-469b90369086"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("4a707f05-b269-460e-abc0-4cbb511c2546"), new Guid("66319a55-002b-4180-bbf3-0b6095a31aca"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(1201) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("8e538686-9c39-4add-ac23-6436e0910a33"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("ab55ec51-6785-45ff-91ab-b2ec2df1d3a5"), new Guid("66319a55-002b-4180-bbf3-0b6095a31aca"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(1152) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("4c5fd680-4d3e-49a5-a8af-970f6cfa7ff7"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("c6c033a8-364a-42c9-b54d-f7cc4b89b213"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(1539) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("35c15388-f0a4-4f21-ace6-934cf0fae525"), new Guid("3dee27e7-2a6e-4953-80c5-9b4f3a175688"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("66319a55-002b-4180-bbf3-0b6095a31aca"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(1104) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("0c8e4b27-2352-48d4-b28a-6a7be712536a"), new Guid("3dee27e7-2a6e-4953-80c5-9b4f3a175688"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("66319a55-002b-4180-bbf3-0b6095a31aca"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(948) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("74eeba74-d8b1-4e30-bb81-1cf81203f7a5"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("3dee27e7-2a6e-4953-80c5-9b4f3a175688"), new Guid("66319a55-002b-4180-bbf3-0b6095a31aca"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(899) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("1cbd3455-5ddd-4607-8f65-3ffd2bdb233a"), new Guid("4a707f05-b269-460e-abc0-4cbb511c2546"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("66319a55-002b-4180-bbf3-0b6095a31aca"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(747) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("ab306fe0-e0f8-4c44-8d6f-86d7be8f32f3"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("4a707f05-b269-460e-abc0-4cbb511c2546"), new Guid("66319a55-002b-4180-bbf3-0b6095a31aca"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(700) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("60654b70-2401-4088-bd64-e76185ca464a"), new Guid("4a707f05-b269-460e-abc0-4cbb511c2546"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("66319a55-002b-4180-bbf3-0b6095a31aca"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(648) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("453f026d-bd43-4185-a057-185fa4477716"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("4a707f05-b269-460e-abc0-4cbb511c2546"), new Guid("66319a55-002b-4180-bbf3-0b6095a31aca"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(601) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("982a7bbd-2073-481f-ad7a-3eca1c076e7c"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("66319a55-002b-4180-bbf3-0b6095a31aca"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(554) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("e073a07b-4c36-47b8-a8f5-df6753b745af"), new Guid("e9ecff59-950b-4665-8a67-5f61ab86b9e6"), new Guid("3dee27e7-2a6e-4953-80c5-9b4f3a175688"), new Guid("66319a55-002b-4180-bbf3-0b6095a31aca"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(998) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("5a8e14e1-1ded-4e75-befa-8890570ba9dc"), new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("4e7f049f-a09c-4353-aa4e-fc502bfcf10c"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(2694) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("1fae7f76-0297-41d8-84c2-88476efd42ae"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("3c09eaf7-b837-4996-b119-26a426cb8919"), new Guid("c6c033a8-364a-42c9-b54d-f7cc4b89b213"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(1587) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("ba93c983-675b-4942-a509-3abc8347d2c0"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("c6c033a8-364a-42c9-b54d-f7cc4b89b213"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(1685) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("57669812-edf5-4c75-8c0a-a800c9c2921b"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("4c5866eb-6b5c-48d5-af64-fa2bc2ebcf73"), new Guid("4e7f049f-a09c-4353-aa4e-fc502bfcf10c"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("8cb23b3c-199f-4ef0-aff4-0edac19da52a"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("4e7f049f-a09c-4353-aa4e-fc502bfcf10c"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(2546) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("06e7fd54-25c2-4542-89e2-b078b326e167"), new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("57ff91cc-9a1f-45fb-a112-9c045a13116d"), new Guid("4e7f049f-a09c-4353-aa4e-fc502bfcf10c"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(2495) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("1a700b01-dad3-478c-935b-6b6be4aa10d4"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("4e7f049f-a09c-4353-aa4e-fc502bfcf10c"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(2443) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("0049e569-2dbb-4555-b7d8-d47264965a24"), new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("de0c10f1-292b-4f0a-8e4d-ab9da74e0aed"), new Guid("4e7f049f-a09c-4353-aa4e-fc502bfcf10c"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(2397) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("b8c4ec21-6807-49d8-9c19-747f4fc313b0"), null, new Guid("d93ed3e6-2f18-4457-b39c-408833e563aa"), new Guid("4e7f049f-a09c-4353-aa4e-fc502bfcf10c"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(2262) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("f98b50a8-41b3-4247-b4a1-3217d631d61d"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("3dee27e7-2a6e-4953-80c5-9b4f3a175688"), new Guid("c6c033a8-364a-42c9-b54d-f7cc4b89b213"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(2257) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("8b821945-45ad-44d1-9268-7dbfbe39ddbf"), new Guid("3c09eaf7-b837-4996-b119-26a426cb8919"), new Guid("c8d69914-12c5-44e6-8006-692aeac2f543"), new Guid("c6c033a8-364a-42c9-b54d-f7cc4b89b213"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(1631) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("f576fddf-4e03-409d-88db-132de0f8860a"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("c6c033a8-364a-42c9-b54d-f7cc4b89b213"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(2208) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("857c9a42-8445-4c98-8bd5-f55cc2eb9537"), new Guid("4a707f05-b269-460e-abc0-4cbb511c2546"), new Guid("8158bf46-2e3c-4790-b8fa-559f54f9bda7"), new Guid("c6c033a8-364a-42c9-b54d-f7cc4b89b213"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(2109) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("de1afe16-5e2b-4915-8a29-27aadaeafd21"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("4a707f05-b269-460e-abc0-4cbb511c2546"), new Guid("c6c033a8-364a-42c9-b54d-f7cc4b89b213"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(2058) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("7e80bcae-6429-4d1a-9886-584434f01803"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("2fd4afce-3ba9-4d09-a7fe-d19e0cb5c25a"), new Guid("c6c033a8-364a-42c9-b54d-f7cc4b89b213"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(1932) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("18471e8c-800b-4520-8081-38aeff2c2826"), new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("e3d18007-c31c-4040-8679-a5b74e9ccb4e"), new Guid("c6c033a8-364a-42c9-b54d-f7cc4b89b213"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(1883) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("b07a88f8-2d5d-46bf-8cd3-e8070d357b68"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("f42c05f9-5544-498d-8898-9117c8470f0b"), new Guid("c6c033a8-364a-42c9-b54d-f7cc4b89b213"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(1834) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("6b06c0f1-3461-46dd-ac50-807a454d4583"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("00f7810b-a60b-43ae-816a-7fb6c72c7f31"), new Guid("c6c033a8-364a-42c9-b54d-f7cc4b89b213"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(1785) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("4d3e9b1e-61c0-4ad9-921f-78c4191a8137"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("c6c033a8-364a-42c9-b54d-f7cc4b89b213"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(1733) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("ecdf63b9-27ec-4f2c-990e-9d53acb810d5"), new Guid("8158bf46-2e3c-4790-b8fa-559f54f9bda7"), new Guid("9231362b-108f-427b-a06a-a4f1500f1a42"), new Guid("c6c033a8-364a-42c9-b54d-f7cc4b89b213"), new DateTime(2021, 4, 21, 13, 14, 2, 493, DateTimeKind.Local).AddTicks(2160) });

            migrationBuilder.InsertData(
                table: "DimensionsTravelled",
                columns: new[] { "id", "id_dimension_before", "id_dimension_current", "id_rick", "registration_date" },
                values: new object[] { new Guid("d08701e1-280b-4d65-ab2e-c68d83c6095b"), new Guid("66625b35-7a34-4414-8972-dcdfb92a151c"), new Guid("abcde5e4-7b09-472d-8bcf-9feac99a2197"), new Guid("328966f7-336f-41eb-8304-ae4dd82296f3"), new DateTime(2021, 4, 21, 13, 14, 2, 494, DateTimeKind.Local).AddTicks(5062) });

            migrationBuilder.CreateIndex(
                name: "IX_Dimensions_name",
                table: "Dimensions",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DimensionsTravelled_id_dimension_before",
                table: "DimensionsTravelled",
                column: "id_dimension_before");

            migrationBuilder.CreateIndex(
                name: "IX_DimensionsTravelled_id_dimension_current",
                table: "DimensionsTravelled",
                column: "id_dimension_current");

            migrationBuilder.CreateIndex(
                name: "IX_DimensionsTravelled_id_rick",
                table: "DimensionsTravelled",
                column: "id_rick");

            migrationBuilder.CreateIndex(
                name: "IX_Morties_name",
                table: "Morties",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ricks_id_dimension_origin",
                table: "Ricks",
                column: "id_dimension_origin",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ricks_id_morty",
                table: "Ricks",
                column: "id_morty",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ricks_name",
                table: "Ricks",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ricks_url",
                table: "Ricks",
                column: "url",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DimensionsTravelled");

            migrationBuilder.DropTable(
                name: "Ricks");

            migrationBuilder.DropTable(
                name: "Dimensions");

            migrationBuilder.DropTable(
                name: "Morties");
        }
    }
}
