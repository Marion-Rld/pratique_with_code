namespace EvaluationSampleCode.UnitTests;

[TestClass]
public class HtmlFormatHelperTest
{
    private HtmlFormatHelper _htmlFormatHelper;

    [TestInitialize]
    public void Init()
    {
        _htmlFormatHelper = new HtmlFormatHelper();
    }

    [TestMethod]
    public void GetBoldFormat_GivenString_ReturnsBoldHtmlString()
    {
        var actualResult = _htmlFormatHelper.GetBoldFormat("Hello World");

        Assert.AreEqual("<b>Hello World</b>", actualResult);
    }
}
