﻿namespace AppLands.ViewModels
{
    public class MainViewModel
    {
        #region Propiedades
        public LoginViewModel Login { get; set; }

        public LandsViewModel Lands { get; set; } 
        #endregion

        #region Constructor
        public MainViewModel()
        {
            instance = this;
            this.Login = new LoginViewModel();
        } 
        #endregion

        #region Singleton
        private static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }

            return instance;
        }	
	}
        #endregion    
}
