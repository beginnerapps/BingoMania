using Microsoft.Maui.Controls;

namespace BingoMania.Framework.Views
{
    public abstract class ContentPageBase<TViewModel> : ContentPage where TViewModel : ViewModelBase
    {
        protected TViewModel ViewModel { get; }
        public ContentPageBase(TViewModel viewModel)
        {
            ViewModel = viewModel;
            BindingContext = ViewModel;
        }
    }
}
