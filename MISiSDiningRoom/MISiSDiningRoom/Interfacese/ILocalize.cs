using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MISiSDiningRoom.Interfacese
{
    public interface ILocalize
    {
        CultureInfo GetCurrentCultureInfo();
    }
}
