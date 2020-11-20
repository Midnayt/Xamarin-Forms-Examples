using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XFSamples.ViewModels
{
    public class SelectImagesPageViewModel : ViewModelBase
    {
        public SelectImagesPageViewModel(
            INavigationService navigationService,
            IPageDialogService pageDialogService)
            : base(navigationService, pageDialogService)
        {

        }
    }
}
