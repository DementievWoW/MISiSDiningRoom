using MISiSDiningRoom.Classes;
using MISiSDiningRoom.ResoursesGeneral.Localization;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MISiSDiningRoom
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();  

            RefreshLanguageTextElements();

            Task.Run(RotateImage);


        }

        private void RefreshLanguageTextElements()
        {
            try
            {

                BindableLayout.SetItemsSource(TMDCourusel, Pick.GetPicks());

                AreYouHungryLabel.Text = Resource.AreYouHungryLabel;

                DontWaitLabel.Text = Resource.DontWaitLabel;

                THEMOSTDELICIOUSLabel.Text = Resource.THEMOSTDELICIOUSLabel;

                ChooseNowButton.Text = Resource.ChooseNowButton;

            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private async void RotateImage()
        {
            while (true)
                await BannerImg.RelRotateTo(360, 10000, Easing.Linear);
        }

        void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChooseLanguage.SelectLanguage(picker.Items[picker.SelectedIndex]);

            RefreshLanguageTextElements();

        }

      
    }
}
