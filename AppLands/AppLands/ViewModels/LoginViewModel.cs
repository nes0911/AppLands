namespace AppLands.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;
    using Views;

    public class LoginViewModel : BaseViewModel
    {
        #region Atributos
        private string email;
        private string password;
        private bool isRunning;
        private bool isRemenber;
        private bool isEnabled;
        #endregion

        #region Propiedades
        public string Email
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }

        public string Password
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }

        public bool IsRunning
        {
            get { return this.isRunning; }
            set { SetValue(ref this.isRunning, value); }
        }

        public bool IsRemenber
        {
            get { return this.isRemenber; }
            set { SetValue(ref this.isRemenber, value); }
        }

        public bool IsEnabled
        {
            get { return this.isEnabled; }
            set { SetValue(ref this.isEnabled, value); }
        }
        #endregion

        #region Constructores
        public LoginViewModel()
        {
            IsRemenber = true;
            IsEnabled = true;
        }
        #endregion

        #region Metodos
        public ICommand IngresarCommand
        {
            get { return new RelayCommand(Ingresar); }
        }

        private async void Ingresar()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Debe ingresar un Email...",
                    "Volver");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Debe ingresar un Password...",
                    "Volver");                
                return;
            }                       

            if (this.Email != "nnegrin@gmail.com" || this.Password != "1234")
            {
                this.IsRunning = true;
                this.IsEnabled = false;

                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Email o Password Incorrecto...",
                    "Volver");

                this.IsRunning = false;
                this.IsEnabled = true;

                this.Email = string.Empty;
                this.Password = string.Empty;
                return;
            }                      

            this.Email = string.Empty;
            this.Password = string.Empty;

            MainViewModel.GetInstance().Lands = new LandsViewModel();
            await Application.Current.MainPage.Navigation.PushAsync(new LandsPage());            

            return;
        } 
        #endregion        
    }
}
