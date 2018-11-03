using Sporting.MatchOverview.ViewModels;
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
	public partial class TeamsPage : ContentPage
	{
        public TeamsViewModel TeamsViewModel { get; set; }

        public TeamsPage ()
		{
			InitializeComponent ();

            TeamsViewModel = new TeamsViewModel();

            BindingContext = TeamsViewModel;
		}

        async void AddTeam_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new TeamAddPage()));
        }

        //protected override void OnAppearing()
        //{
        //    base.OnAppearing();

        //    if (TeamsViewModel.Teams.Count == 0)
        //        TeamsViewModel.Commander.Execute(null);
        //}

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            // do nothing

            //var item = args.SelectedItem as Item;
            //if (item == null)
            //    return;

            //await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            //// Manually deselect item.
            //ItemsListView.SelectedItem = null;
        }

    }
}