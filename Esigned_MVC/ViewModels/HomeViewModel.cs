using Esigned.Core.Entities;

namespace Esigned_MVC.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public IEnumerable<Service> Services { get; set; }

    }
}
