using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace WpfApp1
{
    public class TestViewModel : INotifyPropertyChanged
    {
        private string _templateId;

        public string TemplateId
        {
            get => _templateId;
            set
            {
                _templateId = value;
                OnPropertyChanged(nameof(TemplateId));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
