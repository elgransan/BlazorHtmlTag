# DynamicTag
A minimal component for dynamic generating HTML Tags

- In development

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
