using System;
using System.Globalization;
using CommunityToolkit.Maui.Converters;

namespace TestChatApp.Converters
{
    public class DateTimeToTimeConverter : BaseConverter<DateTime, string>
    {
        public DateTimeToTimeConverter()
        {
        }

        public override string DefaultConvertReturnValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override DateTime DefaultConvertBackReturnValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override DateTime ConvertBackTo(string value, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override string ConvertFrom(DateTime value, CultureInfo culture)
        {
            return TimeOnly.FromDateTime(value).ToShortTimeString();
        }
    }
}

