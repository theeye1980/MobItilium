using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobItilium.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            header.Text = "Вы выбрали: " + picker.Items[picker.SelectedIndex];
            picker.IsVisible = false;
        }

        private void picker2_SelectedIndexChanged(object sender, EventArgs e)
        {
            header2.Text = "Вы выбрали: " + picker2.Items[picker.SelectedIndex];
            picker2.IsVisible = false;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            newTaskForm.IsVisible = true;
        }
    }
}