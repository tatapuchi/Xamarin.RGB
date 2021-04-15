using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Xamarin.RGB
{
    public class ColouredElement : ContentView
    {
        private VisualElement _element;
        private Entry _entry;
        private Editor _editor;
        private Label _label;
        private Button _button;

        public ColouredElement()
        {
        }

        #region Enums
        public CycleStyle CycleStyle { get; set; } = CycleStyle.Forwards;
        public ChangeTypes ChangeFlags { get; set; } = ChangeTypes.Hue;
        public ColourizerTypes ColourizerFlags { get; set; } = ColourizerTypes.BackgroundColor;
        #endregion

        #region Colour Properties
        public Offset BackgroundOffset { get; set; } = new Offset(0, Range.FullRange, 0, Range.FullRange, 0, Range.FullRange, 0, Range.FullRange);

        //Adds the offset value to the color
        public Color BackgroundColor { 
            get {
                Ctor();
                return _element.BackgroundColor; 
            }
            set {
                Ctor();
                var hue = Offset.ComputeValue(value.Hue, BackgroundOffset.HueOffset, BackgroundOffset.HueRange);
                var saturation = Offset.ComputeValue(value.Saturation, BackgroundOffset.SaturationOffset, BackgroundOffset.SaturationRange);
                var luminosity = Offset.ComputeValue(value.Luminosity, BackgroundOffset.LuminosityOffset, BackgroundOffset.LuminosityRange);
                var alpha = Offset.ComputeValue(value.A, BackgroundOffset.AlphaOffset, BackgroundOffset.AlphaRange);
                _element.BackgroundColor = Color.FromHsla(hue, saturation, luminosity, alpha);
            }
        }

        public Offset TextColorOffset { get; set; } = new Offset(0, Range.FullRange, 0, Range.FullRange, 0, Range.FullRange, 0, Range.FullRange);

        //Adds the offset value to the color
        public Color TextColor 
        { 
            get
            {
                Ctor();
                if (Content is Entry) { return _entry.TextColor; }
                if (Content is Editor) { return _editor.TextColor; }
                if (Content is Label) { return _label.TextColor; }
                if (Content is Button) { return _button.TextColor; }
            
                return Color.Transparent;
            }

            set
            {
                Ctor();
                var hue = Offset.ComputeValue(value.Hue, TextColorOffset.HueOffset, TextColorOffset.HueRange);
                var saturation = Offset.ComputeValue(value.Saturation, TextColorOffset.SaturationOffset, TextColorOffset.SaturationRange);
                var luminosity = Offset.ComputeValue(value.Luminosity, TextColorOffset.LuminosityOffset, TextColorOffset.LuminosityRange);
                var alpha = Offset.ComputeValue(value.A, TextColorOffset.AlphaOffset, TextColorOffset.AlphaRange);

                if (Content is Entry) { _entry.TextColor = Color.FromHsla(hue, saturation, luminosity, alpha); }
                if (Content is Editor) { _editor.TextColor = Color.FromHsla(hue, saturation, luminosity, alpha); }
                if (Content is Label) { _label.TextColor = Color.FromHsla(hue, saturation, luminosity, alpha); }
                if (Content is Button) { _button.TextColor = Color.FromHsla(hue, saturation, luminosity, alpha); }
            }

        }

        public Offset PlaceholderColorOffset { get; set; } = new Offset(0, Range.FullRange, 0, Range.FullRange, 0, Range.FullRange, 0, Range.FullRange);
        #endregion

        public void Colourize(Color color)
        {
            if (ColourizerFlags.HasFlag(ColourizerTypes.BackgroundColor)) 
            { 
                BackgroundColor = color; 
            }

            if (ColourizerFlags.HasFlag(ColourizerTypes.TextColour)) 
            {
                //if transparent then hasnt been set, meaning no such value exists
                if (TextColor != Color.Transparent) { TextColor = color; }
            }

            if (ColourizerFlags.HasFlag(ColourizerTypes.PlaceholderColour)) 
            { 
                //TODO 
            }

        }

        public void UpdateColorValues(ref double value, Range range)
        {
            if (ChangeFlags.HasFlag(ChangeTypes.Hue))
            {
                
                CycleColour(ref value, range);
            }

            if (ChangeFlags.HasFlag(ChangeTypes.Saturation))
            {
                CycleColour(ref value, range);
            }

            if (ChangeFlags.HasFlag(ChangeTypes.Luminosity))
            {
                CycleColour(ref value, range);
            }

            if (ChangeFlags.HasFlag(ChangeTypes.Alpha))
            {
                CycleColour(ref value, range);
            }

        }

        public void CycleColour(ref double value, Range range)
        {
            if (CycleStyle == CycleStyle.Forwards)
            {
                if (value > (range.End - 0.002)) { value = range.Start; }
                value += 0.001;
            }

            if (CycleStyle == CycleStyle.Backwards)
            {
                if (value > (range.Start + 0.002)) { value = range.End; }
                value -= 0.001;
            }

            if (CycleStyle == CycleStyle.Breathing)
            {
                //will implement in a bit
            }
        }

        private void Ctor()
        {
            if (_element != null) { return; }
            // needs to check its children
            _element = Content;
            if (Content is Entry) { _entry = Content as Entry; }
            if (Content is Editor) { _editor = Content as Editor; }
            if (Content is Label) { _label = Content as Label; }
            if (Content is Button) { _button = Content as Button; }
        }

    }
}