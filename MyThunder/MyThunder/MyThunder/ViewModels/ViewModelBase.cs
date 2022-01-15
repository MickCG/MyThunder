namespace MyThunder.ViewModels
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;

    using ThunderboltIoc;

    public abstract class ViewModelBase : INotifyPropertyChanged
    {
        private IThunderboltContainer container;
        protected IThunderboltContainer Container => this.container ?? (this.container = ThunderboltActivator.Container);

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
