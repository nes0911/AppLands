﻿namespace AppLands.ViewModels
{
    using Models;
    using System.Collections.Generic;

    public class MainViewModel
    {
        #region Propiedades
        public LoginViewModel Login { get; set; }

        public LandsViewModel Lands { get; set; }

        public LandViewModel Land { get; set; }

        public List<Land> LandsList { get; set; }
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
