using MISiSDiningRoom.Interfacese;
using MISiSDiningRoom.ResoursesGeneral.Localization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;
using Xamarin.Forms;

namespace MISiSDiningRoom.Classes
{
   static class ChooseLanguage
    {
       


       static public void SelectLanguage(string language)
        {

            switch (language)
            {

                case "RU" :
                    Resource.Culture = CultureInfo.GetCultureInfo("ru-RU");
                    break;
                case "CN":
                    Resource.Culture = CultureInfo.GetCultureInfo("zh-CHS");
                    break;
                default:
                    Resource.Culture = CultureInfo.GetCultureInfo("en-US");
                    break;
            }


        }
    }
    
}
