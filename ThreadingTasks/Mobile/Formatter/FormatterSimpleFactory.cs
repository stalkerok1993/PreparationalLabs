using Mobile.Phone.NetworkServices.SMS;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Mobile.Formatter {
    public class FormatterSimpleFactory {
        public delegate string Formatter(Message message);

        private readonly Dictionary<string, Formatter> formatters;

        public Formatter DefaultFormatter => (message) => message.Text;

        public IEnumerable<string> AvailableNames => formatters.Keys;

        public FormatterSimpleFactory(IFormatProvider formatProvider = null) {
            formatProvider = formatProvider ?? CultureInfo.InvariantCulture.DateTimeFormat;

            formatters = new Dictionary<string, Formatter>()
            {
                {"Start with DateTime", (message) => $"[{message.ReceivedTime.ToString(formatProvider)}] {message.Text}"},
                {"End with DateTime", (message) => $"{message.Text} [{message.ReceivedTime.ToString(formatProvider)}]"},
                {"Custom", (message) => $"SMS: {message.Text.Trim()}"},
                {"Lowercase", (message) => message.Text.ToLower()},
                {"Uppercase", (message) => message.Text.ToUpper()}
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
