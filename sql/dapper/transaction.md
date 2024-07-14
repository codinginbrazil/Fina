# [Transaction](https://zzzcode.ai/dapper/entity-to-table-converter?id=010d24f5-267d-465d-9555-737a747fc978)

```sql
CREATE TABLE [Transaction] (
    Id INT PRIMARY KEY,
    Title NVARCHAR(80) NOT NULL,
    Type SMALLINT NOT NULL,
    Amount MONEY NOT NULL,
    CreatedAt DATETIME NOT NULL,
    PaidOrReceivedAt DATETIME NULL,
    UserId VARCHAR(160) NOT NULL
);
```

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
		connection.CreateTable<Transaction>();
		
		// SEED		
		var list = new List<Transaction>();
		list.Add(new Transaction() { Id = 1, Title = "Transaction 1", Type = 1, Amount = 100.00m, CreatedAt = DateTime.Now, UserId = "user1" });
		list.Add(new Transaction() { Id = 2, Title = "Transaction 2", Type = 2, Amount = 200.00m, CreatedAt = DateTime.Now, UserId = "user2" });
		list.Add(new Transaction() { Id = 3, Title = "Transaction 3", Type = 1, Amount = 300.00m, CreatedAt = DateTime.Now, UserId = "user3" });
		connection.BulkInsert(list);
		
		// CODE
		// [ADD the code for the example here]
		
		// OUTPUT
		var outputList = connection.Query<Transaction>("SELECT * FROM [Transaction]").ToList();
		FiddleHelper.WriteTable(outputList);
	}
	
	[Table("Transaction")]
	public class Transaction
	{
		[Key]
		public int Id { get; set; }
		public string Title { get; set; }
		public short Type { get; set; }
		public decimal Amount { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime? PaidOrReceivedAt { get; set; }
		public string UserId { get; set; }
	}
}

```