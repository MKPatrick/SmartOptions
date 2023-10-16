# Overview
Implement automatic IOptions Pattern for specific classes with attribute "SmartOption".

# Installation

Install via .NET CLI
```
dotnet add package SmartOptions --version 1.0.0
```
or Package Manager:

```
NuGet\Install-Package SmartOptions -Version 1.0.0
```

# Usage for Option Classes

```
- [SmartOption] => uses class name by default as appssetings.json
- [SmartOption("Name of configuration section in appsettings.json")]
```

# Register Service Collection
```
builder.SmartOptionsInitalize();
```


All classes which has the smartoption attribute will be registered automatically for the IOptions pattern.

## Example Class:


```

   [SmartOption]
    public class ModernOptions
    {
        public string Option3 { get; set; }
    }

    [SmartOption(nameof(TestOption))]
    public class TestOption
    {
        public string Test { get; set; }
    }

```
## Example AppSettings
  ```
  "TestOption": {
    "Test": "Servus"
  },
  "ModernOptions": {
    "Option3": "OAHFJD"
  },...

```

## IOptions Pattern DI
```
     public YourControllerConstructor(IOptions<ModernOptions> optionTest)
        {
   
        }
```

