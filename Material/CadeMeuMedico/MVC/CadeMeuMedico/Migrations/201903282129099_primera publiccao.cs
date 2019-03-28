namespace CadeMeuMedico.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class primerapubliccao : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cidades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Medicos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false, maxLength: 255),
                        DataNascimento = c.DateTime(nullable: false),
                        Cidade_Id = c.Int(),
                        Especialidade_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cidades", t => t.Cidade_Id)
                .ForeignKey("dbo.Especialidades", t => t.Especialidade_Id)
                .Index(t => t.Cidade_Id)
                .Index(t => t.Especialidade_Id);
            
            CreateTable(
                "dbo.Especialidades",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Medicos", "Especialidade_Id", "dbo.Especialidades");
            DropForeignKey("dbo.Medicos", "Cidade_Id", "dbo.Cidades");
            DropIndex("dbo.Medicos", new[] { "Especialidade_Id" });
            DropIndex("dbo.Medicos", new[] { "Cidade_Id" });
            DropTable("dbo.Especialidades");
            DropTable("dbo.Medicos");
            DropTable("dbo.Cidades");
        }
    }
}
