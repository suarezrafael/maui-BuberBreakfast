using CommunityToolkit.Maui.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiBuberBrakefastNiceLayout.Converters;

internal class DateTimeToTimeConverter : BaseConverter<object, string>
{
    public override string DefaultConvertReturnValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public override object DefaultConvertBackReturnValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public override object ConvertBackTo(string value, CultureInfo culture)
    {
        throw new NotImplementedException();
    }

    public override string ConvertFrom(object value, CultureInfo culture)
    {
        DateTime dateTime = (DateTime)value;
        return TimeOnly.FromDateTime(dateTime).ToShortTimeString();
    }
}
