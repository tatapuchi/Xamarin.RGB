# Xamarin.RGB

**`NuGet:`** https://www.nuget.org/packages/Xamarin.RGB/

A simplistic `ContentView` that you can wrap elements in to dynamically change background, text and placeholder colour.

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

## How to

There are different ways to cycle through colour values, including speed, direction of cycle, whether you want to cycle through Hue, Saturation, Lightness or Alpha (and so forth).

### Speed
Speed is essentially the speed of cycling, it is in millisedonds. It represents how fast a colour value will be incremented by 0.001f.  
By default this is at 100 ms, but you can increase or decrease the value depending on your own preference.

*SomePage.xaml*
```xml
<ColouredElement Speed="500">
<Button Text="Click Me!">
</ColouredElement>
```

---

### Style
The style of your cycle (Forwards, Backwards or Breathing) is defined within an enum, lets go over what each of these do.

**`Forwards:`** Forwards means that colour values will increment until they reach the max, and then reset and begin again from the min

**`Backwards:`** Backwards means that colour values will decrement until they reach the min, and then reset and begin again from the max

**`Breathing:`** Breathing means that the colour values will increment till the reach the max, then begin to decrement till they reach the min, and repeat this cycle

**Forwards is the default style**

*SomePage.xaml*
```xml
<ColouredElement Style="Breathing">
<Button Text="Click Me!">
</ColouredElement>
```

### HSLA
You can choose what to cycle, it doesnt have to just by Hue, it can also the be Saturation, Luminosity or Alpha value of your colour.  
These are all boolean values that you can set to true or false.  
**Hue is set to true by default**

*SomePage.xaml*
```xml
<ColouredElement Saturation="false" Hue="false" Luminosity="true" Alpha="false">
<Button Text="Click Me!">
</ColouredElement>
```
