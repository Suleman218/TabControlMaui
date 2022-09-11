using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabControlMaui.Model;

namespace TabControlMaui.ViewModels
{
    public class MainPageViewModel
    {
        public List<TabOption> TabOptions { get; set; }
        public MainPageViewModel()
        {
            TabOptions = new List<TabOption>()
            {
                {new TabOption(){  Name="Invertebrates"} },
                {new TabOption(){  Name="Fish"} },
                {new TabOption(){  Name="Amphibians"} },
                {new TabOption(){  Name="Reptiles"} },
                {new TabOption(){  Name="Birds"} },
                {new TabOption(){  Name="Mammals"} }
            };
        }
    }
}
