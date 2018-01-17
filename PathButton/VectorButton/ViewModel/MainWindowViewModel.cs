using Caliburn.Micro;

namespace VectorButton.ViewModel
{
    public class MainWindowViewModel : PropertyChangedBase
    {
        private string _newText;

        public MainWindowViewModel()
        {
            NewText = "uqeiruqw";
        }

        public string NewText
        {
            get { return _newText; }
            set
            {
                _newText = value;
                NotifyOfPropertyChange(() => NewText);
            }
        }
    }
}
