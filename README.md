# Xamarin.RGB
Xamarin plugin for dynamically updating color

The plugin provides a simplistic ContentView that you can wrap elements in to dynamically change Background, Text and PlaceholderColour.

## Colouring Elements

To apply changing colours to a control, simply put it inside `ColouredElement` tags

*SomePage.xaml*
```xml
<ColouredElement>
<Button Text="Click Me!">
</ColouredElement>
```

---

### Background Colour

To cycle through the background color of a control, you want to set the `BackgroundColor` attribute to true  
**This is true by default**

*SomePage.xaml*
```xml
<ColouredElement BackgroundColor="true">
<Button Text="Click Me!">
</ColouredElement>
```
---

### Text Colour

To cycle through the text color of a control, you want to set the `TextColor` attribute to true

*SomePage.xaml*
```xml
<ColouredElement TextColour="true">
<Button Text="Click Me!">
</ColouredElement>
```

---

### Placeholder Colour

To cycle through the placeholder color of a control, you want to set the `PlaceholderColor` attribute to true

*SomePage.xaml*
```xml
<ColouredElement TextColour="true">
<Button Text="Click Me!">
</ColouredElement>
```

---

## Styling

There are different ways to cycle through colour values, including speed, direction of cycle, whether you want to cycle through Hue, Saturation, Lightness or Alpha (and so forth).

