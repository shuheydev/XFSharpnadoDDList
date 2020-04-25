using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using XFSharpnadoDDList.Infrastructures;
using XFSharpnadoDDList.Models;
using XFSharpnadoDDList.SampleData;

namespace XFSharpnadoDDList.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        public MainPageViewModel()
        {
            this.People = SampleDataGenerator.GetPeople();
        }

        private ObservableCollection<Person> _people;
        public ObservableCollection<Person> People
        {
            get => _people;
            set => SetProperty(ref _people, value);
        }

 
    }
}
