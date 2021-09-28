using ScriptForSeconds.Tools;
using ScriptForSeconds.Views;
using System.Collections.ObjectModel;


namespace ScriptForSeconds.ViewModels
{
    public class ClientViewModel : NotifyViewModel
    {
        ur_soulEntities db;
        public ObservableCollection<Client> Clients { get; set; }
        public StayCommand AddBtn { get; set; }
        public StayCommand EditBtn { get; set; }
        public ClientViewModel()
        {
            db = DB.GetDB();
            Clients = new ObservableCollection<Client>(db.Client);
            AddBtn = new StayCommand(() =>
            {
                Pager.ChangedPageTo(new ClientAddView());
            });
        }

        private Client selectedClient;
        public Client SelectedClient
        {
            get => selectedClient;
            set => selectedClient = value;
        }
        
    }
}
