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
        private VisualElement _element;
        private Label _label;
        private Entry _entry;
        private Editor _editor;
        private Button _button;


        public static readonly BindableProperty SpeedProperty =
            BindableProperty.Create("Speed", typeof(int), typeof(ColouredElement), 100);
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
            BindableProperty.Create("Style", typeof(CycleStyle), typeof(ColouredElement), false);
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


                    Device.BeginInvokeOnMainThread(() =>
                    {

                    });

                    await Task.Delay(Speed);
                }


            });

        }

        public void Ctor()
        {
            if(_element != null) { return; }
            _element = Content;
            if(Content is Label) { _label = Content as Label; }
            if (Content is Entry) { _entry = Content as Entry; }
            if (Content is Editor) { _editor = Content as Editor; }
            if (Content is Button) { _button = Content as Button; }
        }

    }
}