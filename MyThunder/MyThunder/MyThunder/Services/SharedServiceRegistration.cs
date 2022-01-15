using ThunderboltIoc;

//Match IConventionalService with ConventionalService
[assembly: ThunderboltRegexInclude(
    ThunderboltServiceLifetime.Scoped,
    regex: @"(global::)?(MyThunder\@Services)\@I[A-Z][A-z_]+Service",
    implRegex: @"(global::)?(ThunderboltIocSamples\.XamarinForms\.Services)\.[A-Z][a-z][A-z_]+Service",
    joinKeyRegex: @"(?<=(global::)?(ThunderboltIocSamples\.XamarinForms\.Services)\.I?)[A-Z][a-z][A-z_]+Service")]

//Include all ViewModels
[assembly: ThunderboltRegexInclude(
    ThunderboltServiceLifetime.Transient,
    regex: @"(global::)?(MyThunder\@ViewModels)\@[A-Z][A-z_]+ViewModel")]

namespace MyThunder.Services
{
    using ThunderboltIoc;

    public partial class SharedServiceRegistration : ThunderboltRegistration
    {
        protected override void Register(IThunderboltRegistrar reg)
        {
            reg.AddSingleton<DataService>();
        }
    }
}
