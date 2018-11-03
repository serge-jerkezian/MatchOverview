using Sporting.MatchOverview.Models;
using Sporting.MatchOverview.Services;
using Sporting.MatchOverview.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Sporting.MatchOverview.ViewModels
{
    public class TeamsViewModel : BaseViewModel
    {
        public IDataStore<Team> DataStoreTeam => DependencyService.Get<IDataStore<Team>>();

        public ObservableCollection<Team> Teams { get; set; }
        public Command Commander { get; set; }


        public TeamsViewModel()
        {
            Title = "Teams Page";

            Teams = new ObservableCollection<Team>();
            Commander = new Command(async() => await ExecuteLoadTeamsCommand());

            MessagingCenter.Subscribe<TeamAddPage, Team>(this, "AddTeam", async (obj, team) =>
            {
                var newTeam = team as Team;
                Teams.Add(newTeam);
                await DataStoreTeam.AddItemAsync(newTeam);
            });
        }


        async Task ExecuteLoadTeamsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Teams.Clear();
                var items = await DataStoreTeam.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Teams.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

    }
}
