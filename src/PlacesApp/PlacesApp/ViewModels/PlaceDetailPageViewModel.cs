using PlacesApp.Models;
using Prism.Mvvm;
using Prism.Navigation;

namespace PlacesApp.ViewModels
{
    public class PlaceDetailPageViewModel : ViewModelBase
    {
        public Place Place { get; set; }
        public PlaceDetailPageViewModel(INavigationService  navigationPage) : base(navigationPage)
        {
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {

            parameters.TryGetValue("place", out Place place);

            Place = place;
           
        }
    }
}
