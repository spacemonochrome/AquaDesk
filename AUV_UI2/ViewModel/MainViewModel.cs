using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AquaDesk.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private string _caption;
        private IconChar _icon;
        private ViewModelBase _currentChildView;

        public ViewModelBase CurrentChildView
        {
            get => _currentChildView;
            set
            {
                _currentChildView = value;
                OnPropertyChanged(nameof(CurrentChildView));
            }
        }

        public string Caption
        {
            get => _caption;
            set
            {
                _caption = value;
                OnPropertyChanged(nameof(Caption));
            }
        }

        public IconChar Icon
        {
            get => _icon;
            set
            {
                _icon = value;
                OnPropertyChanged(nameof(Icon));
            }
        }

        public ICommand AnasayfaViewCommand { get; }
        public ICommand KontrolViewCommand { get; }
        public ICommand KonfigurasyonViewCommand { get; }
        public ICommand AracViewCommand { get; }

        public MainViewModel()
        {
            _caption = "";
            _currentChildView = new AnasayfaModel(); // veya default boş bir ViewModel
            AnasayfaViewCommand = new ViewModelCommand(ExecuteAnasayfaViewCommand);
            KontrolViewCommand = new ViewModelCommand(ExecuteKontrolViewCommand);
            KonfigurasyonViewCommand = new ViewModelCommand(ExecuteKonfigurasyonViewCommand);
            AracViewCommand = new ViewModelCommand(ExecuteAracViewCommand);
            ExecuteAnasayfaViewCommand(null);
        }

        private void ExecuteKontrolViewCommand(object? obj)
        {
            CurrentChildView = new KontrolModel();
            Caption = "Kontrol";
            Icon = IconChar.Blackboard;
        }

        private void ExecuteAnasayfaViewCommand(object? obj)
        {
            CurrentChildView = new AnasayfaModel();
            Caption = "Anasayfa";
            Icon = IconChar.Home;
        }
        private void ExecuteKonfigurasyonViewCommand(object? obj)
        {
            CurrentChildView = new KonfigurasyonModel();
            Caption = "Konfigürasyon";
            Icon = IconChar.HouseTsunami;
        }
        private void ExecuteAracViewCommand(object? obj)
        {
            CurrentChildView = new AracModel();
            Caption = "Araç";
            Icon = IconChar.HouseFloodWater;
        }
    }
}
