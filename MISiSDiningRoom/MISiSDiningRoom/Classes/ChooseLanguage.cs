
using MISiSDiningRoom.ResoursesGeneral.Localization;
using System.Globalization;

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
