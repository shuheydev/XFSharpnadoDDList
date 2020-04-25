using Xamarin.Forms;
using XFSharpnadoDDList.Infrastructures;

namespace XFSharpnadoDDList.Models
{
    public class Person : BindableBase
    {
        private string _name;
        public string Name { get => _name; set => SetProperty(ref _name, value); }

        private ImageSource _imageSrc;
        public ImageSource ImageSrc { get => _imageSrc; set => SetProperty(ref _imageSrc, value); }
    }
}