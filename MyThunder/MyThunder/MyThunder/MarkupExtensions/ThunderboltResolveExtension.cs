namespace MyThunder.MarkupExtensions
{
    using System;

    using ThunderboltIoc;

    using Xamarin.Forms.Xaml;

    public class ThunderboltResolveExtension : IMarkupExtension
    {
        public ThunderboltResolveExtension()
        {
        }
        public ThunderboltResolveExtension(Type type)
        {
            this.Type = type;
        }

        public Type Type { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return this.Type is null ? null : ThunderboltActivator.Container.GetService(this.Type);
        }
    }
}
