using System;
using System.Collections.Generic;

namespace Mobile.Formatter {
    public static class FormatterSimpleFactory {
        public delegate string Formatter(string message);

        private static readonly Dictionary<string, Formatter> formatters = new Dictionary<string, Formatter>()
        {
            {"Start with DateTime", (message) => $"[{DateTime.Now}] {message}"},
            {"End with DateTime", (message) => $"{message} [{DateTime.Now}]" },
            {"Custom", (message) => $"SMS: {message.Trim()}" },
            {"Lowercase", (message) => message.ToLower() },
            {"Uppercase", (message) => message.ToUpper() }
        };

        public static readonly Formatter DefaultFormatter = (message) => message;

        public static readonly IEnumerable<string> AvailableNames = formatters.Keys;

        public static Formatter CreateFormatter(string name)
        {
            if (!formatters.ContainsKey(name))
            {
                return DefaultFormatter;
            }

            return formatters[name];
        }
    }
}
