using System;
using System.Collections.Generic;
using System.Text;
using MISiSDiningRoom.Classes;
using Xamarin.Forms;


namespace MISiSDiningRoom.ViewModes
{
    internal class MainViewModel : BaseViewModel
    {
        public List<Pick> Picks { get; set; }
        public MainViewModel()
        {
            Picks = GetPicks();
        }
        private List<Pick> GetPicks()
        {
            return new List<Pick>
            {
                new Pick { Title="", Description="", Image="", Price="" }
            };
        }
    }
}
