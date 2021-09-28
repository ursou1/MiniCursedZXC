using ScriptForSeconds.Tools;
using ScriptForSeconds.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ScriptForSeconds.ViewModels
{
    public class MainViewModel : NotifyViewModel
    {
        private Page currentPage;
        public Page CurrentPage
        {
            get => currentPage;
            set
            {
                currentPage = value;
                SignalChanged("CurrentPage");
            }
        }
        public StayCommand MainView { get; set; }
        public StayCommand ClientView { get; set; }
        public MainViewModel()
        {
            Pager.ChangePage += (o, e) => CurrentPage = e;

            MainView = new StayCommand(() =>
            {
                Pager.ChangedPageTo(new MainView());
            });
            ClientView = new StayCommand(() =>
            {
                Pager.ChangedPageTo(new ClientListView());
            });
        }
    



    }
}
