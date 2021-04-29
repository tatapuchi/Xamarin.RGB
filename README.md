# Xamarin.RGB
Xamarin plugin for dynamically updating color

The plugin provides a simplistic ContentView that you can wrap elements in to dynamically change Background, Text and PlaceholderColour.

## Colouring Elements

To apply changing colours to concretions of VisualElement (most controls) you will create a `ElementColourizer` object, and add elements to it.

*SomePage.xaml*
```xml
<Colourizer>
<Button Text="Click Me!">
</Colourizer>
```
