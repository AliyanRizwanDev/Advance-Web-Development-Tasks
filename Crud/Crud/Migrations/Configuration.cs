namespace Crud.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Crud.Models;
    internal sealed class Configuration :
    DbMigrationsConfiguration<Crud.DB.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
        protected override void Seed(Crud.DB.AppDbContext context)
        {
            context.Grades.AddOrUpdate(new Grade
            {
                Id = 1,
                GradeName = "A",
                GradeDescription
                    = "A Grade"
            },
            new Grade { Id = 2, GradeName = "B", GradeDescription = " B Grade " },
            new Grade { Id = 3, GradeName = "C", GradeDescription = " C Grade " }
            );
        }
    }
}