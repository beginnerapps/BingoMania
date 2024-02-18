using Microsoft.Maui.Controls;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;

namespace BingoMania.Framework.Views
{
    public class ViewModelBase : ReactiveObject, IDisposable
    {
        public ViewModelBase(INavigation navigation)
        {
            Navigation = navigation;
        }

        public void Dispose()
        {
            TrashBin.Dispose();
        }

        protected readonly CompositeDisposable TrashBin = new CompositeDisposable();
        protected readonly INavigation Navigation;
    }
}
