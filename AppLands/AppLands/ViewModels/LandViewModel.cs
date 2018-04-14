namespace AppLands.ViewModels
{
    using Models;

    public class LandViewModel
    {
        public Land Land { get; set; }


        public LandViewModel(Land land)
        {
            this.Land = land;
        }
    }
}
