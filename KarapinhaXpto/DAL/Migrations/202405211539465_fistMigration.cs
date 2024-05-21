namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fistMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Servicos",
                c => new
                    {
                        servicoid = c.Int(nullable: false, identity: true),
                        nomeServico = c.String(nullable: false, maxLength: 80),
                        decricao = c.String(nullable: false, maxLength: 80),
                        valor = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.servicoid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Servicos");
        }
    }
}
