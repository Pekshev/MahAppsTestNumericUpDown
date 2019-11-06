namespace TestMahAppsNumericBox
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Main ViewModel
    /// </summary>
    public class ViewModel : INotifyPropertyChanged
    {
        private double _testValue;

        public double TestValue
        {
            get => _testValue;
            set
            {
                if (Equals(value, _testValue)) return;
                _testValue = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
