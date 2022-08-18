using System;
using System.Collections.Generic;
using System.Text;

namespace Bertuzzi.MAUI.BehaviorValidationPack
{
    public class NumberValidationBehavior : Behavior<Entry>
    {
        private static Color DefaultColor;
        protected override void OnAttachedTo(Entry entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            DefaultColor = entry.TextColor;
            base.OnAttachedTo(entry);
        }

        protected override void OnDetachingFrom(Entry entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }

        void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            int result;

            bool isValid = int.TryParse(args.NewTextValue, out result);

            ((Entry)sender).TextColor = isValid ? DefaultColor : Color.FromRgb(255, 0, 0);
        }
    }
}
