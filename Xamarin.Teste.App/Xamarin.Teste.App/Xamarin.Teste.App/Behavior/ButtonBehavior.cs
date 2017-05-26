using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin.Teste.App.Behavior
{
    public class ButtonBehavior : Behavior<Button>
    {

        protected override void OnAttachedTo(Button bindable)
        {
            bindable.Clicked += Handle_Clicked;
            base.OnAttachedTo(bindable);
        }

        protected override void OnDetachingFrom(Button bindable)
        {
            bindable.Clicked -= Handle_Clicked;
            base.OnAttachedTo(bindable);
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            var control = ((Button)sender);

            control.TextColor = Color.Orange;
            await Task.Delay(200);
            control.TextColor = Color.Default;
        }

    }
}
