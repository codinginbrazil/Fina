# [Category](https://zzzcode.ai/dapper/entity-to-table-converter?id=78c1ab44-d9a9-4370-b985-a18d5e3e725b)


Sure! Here's the SQL Server script that will create the Category table:
```sql
CREATE TABLE Category (
    Id INT PRIMARY KEY,
    Title NVARCHAR(80) NOT NULL,
    Description NVARCHAR(255),
    UserId VARCHAR(160) NOT NULL
);
```

And here's the complete code example using the ".NET Fiddle Template":
```C#
// HEADER DIRECTIVE
// @nuget: Dapper
// @nuget: Microsoft.Data.SqlClient
// @nuget: Z.Dapper.Plus

// USING DIRECTIVE
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Dapper;
using Microsoft.Data.SqlClient;
using Z.Dapper.Plus;

public class Program
{	
	public static string ConnectionString = FiddleHelper.GetConnectionStringSqlServer();

	public static void Main()
	{
		// CONNECTION
		var connection = new SqlConnection(ConnectionString);
		
		// CREATE TABLE
		connection.CreateTable<Category>();
		
		// SEED		
		var list = new List<Category>();
		list.Add(new Category() { Id = 1, Title = "Category 1", Description = "Description 1", UserId = "User 1" });
		list.Add(new Category() { Id = 2, Title = "Category 2", Description = "Description 2", UserId = "User 2" });
		list.Add(new Category() { Id = 3, Title = "Category 3", Description = "Description 3", UserId = "User 3" });
		connection.BulkInsert(list);
		
		// OUTPUT
		var outputList = connection.Query<Category>("SELECT * FROM Category").ToList();
		FiddleHelper.WriteTable(outputList);
	}
	
	[Table("Category")]
	public class Category
	{
		[Key]
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string UserId { get; set; }
	}
}
```