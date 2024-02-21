namespace EvaluationSampleCode.UnitTests;

[TestClass]
public class MathOperationUnitTest
{
private MathOperations _mathOperations;

[TestInitialize]
public void Init()
{
    _mathOperations = new MathOperations();
}

[TestMethod]
[DataRow(10, 5, 15)]
[DataRow(999, 1, 1000)]
[DataRow(1, 500, 501)]
public void Add_WithTwoNumbers_ReturnsAddition(int numberOne, int numberTwo, int expectedResult)
{
    var actualResult = _mathOperations.Add(numberOne, numberTwo);

    Assert.AreEqual(expectedResult, actualResult);
    
}

[TestMethod]
public void Divide_WithTwoStrictlyPositiveNumbers_ReturnsDivision()
{
    var actualResult = _mathOperations.Divide(10, 5);

    Assert.AreEqual(2, actualResult);

}

[TestMethod]
public void Divide_WithSecondParameterEqualToZero_ThrowsArgumentException()
{
    Assert.ThrowsException<ArgumentException>(() => _mathOperations.Divide(10, 0));
}
}