using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PropertyApp.ViewModel
{

    public class BaseViewModel : INotifyPropertyChanged
    {
        // Event that is raised when a property value changes.
        public event PropertyChangedEventHandler? PropertyChanged;

 
        /// <param name="propertyName">The name of the property that changed.</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        /// <typeparam name="T">The type of the property.</typeparam>
        /// <param name="backingStore">A reference to the private backing field for the property.</param>
        /// <param name="value">The new value to set.</param>
        /// <param name="propertyName">The name of the property. Automatically inferred.</param>
        /// <returns>True if the value was changed, otherwise false.</returns>
        protected bool SetProperty<T>(ref T backingStore, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
            {
                return false;
            }

            backingStore = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        // You can also add properties for common states, like IsBusy.
        private bool isBusy;
        public bool IsBusy
        {
            get => isBusy;
            set => SetProperty(ref isBusy, value);
        }

        // You can add an example of a command property here if needed.
    }
}
