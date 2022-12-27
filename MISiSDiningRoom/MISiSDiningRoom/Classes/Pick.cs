using MISiSDiningRoom.ResoursesGeneral.Localization;
using System;
using System.Collections.Generic;
using System.Dynamic;
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
               new Pick {  Title=Resource.SolyankaTitle,Description=Resource.SolyankaDescription, Image="Solyanka.png", Price=Resource.SolyankaPrice, Sound="Solyanka.mp3" },
               new Pick {  Title=Resource.LapshaTitle,Description=Resource.LapshaDescription, Image="Lapsharound.png", Price=Resource.LapshaPrice, Sound="LapshaSGribamiiMasom.mp3" },
               new Pick {  Title=Resource.PirojokSkatrohoiTitle,Description=Resource.PirojokSkatrohoiDescription, Image="Pirojokround.png", Price=Resource.PirojokSkatrohoiPrice, Sound="PirojokSkaros.mp3" },
               new Pick {  Title=Resource.RossolnikTitle,Description=Resource.RossolnikDescription, Image="Rasolnikround.png", Price=Resource.RossolnikPrice, Sound="Rassolnik.mp3" },
               new Pick {  Title=Resource.RisSMTitle5,Description=Resource.RisSMDescription, Image="RisSMyasomround.png", Price=Resource.RisSMPrice5, Sound="RisSMyasom.mp3" },
               new Pick {  Title=Resource.MimosaTitle,Description=Resource.MimosaDescription, Image="Mimozaround.png", Price=Resource.MimosaPrice, Sound="SalatMimoza.mp3" },
               new Pick {  Title=Resource.VenegreTitle,Description=Resource.VenegreDescription, Image="Venegretround.png", Price=Resource.VenegrePrice, Sound="SalatVenegret.mp3" },
               new Pick {  Title=Resource.VitaminTitle,Description=Resource.VitaminDescription, Image="Vitaminround.png", Price=Resource.VitaminPrice, Sound="VitaminSalat.mp3" },
            };
        }
    }

}
