namespace CadeMeuMedico.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigracaoFinal : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DicionarioHashes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SenhaEmAberto = c.String(),
                        HashCriptografado = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        ConfirmacaoEmail = c.String(nullable: false),
                        Senha = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Especialidades", "Descricao", c => c.String(maxLength: 255));
            AlterColumn("dbo.Especialidades", "Nome", c => c.String(nullable: false, maxLength: 60));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Especialidades", "Nome", c => c.String());
            DropColumn("dbo.Especialidades", "Descricao");
            DropTable("dbo.Usuarios");
            DropTable("dbo.DicionarioHashes");
        }
    }
}
