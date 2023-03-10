using System;
using System.Threading.Tasks;
using Windows.UI.ViewManagement;
using GitHub.Services.Abstract;

namespace GitHub.Services.Concrete
{
    public class ProgressIndicatorService : IProgressIndicatorService
    {
        public StatusBarProgressIndicator ProgressIndicator { get; set; }
        public bool ShowProgressIndicator { get; private set; }


        public async Task ShowAsync()
        {
            if (ProgressIndicator != null)
                await ProgressIndicator.ShowAsync();
        }

        public async Task HideAsync()
        {
            if (ProgressIndicator != null)
                await ProgressIndicator.HideAsync();
        }
    }
}
