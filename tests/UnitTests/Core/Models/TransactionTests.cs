using Core.Configurations.Enums;
using Core.Models;

namespace UnitTests.Core.Models;

public class TransactionTests
{
    [Fact]
    public void Transaction_ShouldHaveDefaultValues()
    {
        // Arrange
        var transaction = new Transaction();

        // Act
        var id = transaction.Id;
        var createAt = transaction.CreateAt;
        var paidOrReceivedAt = transaction.PaidOrReceivedAt;
        var type = transaction.Type;
        var amount = transaction.Amount;
        var categoryId = transaction.CategoryId;
        var category = transaction.Category;
        var userId = transaction.UserId;

        // Assert
        Assert.Equal(0, id);
        Assert.True((DateTime.Now - createAt).TotalSeconds < 1); // Assuming the creation time is very recent
        Assert.Null(paidOrReceivedAt);
        Assert.Equal(ETransactionType.Withdraw, type);
        Assert.Equal(0m, amount);
        Assert.Equal(0, categoryId);
        Assert.Null(category); // We expect null because it is not set yet
        Assert.Null(userId);
    }

    [Fact]
    public void Transaction_ShouldAllowSettingId()
    {
        // Arrange
        var transaction = new Transaction();
        var id = 123L;

        // Act
        transaction.Id = id;

        // Assert
        Assert.Equal(id, transaction.Id);
    }

    [Fact]
    public void Transaction_ShouldAllowSettingCreateAt()
    {
        // Arrange
        var transaction = new Transaction();
        var createAt = new DateTime(2024, 1, 1);

        // Act
        transaction.CreateAt = createAt;

        // Assert
        Assert.Equal(createAt, transaction.CreateAt);
    }

    [Fact]
    public void Transaction_ShouldAllowSettingPaidOrReceivedAt()
    {
        // Arrange
        var transaction = new Transaction();
        var paidOrReceivedAt = new DateTime(2024, 1, 1);

        // Act
        transaction.PaidOrReceivedAt = paidOrReceivedAt;

        // Assert
        Assert.Equal(paidOrReceivedAt, transaction.PaidOrReceivedAt);
    }

    [Fact]
    public void Transaction_ShouldAllowSettingType()
    {
        // Arrange
        var transaction = new Transaction();
        var type = ETransactionType.Deposit;

        // Act
        transaction.Type = type;

        // Assert
        Assert.Equal(type, transaction.Type);
    }

    [Fact]
    public void Transaction_ShouldAllowSettingAmount()
    {
        // Arrange
        var transaction = new Transaction();
        var amount = 100.50m;

        // Act
        transaction.Amount = amount;

        // Assert
        Assert.Equal(amount, transaction.Amount);
    }

    [Fact]
    public void Transaction_ShouldAllowSettingCategoryId()
    {
        // Arrange
        var transaction = new Transaction();
        var categoryId = 456L;

        // Act
        transaction.CategoryId = categoryId;

        // Assert
        Assert.Equal(categoryId, transaction.CategoryId);
    }

    [Fact]
    public void Transaction_ShouldAllowSettingCategory()
    {
        // Arrange
        var transaction = new Transaction();
        var category = new Category { Id = 1, Description = "Test Category", UserId = "User123" };

        // Act
        transaction.Category = category;

        // Assert
        Assert.Equal(category, transaction.Category);
    }

    [Fact]
    public void Transaction_ShouldAllowSettingUserId()
    {
        // Arrange
        var transaction = new Transaction();
        var userId = "User123";

        // Act
        transaction.UserId = userId;

        // Assert
        Assert.Equal(userId, transaction.UserId);
    }
}