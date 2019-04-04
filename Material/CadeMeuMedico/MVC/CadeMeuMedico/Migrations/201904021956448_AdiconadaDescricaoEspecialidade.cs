namespace CadeMeuMedico.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AdiconadaDescricaoEspecialidade : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Especialidades", "Descricao", c => c.String(maxLength: 255));
            AlterColumn("dbo.Especialidades", "Nome", c => c.String(nullable: false, maxLength: 60));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Especialidades", "Nome", c => c.String());
            DropColumn("dbo.Especialidades", "Descricao");
        }
    }
}
