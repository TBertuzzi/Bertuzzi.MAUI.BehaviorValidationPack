﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bertuzzi.MAUI.BehaviorValidationPack
{
    public class DateValidationBehavior : Behavior<DatePicker>
    {
        private static Color DefaultColor;
        protected override void OnAttachedTo(DatePicker datepicker)
        {
            datepicker.DateSelected += Datepicker_DateSelected;
            DefaultColor = datepicker.TextColor;
            base.OnAttachedTo(datepicker);
        }

        private void Datepicker_DateSelected(object sender, DateChangedEventArgs e)
        {

            bool isValid = Validators.DateValidator(e.NewDate);
           ((DatePicker)sender).BackgroundColor = isValid ? DefaultColor : Color.FromRgb(255, 0, 0);
        }

        protected override void OnDetachingFrom(DatePicker datepicker)
        {
            datepicker.DateSelected -= Datepicker_DateSelected;
            base.OnDetachingFrom(datepicker);
        }


    }
}
