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

        #region Colour Properties
        #region BackgroundColor Range Properties
        public static readonly BindableProperty BackgroundHueRangeProperty =
            BindableProperty.Create("BackgroundHueRange", typeof(Range), typeof(ColouredElement), Range.FullRange);
        public Range BackgroundHueRange
        {
            get { return (Range)GetValue(BackgroundHueRangeProperty); }
            set { SetValue(BackgroundHueRangeProperty, value); }
        }

        public static readonly BindableProperty BackgroundSaturationRangeProperty =
            BindableProperty.Create("BackgroundSaturationRange", typeof(Range), typeof(ColouredElement), Range.FullRange);
        public Range BackgroundSaturationRange
        {
            get { return (Range)GetValue(BackgroundSaturationRangeProperty); }
            set { SetValue(BackgroundSaturationRangeProperty, value); }
        }

        public static readonly BindableProperty BackgroundLuminosityRangeProperty =
    BindableProperty.Create("BackgroundLuminosityRange", typeof(Range), typeof(ColouredElement), Range.FullRange);
        public Range BackgroundLuminosityRange
        {
            get { return (Range)GetValue(BackgroundLuminosityRangeProperty); }
            set { SetValue(BackgroundLuminosityRangeProperty, value); }
        }

        public static readonly BindableProperty BackgroundAlphaRangeProperty =
            BindableProperty.Create("BackgroundAlphaRange", typeof(Range), typeof(ColouredElement), Range.FullRange);
        public Range BackgroundAlphaRange
        {
            get { return (Range)GetValue(BackgroundAlphaRangeProperty); }
            set { SetValue(BackgroundAlphaRangeProperty, value); }
        }
        #endregion

        #region TextColor Range Properties
        public static readonly BindableProperty TextHueRangeProperty =
            BindableProperty.Create("TextHueRange", typeof(Range), typeof(ColouredElement), Range.FullRange);
        public Range TextHueRange
        {
            get { return (Range)GetValue(TextHueRangeProperty); }
            set { SetValue(TextHueRangeProperty, value); }
        }

        public static readonly BindableProperty TextSaturationRangeProperty =
            BindableProperty.Create("TextSaturationRange", typeof(Range), typeof(ColouredElement), Range.FullRange);
        public Range TextSaturationRange
        {
            get { return (Range)GetValue(TextSaturationRangeProperty); }
            set { SetValue(TextSaturationRangeProperty, value); }
        }

        public static readonly BindableProperty TextLuminosityRangeProperty =
    BindableProperty.Create("TextLuminosityRange", typeof(Range), typeof(ColouredElement), Range.FullRange);
        public Range TextLuminosityRange
        {
            get { return (Range)GetValue(TextLuminosityRangeProperty); }
            set { SetValue(TextLuminosityRangeProperty, value); }
        }

        public static readonly BindableProperty TextAlphaRangeProperty =
            BindableProperty.Create("TextAlphaRange", typeof(Range), typeof(ColouredElement), Range.FullRange);
        public Range TextAlphaRange
        {
            get { return (Range)GetValue(TextAlphaRangeProperty); }
            set { SetValue(TextAlphaRangeProperty, value); }
        }
        #endregion

        #region PlaceholderColor Range Properties
        public static readonly BindableProperty PlaceholderHueRangeProperty =
            BindableProperty.Create("PlaceholderHueRange", typeof(Range), typeof(ColouredElement), Range.FullRange);
        public Range PlaceholderHueRange
        {
            get { return (Range)GetValue(PlaceholderHueRangeProperty); }
            set { SetValue(PlaceholderHueRangeProperty, value); }
        }

        public static readonly BindableProperty PlaceholderSaturationRangeProperty =
            BindableProperty.Create("PlaceholderSaturationRange", typeof(Range), typeof(ColouredElement), Range.FullRange);
        public Range PlaceholderSaturationRange
        {
            get { return (Range)GetValue(PlaceholderSaturationRangeProperty); }
            set { SetValue(PlaceholderSaturationRangeProperty, value); }
        }

        public static readonly BindableProperty PlaceholderLuminosityRangeProperty =
    BindableProperty.Create("PlaceholderLuminosityRange", typeof(Range), typeof(ColouredElement), Range.FullRange);
        public Range PlaceholderLuminosityRange
        {
            get { return (Range)GetValue(PlaceholderLuminosityRangeProperty); }
            set { SetValue(PlaceholderLuminosityRangeProperty, value); }
        }

        public static readonly BindableProperty PlaceholderAlphaRangeProperty =
            BindableProperty.Create("PlaceholderAlphaRange", typeof(Range), typeof(ColouredElement), Range.FullRange);
        public Range PlaceholderAlphaRange
        {
            get { return (Range)GetValue(PlaceholderAlphaRangeProperty); }
            set { SetValue(PlaceholderAlphaRangeProperty, value); }
        }
        #endregion

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