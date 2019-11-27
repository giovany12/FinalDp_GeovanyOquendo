using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using QuadraticEquations.Core.ViewModels;

namespace QuadraticEquations.Android.Views
{
    [Activity(Label = "@string/app_name")]
    public class QuadraticView : MvxActivity<QuadraticViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this.SetContentView(Resource.Layout.QuadraticPage);
        }
    }
}