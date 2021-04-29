# Xamarin.RGB
Xamarin plugin for dynamically updating color

The plugin provides a simplistic ContentView that you can wrap elements in to dynamically change Background, Text and PlaceholderColour.

## Colouring Elements

To apply changing colours to a control, simply put it inside `Colourizer` tags

*SomePage.xaml*
```xml
<Colourizer>
<Button Text="Click Me!">
</Colourizer>
```
