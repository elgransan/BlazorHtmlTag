# Blazor HtmlTag 
A minimal component for dynamic generating HTML Tags

## Installation Nuget Package

Install-Package BlazorDynamicTag

[![NuGet version (BlazorDynamicTag)](https://img.shields.io/nuget/v/BlazorDynamicTag.svg?style=flat-square)](https://www.nuget.org/packages/BlazorDynamicTag/)


## Use Cases

* In general, when you create a Blazor Component but you want the user selects the base tag for the component.
* For instance, A draggable comonent could have a "div" as base tag, but the user wants to be a list "ul" or "ol"
* Or if you want dynamic headers <h1> <h2> <h3> 
* Or if you have a css layout and an extra "div" on a component makes the css styles break out

#### Usage:

1) Add BlazorDynamicTag to your _Imports.razor

```csharp
@using BlazorDynamicTag
```

2) Use it in this way

```html
<HtmlTag Tag="span" class="alert alert-primary" title="hello">
	hello <strong>!!!</strong>
</HtmlTag>
```

The HtmlTag will render

```html
<span class="alert alert-primary" title="hello">
	hello <strong>!!!</strong>
</span>
```
