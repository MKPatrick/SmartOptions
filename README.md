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
## Example:


```

   [SmartOption]
    public class ModernOptions
    {
        public string Option3 { get; set; }
    }


In apppsettings.json:

  "ModernOptions": {
    "Option3": "OAHFJD"
  },

```
