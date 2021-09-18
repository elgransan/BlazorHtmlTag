# Blazor DynamicTag 
A minimal component for dynamic generating HTML Tags

- In development

## Use Cases

* In general, when you create a Blazor Component but you want the user selects the base tag for the component.
* For instance, A draggable comonent could have a "div" as base tag, but the user wants to be a list "ul" or "ol"
* Or if you have a css layout and an extra "div" on a component makes the css styles break out

#### Usage:

1) Add DynamicTag project or only the DynamicTag.razor.cs file

2) Use it in this way

```html
<DynamicTag Tag="span" class="alert alert-primary" title="hello">
	hello <strong>!!!</strong>
</DynamicTag>
```

The DynamicTag will render

```html
<span class="alert alert-primary" title="hello">
	hello <strong>!!!</strong>
</span>
```
