using System;
using System.Collections.Generic;
using System.Text;

namespace Bertuzzi.MAUI.BehaviorValidationPack
{
    public class CPFCNPJValidationBehavior : Behavior<Entry>
    {

        private static Color DefaultColor;

        protected override void OnAttachedTo(Entry bindable)
        {
            bindable.Unfocused += Bindable_Unfocused;
            DefaultColor = bindable.TextColor;
            base.OnAttachedTo(bindable);
        }


        protected override void OnDetachingFrom(Entry bindable)
        {
            bindable.Unfocused -= Bindable_Unfocused;
            base.OnDetachingFrom(bindable);
        }

        void Bindable_Unfocused(object sender, FocusEventArgs e)
        {
            bool IsValid = Validators.CpfCnpjValidator(((Entry)sender).ValidatedText());
            ((Entry)sender).TextColor = IsValid ? DefaultColor : Color.FromRgb(255, 0, 0);
        }
    }
}
