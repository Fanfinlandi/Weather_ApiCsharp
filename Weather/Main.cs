using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Weather
{
    public partial class Main : Form
    {
        private const string ApiKey = "c872d05cb94fa438e2a254d7745f9de9"; 
        private const string BaseUrl = "http://api.openweathermap.org/data/2.5/weather";

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private async void search_Click(object sender, EventArgs e)
        {
            string city = City.Text.Trim(); 

            if (string.IsNullOrWhiteSpace(city))
            {
                MessageBox.Show("Wpisz nazwê miasta!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string weatherInfo = await GetWeatherAsync(city);
                Info.Text = weatherInfo;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"B³¹d: {ex.Message}", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task<string> GetWeatherAsync(string city)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"{BaseUrl}?q={Uri.EscapeDataString(city)}&appid={ApiKey}&units=metric&lang=pl";
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    dynamic data = JsonConvert.DeserializeObject(json);

                    return $"Miasto: {data.name}\nTemperatura: {data.main.temp}°C\nWarunki: {data.weather[0].description}";
                    
                }
                else
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    throw new Exception($"B³¹d API: {response.StatusCode}\nTreœæ: {errorContent}");
                }
            }
        }

        private void Info_Click(object sender, EventArgs e)
        {
            
                    }
    }
}
