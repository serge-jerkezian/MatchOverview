using Sporting.MatchOverview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sporting.MatchOverview.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TeamAddPage : ContentPage
	{
        public Team Team { get; set; }

        public TeamAddPage ()
		{
			InitializeComponent ();

            Team = new Team();

            BindingContext = Team;
        }

        async void Save_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send(Team, "AddItem", Team);
            await Navigation.PopModalAsync();
        }
    }

    
}