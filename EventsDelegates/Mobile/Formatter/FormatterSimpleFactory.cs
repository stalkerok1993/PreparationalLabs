using System;
using System.Collections.Generic;
using System.Globalization;
using UnderstandingOop.Date;

namespace UnderstandingOop.Formatter {
    public class FormatterSimpleFactory {
        public delegate string Formatter(string message);

        private readonly Dictionary<string, Formatter> formatters;

        public Formatter DefaultFormatter => (message) => message;

        public IEnumerable<string> AvailableNames => formatters.Keys;

        public FormatterSimpleFactory(IDateProvider dateProvider, IFormatProvider formatProvider = null)
        {
            formatProvider = formatProvider ?? CultureInfo.InvariantCulture.DateTimeFormat;

            formatters = new Dictionary<string, Formatter>()
            {
                {"Start with DateTime", (message) => $"[{dateProvider?.Now.ToString(formatProvider)}] {message}"},
                {"End with DateTime", (message) => $"{message} [{dateProvider?.Now.ToString(formatProvider)}]"},
                {"Custom", (message) => $"SMS: {message.Trim()}"},
                {"Lowercase", (message) => message.ToLower()},
                {"Uppercase", (message) => message.ToUpper()}
            };
        }

        public Formatter CreateFormatter(string name) {
            if (name == null || !formatters.ContainsKey(name)) {
                return DefaultFormatter;
            }

            return formatters[name];
        }
    }
}
