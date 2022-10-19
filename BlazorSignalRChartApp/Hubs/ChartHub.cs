using BlazorSignalRChartApp.Data;
using Microsoft.AspNetCore.SignalR;
namespace BlazorSignalRChartApp.Server.Hubs
{
    public class ChartHub : Hub
    {
        Random random = new Random();
        DateTime date = new DateTime(2022, 1, 1);

        public async Task UpdateData(List<ChartData> data = null)
        {
            if (data == null)
            {
                await Clients.All.SendAsync("ReceiveMessage", GetInitialData());
            } else
            {
                await Clients.All.SendAsync("ReceiveMessage", GetData(data));
            }
        }

        public List<ChartData> GetInitialData()
        {
            List<ChartData> data = new List<ChartData>();
            for (int i = 0; i < 4; i++)
            {
                data.Add(new ChartData { Date = date.AddDays(i), Value = random.Next(10, 40) });
            }
            return data;
        }
        public List<ChartData> GetData(List<ChartData> data)
        {
            data.Add(new ChartData { Date = date.AddDays(data.Count), Value = random.Next(10, 40) });
            return data;
        }

    }
}
