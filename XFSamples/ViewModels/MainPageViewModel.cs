using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XFSamples.Views;

namespace XFSamples.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        #region variables



        #endregion

        #region constructors

        public MainPageViewModel(
            INavigationService navigationService,
            IPageDialogService pageDialogServcie)
            : base(navigationService, pageDialogServcie)
        {
            Title = "Main Page";
            App.Current.UserAppTheme = Xamarin.Forms.OSAppTheme.Light;
        }

        #endregion

        #region functions

        async Task ExecuteSelectImageCommand()
        {
            await NavigationService.NavigateAsync(nameof(ImageLoadingPage));
        }

        #endregion

        #region commands

        private DelegateCommand _SelectImageCommand;
        public DelegateCommand SelectImageCommand =>
            _SelectImageCommand ?? (_SelectImageCommand = new DelegateCommand(async () => await ExecuteSelectImageCommand()));

        #endregion
    }
}
