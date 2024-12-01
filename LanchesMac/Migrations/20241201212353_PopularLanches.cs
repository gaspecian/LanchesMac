using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    /// <inheritdoc />
    public partial class PopularLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) VALUES (1, 'Pão, hambúrguer, ovo, presunto, queijo e batata palha1', 'Delicioso pão de hambúrguer com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha', 1, 'https://www.macoratti.net/Imagens/lanches/cheesesalad1.jpg', 'https://www.macoratti.net/Imagens/lanches/cheesesalad1.jpg', 0, 'Cheese Salada', 12.50)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) VALUES (1, 'Pão, hambúrguer, ovo, presunto, queijo e batata palha1', 'Delicioso pão de hambúrguer com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha', 1, 'https://www.macoratti.net/Imagens/lanches/mistoquente4.jpg', 'https://www.macoratti.net/Imagens/lanches/mistoquente4.jpg', 0, 'Misto Quente', 8.00)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) VALUES (1, 'Pão, hambúrguer, ovo, presunto, queijo e batata palha1', 'Delicioso pão de hambúrguer com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha', 1, 'https://www.macoratti.net/Imagens/lanches/cheesesalad1.jpg', 'https://www.macoratti.net/Imagens/lanches/cheesesalad1.jpg', 0, 'Cheese Salada', 12.50)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) VALUES (2, 'Pão, hambúrguer, ovo, presunto, queijo e batata palha1', 'Delicioso pão de hambúrguer com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha', 1, 'https://www.macoratti.net/Imagens/lanches/cheesesalad1.jpg', 'https://www.macoratti.net/Imagens/lanches/cheesesalad1.jpg', 1, 'Lanche natural', 12.50)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
