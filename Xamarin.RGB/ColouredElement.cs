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

        // Set colour to Content.BackgroundColor.Saturation
        private double backgroundHue = 0f, backgroundSaturation = 1f, backgroundLuminosity = 0.5f, backgroundAlpha = 1f;
        private double textHue = 0f, textSaturation = 1f, textLuminosity = 0.5f, textAlpha = 1f;
        private double placeholderHue = 0f, placeholderSaturation = 1f, placeholderLuminosity = 0.5f, placeholderAlpha = 1f;


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

        #region BackgroundColor Offset Properties
        public static readonly BindableProperty BackgroundHueOffsetProperty =
    BindableProperty.Create("BackgroundHueOffset", typeof(double), typeof(ColouredElement), 0d);
        public double BackgroundHueOffset
        {
            get { return (double)GetValue(BackgroundHueOffsetProperty); }
            set { SetValue(BackgroundHueOffsetProperty, value); }
        }

        public static readonly BindableProperty BackgroundSaturationOffsetProperty =
            BindableProperty.Create("BackgroundSaturationOffset", typeof(double), typeof(ColouredElement), 0d);
        public double BackgroundSaturationOffset
        {
            get { return (double)GetValue(BackgroundSaturationOffsetProperty); }
            set { SetValue(BackgroundSaturationOffsetProperty, value); }
        }

        public static readonly BindableProperty BackgroundLuminosityOffsetProperty =
    BindableProperty.Create("BackgroundLuminosityOffset", typeof(double), typeof(ColouredElement), 0d);
        public double BackgroundLuminosityOffset
        {
            get { return (double)GetValue(BackgroundLuminosityOffsetProperty); }
            set { SetValue(BackgroundLuminosityOffsetProperty, value); }
        }

        public static readonly BindableProperty BackgroundAlphaOffsetProperty =
            BindableProperty.Create("BackgroundAlphaOffset", typeof(double), typeof(ColouredElement), 0d);
        public double BackgroundAlphaOffset
        {
            get { return (double)GetValue(BackgroundAlphaOffsetProperty); }
            set { SetValue(BackgroundAlphaOffsetProperty, value); }
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

        #region TextColor Offset Properties
        public static readonly BindableProperty TextHueOffsetProperty =
    BindableProperty.Create("TextHueOffset", typeof(double), typeof(ColouredElement), 0d);
        public double TextHueOffset
        {
            get { return (double)GetValue(TextHueOffsetProperty); }
            set { SetValue(TextHueOffsetProperty, value); }
        }

        public static readonly BindableProperty TextSaturationOffsetProperty =
            BindableProperty.Create("TextSaturationOffset", typeof(double), typeof(ColouredElement), 0d);
        public double TextSaturationOffset
        {
            get { return (double)GetValue(TextSaturationOffsetProperty); }
            set { SetValue(TextSaturationOffsetProperty, value); }
        }

        public static readonly BindableProperty TextLuminosityOffsetProperty =
    BindableProperty.Create("TextLuminosityOffset", typeof(double), typeof(ColouredElement), 0d);
        public double TextLuminosityOffset
        {
            get { return (double)GetValue(TextLuminosityOffsetProperty); }
            set { SetValue(TextLuminosityOffsetProperty, value); }
        }

        public static readonly BindableProperty TextAlphaOffsetProperty =
            BindableProperty.Create("TextAlphaOffset", typeof(double), typeof(ColouredElement), 0d);
        public double TextAlphaOffset
        {
            get { return (double)GetValue(TextAlphaOffsetProperty); }
            set { SetValue(TextAlphaOffsetProperty, value); }
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

        #region PlaceholderColor Offset Properties
        public static readonly BindableProperty PlaceholderHueOffsetProperty =
    BindableProperty.Create("PlaceholderHueOffset", typeof(double), typeof(ColouredElement), 0d);
        public double PlaceholderHueOffset
        {
            get { return (double)GetValue(PlaceholderHueOffsetProperty); }
            set { SetValue(PlaceholderHueOffsetProperty, value); }
        }

        public static readonly BindableProperty PlaceholderSaturationOffsetProperty =
            BindableProperty.Create("PlaceholderSaturationOffset", typeof(double), typeof(ColouredElement), 0d);
        public double PlaceholderSaturationOffset
        {
            get { return (double)GetValue(PlaceholderSaturationOffsetProperty); }
            set { SetValue(PlaceholderSaturationOffsetProperty, value); }
        }

        public static readonly BindableProperty PlaceholderLuminosityOffsetProperty =
    BindableProperty.Create("PlaceholderLuminosityOffset", typeof(double), typeof(ColouredElement), 0d);
        public double PlaceholderLuminosityOffset
        {
            get { return (double)GetValue(PlaceholderLuminosityOffsetProperty); }
            set { SetValue(PlaceholderLuminosityOffsetProperty, value); }
        }

        public static readonly BindableProperty PlaceholderAlphaOffsetProperty =
            BindableProperty.Create("PlaceholderAlphaOffset", typeof(double), typeof(ColouredElement), 0d);
        public double PlaceholderAlphaOffset
        {
            get { return (double)GetValue(PlaceholderAlphaOffsetProperty); }
            set { SetValue(PlaceholderAlphaOffsetProperty, value); }
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
            BindableProperty.Create("Style", typeof(CycleStyle), typeof(ColouredElement), CycleStyle.Forwards);
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

                    CycleAllColours();

                    Device.BeginInvokeOnMainThread(() =>
                    {
                        if (BackgroundColor)
                        {
                            if (Hue) { Content.BackgroundColor = Color.FromHsla(ComputeValue(backgroundHue, BackgroundHueOffset, BackgroundHueRange), 
                                Content.BackgroundColor.Saturation, Content.BackgroundColor.Luminosity, Content.BackgroundColor.A); }

                            if (Saturation)
                            {
                                Content.BackgroundColor = Color.FromHsla(Content.BackgroundColor.Hue,
                            ComputeValue(backgroundSaturation, BackgroundSaturationOffset, BackgroundSaturationRange), Content.BackgroundColor.Luminosity, Content.BackgroundColor.A);
                            }

                            if (Luminosity)
                            {
                                Content.BackgroundColor = Color.FromHsla(Content.BackgroundColor.Hue, Content.BackgroundColor.Saturation,
                            ComputeValue(backgroundLuminosity, BackgroundLuminosityOffset, BackgroundLuminosityRange), Content.BackgroundColor.A);
                            }

                            if (Alpha)
                            {
                                Content.BackgroundColor = Color.FromHsla(Content.BackgroundColor.Hue, Content.BackgroundColor.Saturation, Content.BackgroundColor.Luminosity,
                            ComputeValue(backgroundAlpha, BackgroundAlphaOffset, BackgroundAlphaRange));
                            }

                        }

                        if (TextColor)
                        {
                            if(_label != null)
                            {
                                if (Hue)
                                {
                                    _label.TextColor = Color.FromHsla(ComputeValue(textHue, TextHueOffset, TextHueRange),
                                _label.TextColor.Saturation, _label.TextColor.Luminosity, _label.TextColor.A);
                                }

                                if (Saturation)
                                {
                                    _label.TextColor = Color.FromHsla(_label.TextColor.Hue,
                                ComputeValue(textSaturation, TextSaturationOffset, TextSaturationRange), _label.TextColor.Luminosity, _label.TextColor.A);
                                }

                                if (Luminosity)
                                {
                                    _label.TextColor = Color.FromHsla(_label.TextColor.Hue, _label.TextColor.Saturation,
                                ComputeValue(textLuminosity, TextLuminosityOffset, TextLuminosityRange), _label.TextColor.A);
                                }

                                if (Alpha)
                                {
                                    _label.TextColor = Color.FromHsla(_label.TextColor.Hue, _label.TextColor.Saturation, _label.TextColor.Luminosity,
                                ComputeValue(textAlpha, TextAlphaOffset, TextAlphaRange));
                                }
                            }

                            if (_entry != null)
                            {
                                if (Hue)
                                {
                                    _entry.TextColor = Color.FromHsla(ComputeValue(textHue, TextHueOffset, TextHueRange),
                                _entry.TextColor.Saturation, _entry.TextColor.Luminosity, _entry.TextColor.A);
                                }

                                if (Saturation)
                                {
                                    _entry.TextColor = Color.FromHsla(_entry.TextColor.Hue,
                                ComputeValue(textSaturation, TextSaturationOffset, TextSaturationRange), _entry.TextColor.Luminosity, _entry.TextColor.A);
                                }

                                if (Luminosity)
                                {
                                    _entry.TextColor = Color.FromHsla(_entry.TextColor.Hue, _entry.TextColor.Saturation,
                                ComputeValue(textLuminosity, TextLuminosityOffset, TextLuminosityRange), _entry.TextColor.A);
                                }

                                if (Alpha)
                                {
                                    _entry.TextColor = Color.FromHsla(_entry.TextColor.Hue, _entry.TextColor.Saturation, _entry.TextColor.Luminosity,
                                ComputeValue(textAlpha, TextAlphaOffset, TextAlphaRange));
                                }
                            }

                            if (_editor != null)
                            {
                                if (Hue)
                                {
                                    _editor.TextColor = Color.FromHsla(ComputeValue(textHue, TextHueOffset, TextHueRange),
                                _editor.TextColor.Saturation, _editor.TextColor.Luminosity, _editor.TextColor.A);
                                }

                                if (Saturation)
                                {
                                    _editor.TextColor = Color.FromHsla(_editor.TextColor.Hue,
                                ComputeValue(textSaturation, TextSaturationOffset, TextSaturationRange), _editor.TextColor.Luminosity, _editor.TextColor.A);
                                }

                                if (Luminosity)
                                {
                                    _editor.TextColor = Color.FromHsla(_editor.TextColor.Hue, _editor.TextColor.Saturation,
                                ComputeValue(textLuminosity, TextLuminosityOffset, TextLuminosityRange), _editor.TextColor.A);
                                }

                                if (Alpha)
                                {
                                    _editor.TextColor = Color.FromHsla(_editor.TextColor.Hue, _editor.TextColor.Saturation, _editor.TextColor.Luminosity,
                                ComputeValue(textAlpha, TextAlphaOffset, TextAlphaRange));
                                }
                            }

                            if (_button != null)
                            {
                                if (Hue)
                                {
                                    _button.TextColor = Color.FromHsla(ComputeValue(textHue, TextHueOffset, TextHueRange),
                                _button.TextColor.Saturation, _button.TextColor.Luminosity, _button.TextColor.A);
                                }

                                if (Saturation)
                                {
                                    _button.TextColor = Color.FromHsla(_button.TextColor.Hue,
                                ComputeValue(textSaturation, TextSaturationOffset, TextSaturationRange), _button.TextColor.Luminosity, _button.TextColor.A);
                                }

                                if (Luminosity)
                                {
                                    _button.TextColor = Color.FromHsla(_button.TextColor.Hue, _button.TextColor.Saturation,
                                ComputeValue(textLuminosity, TextLuminosityOffset, TextLuminosityRange), _button.TextColor.A);
                                }

                                if (Alpha)
                                {
                                    _button.TextColor = Color.FromHsla(_button.TextColor.Hue, _button.TextColor.Saturation, _entry.TextColor.Luminosity,
                                ComputeValue(textAlpha, TextAlphaOffset, TextAlphaRange));
                                }
                            }

                        }

                        if (PlaceholderColor)
                        {
                            if (_entry != null)
                            {
                                if (Hue)
                                {
                                    _entry.PlaceholderColor = Color.FromHsla(ComputeValue(placeholderHue, PlaceholderHueOffset, PlaceholderHueRange),
                                _entry.TextColor.Saturation, _entry.TextColor.Luminosity, _entry.TextColor.A);
                                }

                                if (Saturation)
                                {
                                    _entry.PlaceholderColor = Color.FromHsla(_entry.TextColor.Hue,
                                ComputeValue(placeholderSaturation, PlaceholderSaturationOffset, PlaceholderSaturationRange), _entry.TextColor.Luminosity, _entry.TextColor.A);
                                }

                                if (Luminosity)
                                {
                                    _entry.PlaceholderColor = Color.FromHsla(_entry.TextColor.Hue, _entry.TextColor.Saturation,
                                ComputeValue(placeholderLuminosity, PlaceholderLuminosityOffset, PlaceholderLuminosityRange), _entry.TextColor.A);
                                }

                                if (Alpha)
                                {
                                    _entry.PlaceholderColor = Color.FromHsla(_entry.TextColor.Hue, _entry.TextColor.Saturation, _entry.TextColor.Luminosity,
                                ComputeValue(placeholderAlpha, PlaceholderAlphaOffset, PlaceholderAlphaRange));
                                }
                            }

                            if (_editor != null)
                            {
                                if (Hue)
                                {
                                    _editor.PlaceholderColor = Color.FromHsla(ComputeValue(placeholderHue, PlaceholderHueOffset, PlaceholderHueRange),
                                _editor.TextColor.Saturation, _editor.TextColor.Luminosity, _editor.TextColor.A);
                                }

                                if (Saturation)
                                {
                                    _editor.PlaceholderColor = Color.FromHsla(_editor.TextColor.Hue,
                                ComputeValue(placeholderSaturation, PlaceholderSaturationOffset, PlaceholderSaturationRange), _editor.TextColor.Luminosity, _editor.TextColor.A);
                                }

                                if (Luminosity)
                                {
                                    _editor.PlaceholderColor = Color.FromHsla(_editor.TextColor.Hue, _editor.TextColor.Saturation,
                                ComputeValue(placeholderLuminosity, PlaceholderLuminosityOffset, PlaceholderLuminosityRange), _editor.TextColor.A);
                                }

                                if (Alpha)
                                {
                                    _editor.PlaceholderColor = Color.FromHsla(_editor.TextColor.Hue, _editor.TextColor.Saturation, _editor.TextColor.Luminosity,
                                ComputeValue(placeholderAlpha, PlaceholderAlphaOffset, PlaceholderAlphaRange));
                                }
                            }
                        }


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

        public void CycleAllColours()
        {
            CycleColour(ref backgroundHue, BackgroundHueRange);
            CycleColour(ref textHue, TextHueRange);
            CycleColour(ref placeholderHue, PlaceholderHueRange);

            CycleColour(ref backgroundSaturation, BackgroundSaturationRange);
            CycleColour(ref textSaturation, TextSaturationRange);
            CycleColour(ref placeholderSaturation, PlaceholderSaturationRange);

            CycleColour(ref backgroundLuminosity, BackgroundLuminosityRange);
            CycleColour(ref textLuminosity, TextLuminosityRange);
            CycleColour(ref placeholderLuminosity, PlaceholderLuminosityRange);

            CycleColour(ref backgroundAlpha, BackgroundAlphaRange);
            CycleColour(ref textAlpha, TextAlphaRange);
            CycleColour(ref placeholderAlpha, PlaceholderAlphaRange);
        }
        public void CycleColour(ref double value, Range range)
        {
            if(Style == CycleStyle.Forwards)
            {
                if (value > (range.End - 0.01)) { value = range.Start; }
                value += 0.001;
            }

            if(Style == CycleStyle.Backwards)
            {
                if (value > (range.End - 0.01)) { value = range.Start; }
                value += 0.001;
            }

            if(Style == CycleStyle.Breathing)
            {

            }

        }
        public static double ComputeValue(double value, double offset, Range range)
        {
            if ((value + offset) <= range.End)
            { return value + offset; }
            else
            { return (value + offset) - range.Magnitude; }
        }


    }
}