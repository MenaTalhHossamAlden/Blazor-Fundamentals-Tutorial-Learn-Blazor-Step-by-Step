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

#### Enhanced Navigation & Form Handling in Blazor

Blazor can enhance page navigation and form handling. Enhanced navigation in Blazor allows users to navigate between different pages or components within a Blazor application while preserving the application state. Users can transition between different views faster and smoother without full page reloads. What happens in the background is that Blazor intercepts the navigation and makes a fetch request to the server. Blazor receives the HTML from the server and then applies the needed changes to the DOM. Blazor enhanced navigation by default while forms can be optionally enhanced if you want to.

### streaming rendering

Streaming rendering allows your application to render parts of a web page or component as data becomes available from the server. This mode is particularly useful when your page needs to perform some long asynchronous tasks before it fully renders, such as making a fetch request to an API or pulling data from the database. 

With streaming rendering in Blazor, the server starts sending HTML content to the client as soon as it's available, rather than waiting for the entire page or component to be fully available. You usually see some placeholder content, like loading messages, on the screen. This allows users to interact with the application sooner, even before the content is fully loaded. When the asynchronous tasks complete, the rest of the content will be rendered.


# Interactive Rendering Modes in Blazor

To create fully interactive Blazor components capable of handling UI events from the browser, Blazor offers two primary interactive render modes: Interactive Server Rendering and Interactive WebAssembly Rendering.

![Interactive Server Rendering](https://github.com/user-attachments/assets/ab8aee30-3da0-4b89-8090-164de6fa8f26)

## Interactive Server Rendering

Interactive Server Rendering manages UI events from the server via a WebSocket connection with the browser. Blazor transmits UI events to the server through this connection, then Blazor updates the browser DOM with the rendered changes.

### How It Works

1. **UI Event Handling**: When a user interacts with the UI (e.g., clicks a button), the event is sent to the server over a WebSocket connection.
2. **Server-Side Processing**: The server processes the event, updates the application state, and renders the necessary changes.
3. **DOM Update**: The server sends the updated HTML back to the client, where Blazor updates the DOM accordingly.

### Advantages and Disadvantages

- **Advantages**:
  - Quick initial load times since only necessary data is sent.
  - Server-side rendering ensures the application logic remains on the server.
- **Disadvantages**:
  - Requires a constant open connection with the server, which can increase server costs.
  - Potential latency issues due to round-trip time between client and server.

## Interactive WebAssembly Rendering

Alternatively, Blazor components can utilize the Interactive WebAssembly Render Mode for interactive rendering on the client side. In this mode, the component code is downloaded to the browser and executed client-side using a WebAssembly-based .NET runtime.

### How It Works

1. **Client-Side Execution**: The Blazor app runs in the browser using WebAssembly.
2. **UI Event Handling**: When a user interacts with the UI, the event is processed directly in the browser without involving the server.
3. **DOM Update**: The application state is updated, and the DOM is modified accordingly on the client-side.

### Advantages and Disadvantages

- **Advantages**:
  - Reduces server workload by offloading processing to the client.
  - No constant server connection required, eliminating latency issues related to server round-trips.
- **Disadvantages**:
  - Initially has a longer load time while the .NET runtime is downloaded.
  - The .NET runtime is cached for future use, improving load times on subsequent visits.

## Summary

Blazor offers two primary interactive render modes to handle UI events and application state:

- **Interactive Server Rendering**: Manages UI events from the server via a WebSocket connection, transmitting events to the server and updating the browser DOM with rendered changes. This mode ensures server-side logic but requires a constant connection.
- **Interactive WebAssembly Rendering**: Executes the Blazor app entirely on the client-side using WebAssembly, handling UI events and state directly in the browser. This mode offloads processing to the client, reducing server workload but has a longer initial load time.

Both modes provide powerful capabilities for building fully interactive Blazor components, allowing you to choose the approach that best suits your application's needs.


