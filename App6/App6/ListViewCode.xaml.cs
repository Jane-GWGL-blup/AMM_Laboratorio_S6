using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App6
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewCode : ContentPage
    {
        public ListViewCode()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            listView.ItemsSource = new String[]
            {
                "mono",
                "monodroid",
                "monotouch",
                "monorail",
                "monodevelop",
                "monotone",
                "monopoly",
                "monomodal",
                "mononucleosis"
            };
        }
    }
}