using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace XFSamples.ViewModels
{
    public class ImageLoadingPageViewModel : ViewModelBase
    {
        private List<Images> _images;
        public List<Images> Images
        {
            get => _images;
            set => SetProperty(ref _images, value);
        }
        public ImageLoadingPageViewModel(
            INavigationService navigationService,
            IPageDialogService pageDialogService) : base(navigationService, pageDialogService)
        {

        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);
            var imageList = new List<Images>();
            for (var i = 0; i < 100; i++)
            {
                imageList.Add(new ViewModels.Images { Url = "https://images.unsplash.com/photo-1516912481808-3406841bd33c" });
            }
            Images = new List<Images>(imageList);
        }
    }
    public class Images
    {
        public string Url { get; set; }
    }
}
