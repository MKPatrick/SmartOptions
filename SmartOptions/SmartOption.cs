using System.Runtime.CompilerServices;

namespace SmartOptions
{
    [AttributeUsage(AttributeTargets.Class)]
    public class SmartOption : Attribute
    {
        public string OptionPosition { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="optionPosition">The Optionposition in appsettings.json (when no value used classname is used)</param>
        /// <param name="callerFile"></param>
        public SmartOption(string optionPosition = "", [CallerFilePath] string callerFile = "")
        {
            if (string.IsNullOrWhiteSpace(optionPosition))
            {
                // If Name is not provided, use the name of the calling class
                OptionPosition = GetClassNameFromFilePath(callerFile);
            }
            else
            {
                OptionPosition = optionPosition;
            }

        }

        private string GetClassNameFromFilePath(string filePath)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                int startIndex = filePath.LastIndexOf('\\');
                int endIndex = filePath.LastIndexOf(".cs");
                if (startIndex >= 0 && endIndex > startIndex)
                {
                    return filePath.Substring(startIndex + 1, endIndex - startIndex - 1);
                }
            }
            throw new Exception("Can't identify classname. Multiple classes in one file?");


        }
    }



}