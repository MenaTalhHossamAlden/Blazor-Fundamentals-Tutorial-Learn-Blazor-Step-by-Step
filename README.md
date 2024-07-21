## Overview

Blazor is a modern front-end web framework part of the .NET platform based on HTML, CSS, and C# that helps you build web apps faster.

## Why Blazor?

This framework allows us to build our entire web app from the front end to the back end using a single development stack. It has a component-based architecture. A Blazor component is a reusable piece of web UI that encapsulates its rendering and UI event handling logic. You can create your own components, but Blazor also provides many built-in components for various use cases.

In Blazor, components can be rendered from both the server and the client to deliver the best possible web app experience. Depending on the interactivity required, different components or even pages within the same application can be rendered from the server, the client, or a combination of both.

Blazor is not limited to web applications; it is also capable of building native mobile and desktop apps through a hybrid approach known as Blazor Hybrid, blending native and web technologies.

## Project Structure

MyBlazorApp/\
│\
├── Components/ # Reusable UI components\
│   ├── App.razor # App/root component\
│   ├── Pages/ # Razor pages\
│   └── Layouts/ # Layout components\
│\
├── wwwroot/ # Static assets (CSS, JS, images)\
│\
└── Program.cs # Client-side entry point

## Data Binding

Connecting our application's UI with underlying data sources can be achieved through data binding. There are two types of data binding in Blazor:

### One-Way Data Binding

One-way data binding allows data to flow in a single direction. This is typically used when you need to display data from your C# code or a database in the UI.

#### Example:
```razor
<h3>One-Way Data Binding</h3>

<p>@message</p>

@code {
    private string message = "Hello, Blazor!";
}
```
### Two-Way Data Binding
Two-way data binding allows for a mutual exchange of data between the UI and the data model. This means that whenever a value changes in the UI, it updates the C# code or the data in the database, and vice versa. Changes in the C# code also update the UI. We can use the @bind attribute to bind our input. The content of the input will be bound to the property.

#### Example:
```razor
<h3>Two-Way Data Binding</h3>

<input @bind="name" />
<p>Your name is: @name</p>

@code {
    private string name = string.Empty;
}
```

## Render Modes
### static server-side rendering
By default, our components are statically rendered from the server. This means that as soon as a request is routed to our component, plain HTML will be rendered as a response from the server, and no state is maintained on the server. Static components are great when you do not need to handle UI events from users but only want to render some plain HTML.

Most of the components in our default Blazor app are statically rendered, such as the homepage, the weather page, or the layout component.

# Enhanced Navigation & Form Handling in Blazor

Blazor can enhance page navigation and form handling. Enhanced navigation in Blazor allows users to navigate between different pages or components within a Blazor application while preserving the application state. Users can transition between different views faster and smoother without full page reloads. What happens in the background is that Blazor intercepts the navigation and makes a fetch request to the server. Blazor receives the HTML from the server and then applies the needed changes to the DOM. Blazor enhanced navigation by default while forms can be optionally enhanced if you want to.


