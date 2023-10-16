# SmartOptions
Implement automatic IOptions Pattern for specific classes with attribute "SmartOption".
```
- [SmartOption] => uses class name by default as appssetings.json
- [SmartOption("Name of configuration section in appsettings.json")]
```

# Register Service Collection
```
builder.SmartOptionsInitalize();
```
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
