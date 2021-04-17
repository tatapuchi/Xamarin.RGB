using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Xamarin.RGB
{
    public class ColouredElement : ContentView, IColoured
    {
        private bool contentSet = false;
        private bool breathing = true;
        private Label _label;
        private Entry _entry;
        private Editor _editor;
        private Button _button;

        public double HueValue = 0d;
        public double SaturationValue = 1d;
        public double LuminosityValue = 0.5d;
        public double AlphaValue = 1d;


        public static readonly BindableProperty SpeedProperty = BindableProperty.Create("Speed", typeof(int), typeof(ColouredElement), 100);
        public int Speed
        {
            get { return (int)GetValue(SpeedProperty); }
            set { SetValue(SpeedProperty, value); }
        }

        #region Colorization Types
        public static readonly BindableProperty HueProperty =
            BindableProperty.Create("Hue", typeof(bool), typeof(ColouredElement), true);
        public bool Hue
        {
            get { return (bool)GetValue(HueProperty); }
            set { SetValue(HueProperty, value); }
        }


        public static readonly BindableProperty SaturationProperty =
            BindableProperty.Create("Saturation", typeof(bool), typeof(ColouredElement), false);
        public bool Saturation
        {
            get { return (bool)GetValue(SaturationProperty); }
            set { SetValue(SaturationProperty, value); }
        }

        public static readonly BindableProperty LuminosityProperty =
            BindableProperty.Create("Luminosity", typeof(bool), typeof(ColouredElement), false);
        public bool Luminosity
        {
            get { return (bool)GetValue(LuminosityProperty); }
            set { SetValue(LuminosityProperty, value); }
        }

        public static readonly BindableProperty AlphaProperty =
            BindableProperty.Create("Alpha", typeof(bool), typeof(ColouredElement), false);
        public bool Alpha
        {
            get { return (bool)GetValue(AlphaProperty); }
            set { SetValue(AlphaProperty, value); }
        }


        public static readonly BindableProperty BackgroundColorProperty =
            BindableProperty.Create("BackgroundColor", typeof(bool), typeof(ColouredElement), true);
        public bool BackgroundColor
        {
            get { return (bool)GetValue(BackgroundColorProperty); }
            set { SetValue(BackgroundColorProperty, value); }
        }

        public static readonly BindableProperty TextColorProperty =
            BindableProperty.Create("TextColor", typeof(bool), typeof(ColouredElement), false);
        public bool TextColor
        {
            get { return (bool)GetValue(TextColorProperty); }
            set { SetValue(TextColorProperty, value); }
        }

        public static readonly BindableProperty PlaceholderColorProperty =
            BindableProperty.Create("PlaceholderColor", typeof(bool), typeof(ColouredElement), false);
        public bool PlaceholderColor
        {
            get { return (bool)GetValue(PlaceholderColorProperty); }
            set { SetValue(PlaceholderColorProperty, value); }
        }


        public static readonly BindableProperty StyleProperty =
            BindableProperty.Create("Style", typeof(CycleStyle), typeof(ColouredElement), CycleStyle.Forwards);
        public CycleStyle Style
        {
            get { return (CycleStyle)GetValue(StyleProperty); }
            set { SetValue(StyleProperty, value); }
        }
        #endregion

        public ColouredElement()
        {

            Task.Run(async () =>
            {
                Ctor();

                while (true)
                {
                    CycleValues();

                    Device.BeginInvokeOnMainThread(() =>
                    {
                        if (BackgroundColor) { UpdateBackgroundColor(); }
                        if (TextColor) { UpdateTextColor(); }
                        if (PlaceholderColor) { UpdatePlaceholderColor(); }

                    });

                    await Task.Delay(Speed);
                }


            });

        }

        #region Updating Methods
        public void CycleValues()
        {
            if (Hue) { Cycle(ref HueValue, Style); }
            if (Saturation) { Cycle(ref SaturationValue, Style); }
            if (Luminosity) { Cycle(ref LuminosityValue, Style); }
            if (Alpha) { Cycle(ref AlphaValue, Style); }
        }
        public void Cycle(ref double value, CycleStyle style)
        {
            if (Style == CycleStyle.Forwards)
            {
                if (value > 0.99) { value = 0; }
                value += 0.001;
            }

            if (Style == CycleStyle.Backwards)
            {
                if (value < 0.01) { value = 1; }
                value -= 0.001;
            }

            if (Style == CycleStyle.Breathing)
            {
                //If true cycle upwards
                if (breathing)
                {
                    if (value > 0.99) { breathing = !breathing; }
                    value += 0.001;
                }
                //If false cycle downwards
                if (!breathing)
                {
                    if (value < 0.01) { breathing = !breathing; }
                    value -= 0.001;
                }
            }
        }


        public void UpdateBackgroundColor()
        {
            Content.BackgroundColor = Color.FromHsla(HueValue, SaturationValue, LuminosityValue, AlphaValue);
        }

        public void UpdateTextColor()
        {
            if (_label != null)
            {
                _label.TextColor = Color.FromHsla(Offset(HueValue, Hue), Offset(SaturationValue, Saturation), Offset(LuminosityValue, Luminosity), Offset(AlphaValue, Alpha));
            }

            if (_entry != null)
            {
                _entry.TextColor = Color.FromHsla(Offset(HueValue, Hue), Offset(SaturationValue, Saturation), Offset(LuminosityValue, Luminosity), Offset(AlphaValue, Alpha));
            }

            if (_editor != null)
            {
                _editor.TextColor = Color.FromHsla(Offset(HueValue, Hue), Offset(SaturationValue, Saturation), Offset(LuminosityValue, Luminosity), Offset(AlphaValue, Alpha));
            }

            if (_button != null)
            {
                _button.TextColor = Color.FromHsla(Offset(HueValue, Hue), Offset(SaturationValue, Saturation), Offset(LuminosityValue, Luminosity), Offset(AlphaValue, Alpha));
            }

        }

        public void UpdatePlaceholderColor()
        {
            if (_entry != null)
            {
                _entry.PlaceholderColor = Color.FromHsla(Offset(HueValue, Hue), Offset(SaturationValue, Saturation), Offset(LuminosityValue, Luminosity), Offset(AlphaValue, Alpha));
            }

            if (_editor != null)
            {
                _editor.PlaceholderColor = Color.FromHsla(Offset(HueValue, Hue), Offset(SaturationValue, Saturation), Offset(LuminosityValue, Luminosity), Offset(AlphaValue, Alpha));
            }
        }
        #endregion

        public void Ctor()
        {
            if (contentSet) { return; }
            contentSet = true;
            if (Content is Label) { _label = Content as Label; }
            if (Content is Entry) { _entry = Content as Entry; }
            if (Content is Editor) { _editor = Content as Editor; }
            if (Content is Button) { _button = Content as Button; }
        }

        public double Offset(double value, bool shouldChange)
        {
            if (!shouldChange) { return value; }

            if (Style == CycleStyle.Forwards || (breathing && Style == CycleStyle.Breathing))
            {
                double x = value + 0.5d;
                if (x < 1) { return x; }
                return x - 1;
            }

            if (Style == CycleStyle.Backwards || (!breathing && Style == CycleStyle.Breathing))
            {
                double x = value - 0.5d;
                if (x > 0) { return x; }
                return x + 1;
            }

            return 0;
        }

    }
}