using MISiSDiningRoom.Classes;
using MISiSDiningRoom.ResoursesGeneral;
using MISiSDiningRoom.ResoursesGeneral.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MISiSDiningRoom
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Task.Run(RotateImage);

            
        }
        private async void RotateImage()
        {
            while (true)
                await BannerImg.RelRotateTo(360, 10000, Easing.Linear);
        }
        void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChooseLanguage.SelectLanguage(picker.Items[picker.SelectedIndex]);
            //LanguageLogoImg.Source= Resource.;
            AreYouHungry.Text = Resource.LabelAreYouHangry;
            DontWait.Text = Resource.DontWait;

        }
    }
}
