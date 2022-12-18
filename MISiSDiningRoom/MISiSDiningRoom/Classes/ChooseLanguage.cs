using MISiSDiningRoom.Interfacese;
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
            if (language == "RU") 
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ru-RU");
            }
            if (language == "EN")
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            }
            if (language == "CN")
            {
                Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("zh-CHS");
            }


        }
    }
    
}
