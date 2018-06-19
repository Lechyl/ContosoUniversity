namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ColumnFirstNameAndMinLengthAndFirstLetterOnNames : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Student", name: "FirstMidName", newName: "FirstName");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Student", name: "FirstName", newName: "FirstMidName");
        }
    }
}
