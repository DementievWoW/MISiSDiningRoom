using MISiSDiningRoom.ResoursesGeneral.Localization;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISiSDiningRoom.Classes
{
    internal class Pick
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }
        public string Sound { get; set; }


        static public List<Pick> GetPicks()
        {
            return new List<Pick>
            {
               new Pick { Title=Resource.SolyankaTitle,Description=Resource.SolyankaDescription, Image="Solyanka.png", Price=Resource.SolyankaPrice, Sound="Solyanka.mp3" },
               new Pick { Title="gfgsdf", Description="gdsf", Image="Solyanka.png", Price="dsgf" },
               new Pick { Title="gfgsdf", Description="gdsf", Image="Solyanka.png", Price="dsgf" },
            };
        }
    }

}
