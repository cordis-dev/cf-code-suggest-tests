using System;

namespace ca1018
{
    // Violates rule: MarkAttributesWithAttributeUsage.
    public sealed class BadCodeMaintainerAttribute : Attribute
    {
        public BadCodeMaintainerAttribute(string developerName)
        {
            DeveloperName = developerName;
        }

        public string DeveloperName { get; }
    }
}
