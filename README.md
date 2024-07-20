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
