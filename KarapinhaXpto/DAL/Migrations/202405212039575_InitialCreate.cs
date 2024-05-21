namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        CategoriaId = c.Int(nullable: false),
                        CategoriaName = c.String(nullable: false, maxLength: 80),
                        descricao = c.String(nullable: false, maxLength: 80),
                        Servico_servicoid = c.Int(),
                    })
                .PrimaryKey(t => t.CategoriaId)
                .ForeignKey("dbo.Servicos", t => t.CategoriaId)
                .ForeignKey("dbo.Servicos", t => t.Servico_servicoid)
                .Index(t => t.CategoriaId)
                .Index(t => t.Servico_servicoid);
            
            CreateTable(
                "dbo.Marcacao",
                c => new
                    {
                        Marcacoesid = c.Int(nullable: false, identity: true),
                        DataTime = c.DateTime(nullable: false),
                        Hora = c.Time(nullable: false, precision: 7),
                        ProfissionalId = c.Int(nullable: false),
                        ServicoId = c.Int(nullable: false),
                        CategoriaId = c.Int(nullable: false),
                        UsuarioId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Marcacoesid)
                .ForeignKey("dbo.Categorias", t => t.CategoriaId, cascadeDelete: true)
                .ForeignKey("dbo.Profissional", t => t.ProfissionalId, cascadeDelete: true)
                .ForeignKey("dbo.Servicos", t => t.ServicoId, cascadeDelete: true)
                .ForeignKey("dbo.Usuarios", t => t.UsuarioId, cascadeDelete: true)
                .Index(t => t.ProfissionalId)
                .Index(t => t.ServicoId)
                .Index(t => t.CategoriaId)
                .Index(t => t.UsuarioId);
            
            CreateTable(
                "dbo.Profissional",
                c => new
                    {
                        ProficionaisId = c.Int(nullable: false, identity: true),
                        nomeProficional = c.String(nullable: false, maxLength: 80),
                        especialidade = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.ProficionaisId);
            
            CreateTable(
                "dbo.Servicos",
                c => new
                    {
                        servicoid = c.Int(nullable: false, identity: true),
                        nomeServico = c.String(nullable: false, maxLength: 80),
                        decricao = c.String(nullable: false, maxLength: 80),
                        valor = c.Single(nullable: false),
                        CategoriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.servicoid);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        UsuariosId = c.Int(nullable: false, identity: true),
                        NomeCompleto = c.String(nullable: false, maxLength: 80),
                        Telefone = c.String(nullable: false, maxLength: 80),
                        Imagem = c.String(nullable: false, maxLength: 80),
                        Email = c.String(nullable: false, maxLength: 80),
                        Bilhete = c.String(nullable: false, maxLength: 80),
                        Username = c.String(nullable: false, maxLength: 80),
                    })
                .PrimaryKey(t => t.UsuariosId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categorias", "Servico_servicoid", "dbo.Servicos");
            DropForeignKey("dbo.Marcacao", "UsuarioId", "dbo.Usuarios");
            DropForeignKey("dbo.Marcacao", "ServicoId", "dbo.Servicos");
            DropForeignKey("dbo.Categorias", "CategoriaId", "dbo.Servicos");
            DropForeignKey("dbo.Marcacao", "ProfissionalId", "dbo.Profissional");
            DropForeignKey("dbo.Marcacao", "CategoriaId", "dbo.Categorias");
            DropIndex("dbo.Marcacao", new[] { "UsuarioId" });
            DropIndex("dbo.Marcacao", new[] { "CategoriaId" });
            DropIndex("dbo.Marcacao", new[] { "ServicoId" });
            DropIndex("dbo.Marcacao", new[] { "ProfissionalId" });
            DropIndex("dbo.Categorias", new[] { "Servico_servicoid" });
            DropIndex("dbo.Categorias", new[] { "CategoriaId" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Servicos");
            DropTable("dbo.Profissional");
            DropTable("dbo.Marcacao");
            DropTable("dbo.Categorias");
        }
    }
}
