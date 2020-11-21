using System;
using System.Collections.Generic;
using System.Text;
using KPZProject.ViewModels.Base;

namespace KPZProject.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Window title

        private string _Title = "Title";
        /// <summary>
        /// Window title
        /// </summary>
        public string Title
        {
            get => _Title;
            set
            {
                //if (Equals(_Title, value)) return;
                //_Title = value;
                //OnPropertyChanged();
                Set(ref _Title, value);
            }
        }

        #endregion

    }
}
