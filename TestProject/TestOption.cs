using SmartOptions;

namespace TestProject
{
    [SmartOption(nameof(TestOption))]
    public class TestOption
    {
        public string Test { get; set; }
    }
}
