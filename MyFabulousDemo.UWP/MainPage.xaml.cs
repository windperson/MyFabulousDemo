using Windows.Foundation;
using Windows.UI.ViewManagement;

namespace MyFabulousDemo.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            LoadApplication(new MyFabulousDemo.App());
        }
    }
}
