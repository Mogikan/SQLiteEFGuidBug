using Microsoft.EntityFrameworkCore;
using System.Linq;
using System;

namespace SQLiteSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using (var ctx = new SqliteDbContext("data.db"))
            {
                ctx.Database.Migrate();
                var someGuid = Guid.NewGuid();
                UserReferencesData value = null;
                //(from cell in ctx.UserReferencesData
                //                            where cell.RowId == 1 && cell.ColumnId == someGuid
                //                            select cell).FirstOrDefault();
                if (value is null)
                    ctx.UserReferencesData.Add(new UserReferencesData()
                    {
                        ColumnId = Guid.NewGuid(),
                        MetadataId = -2,
                        RowId = 1,
                        ColumnType = 1,
                        StringValue = "asdf",
                    });
                ctx.SaveChanges();
            }
        }
    }
}
