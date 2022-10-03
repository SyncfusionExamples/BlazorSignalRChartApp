using BlazorSignalRChartApp.Data;
using Microsoft.AspNetCore.SignalR;
namespace BlazorSignalRChartApp.Server.Hubs
{
    public class ChartHub : Hub
    {
        public async Task UpdateData()
        {

            await Clients.All.SendAsync("ReceiveMessage", GetData());
        }

        public static List<ChartData> GetData()
        {
            var r = new Random();
            return new List<ChartData>()
        {
            new ChartData { Date = new DateTime(2022, 2, 2), Value = r.Next(1, 40) },
            new ChartData { Date = new DateTime(2022, 3, 2), Value = r.Next(1, 40) },
            new ChartData { Date = new DateTime(2022, 4, 2), Value = r.Next(1, 40) },
            new ChartData { Date = new DateTime(2022, 5, 2), Value = r.Next(1, 40) }
        };
        }

    }
}
