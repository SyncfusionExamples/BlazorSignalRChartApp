# Blazor SignalR Chart Application

## Overview

This sample demonstrates real-time chart updates using the Syncfusion [Blazor Chart](https://www.syncfusion.com/blazor-components/blazor-charts) component and ASP.NET Core SignalR. The application establishes a SignalR connection between the Blazor client and a server-side hub, allowing chart data to be generated and broadcast dynamically. As new data points are received, the chart refreshes automatically to visualize changing values over time. This implementation provides a practical reference for building live dashboards, monitoring applications, and streaming data visualization scenarios.

## Key Features

- Uses the `SfChart` component to render a real-time line chart.
- Configures `ChartPrimaryXAxis` with `ValueType.DateTime` for time-based visualization.
- Configures `ChartPrimaryYAxis` using `Minimum`, `Maximum`, `Interval`, and `LabelFormat` properties.
- Uses `ChartSeries` with `Type="ChartSeriesType.Line"` to display live data.
- Enables tooltips through `ChartTooltipSettings Enable="true"`.
- Creates a SignalR client connection using `HubConnectionBuilder`.
- Connects to the `/charthub` endpoint using `WithUrl`.
- Invokes the hub method `UpdateData` to request updated chart data.
- Subscribes to the `ReceiveMessage` SignalR event using `hubConnection.On<List<ChartData>>()`.
- Uses a `Timer` with a 2000-millisecond interval to trigger periodic updates.
- Implements the server-side `ChartHub` class to generate and broadcast chart data.
- Uses the `ChartData` model containing `Date` and `Value` properties for chart binding.
- Registers SignalR services with `builder.Services.AddSignalR()`.
- Maps the SignalR endpoint using `app.MapHub<ChartHub>("/charthub")`.

## Prerequisites

- Visual Studio 2022 or Visual Studio Code
- .NET SDK compatible with the project's target framework

## How to Run the Project

**Visual Studio 2022**

1. Clone or download this repository.
2. Open the solution file:

   `BlazorSignalRChartApp.sln`

3. Restore all NuGet packages.
4. Set the startup project to `BlazorSignalRChartApp`.
5. Build the solution.
6. Run the application using **Ctrl+F5**.
7. Open the local URL displayed by the application launch profile.

**Visual Studio Code**

1. Open the repository folder in Visual Studio Code.
2. Open the integrated terminal.
3. Navigate to the project directory:

```bash
cd BlazorSignalRChartApp
```

4. Restore packages and run the application:

```bash
dotnet restore
dotnet run
```

5. Open the local URL displayed in the terminal output.

## Project Structure

- `BlazorSignalRChartApp/Program.cs` — registers Blazor services, SignalR services, Syncfusion services, and maps the `/charthub` endpoint.
- `BlazorSignalRChartApp/Hubs/ChartHub.cs` — SignalR hub implementation containing `UpdateData`, `GetInitialData`, and `GetData` methods.
- `BlazorSignalRChartApp/Pages/Index.razor` — contains the `SfChart`, SignalR connection logic, timer-based updates, and chart data binding.

## Support and Feedback

- For general product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- To report an issue specific to this sample, open a GitHub issue in this repository.
- For official documentation related to Blazor Charts, visit https://help.syncfusion.com/chart-sdk/blazor/charts/getting-started

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.