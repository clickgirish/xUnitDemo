using Business;

public class StaticParamLogicTests
{
    [Fact]
    public void GetParamById_ShouldReturnCorrectStaticParam_WhenKeyExists()
    {
        // Arrange
        using (var context = TestDbContextFactory.Create())  // Use the factory to create an in-memory context
        {
            var logic = new StaticParamLogic(context);

            // Act
            var result = logic.GetParamById("Param1");

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Value1", result.Value);
            Assert.Equal("This is the first parameter", result.Description);
        }
    }
}




//[Fact]
//public void GetParamById_ShouldReturnNull_WhenKeyDoesNotExist()
//{
//    // Arrange
//    using (var context = TestDbContextFactory.Create())  // Use the factory to create an in-memory context
//    {
//        var logic = new StaticParamLogic(context);

//        // Act
//        var result = logic.GetParamById("NonExistentKey");

//        // Assert
//        Assert.Null(result);
//    }
//}
