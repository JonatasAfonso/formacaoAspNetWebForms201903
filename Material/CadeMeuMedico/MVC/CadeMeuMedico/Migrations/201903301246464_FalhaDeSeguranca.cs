namespace CadeMeuMedico.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class FalhaDeSeguranca : DbMigration
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
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DicionarioHashes");
        }
    }
}
