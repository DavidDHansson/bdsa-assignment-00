namespace assignment00.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        // Arrange
        using var writer = new StringWriter();
        Console.SetOut(writer);

         // Act
        var program = Assembly.Load(nameof(assignment00));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        // Assert
        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("Hey!");
    }
}