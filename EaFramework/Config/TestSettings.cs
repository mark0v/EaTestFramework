using EaFramework.Driver;
using static EaFramework.Driver.DriverFixture;

namespace EaFramework.Config;

public class TestSettings
{
    public BrowserType BrowserType { get; set; }
    public Uri ApplicationUrl { get; set; }
    public float? TimeoutInterval { get; set; }
}
