using System;
using System.Globalization;
using CommunityToolkit.Maui.Converters;

namespace TestChatApp.Converters
{
    public class DateTimeToBreakfastTimeConverter : BaseConverter<DateTime, string>
    {
        public override string DefaultConvertReturnValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override DateTime DefaultConvertBackReturnValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override DateTime ConvertBackTo(string value, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override string ConvertFrom(DateTime value, CultureInfo culture)
        {
            return (value.Date - DateTime.Today).TotalDays switch
            {
                0 => "Today",
                1 => "Tomorrow",
                _ => $"{value.DayOfWeek}, {value.Day}.{value.Month}"
            };
        }
    }
}

