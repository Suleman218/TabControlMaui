using System.ComponentModel;

namespace TabControlMaui.Model
{
    public class TabOption : INotifyPropertyChanged
    {
        public string Name { get; set; }
        public bool IsSelected { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}