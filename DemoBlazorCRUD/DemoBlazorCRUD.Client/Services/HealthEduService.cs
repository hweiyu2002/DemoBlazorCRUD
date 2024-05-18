using SharedLibrary.Models;
using SharedLibrary.HealthEduRepositories;
using System.Net.Http.Json;
namespace DemoBlazorCRUD.Client.Services
{
    public class HealthEduService : IHealthEduRepository
    {
        private readonly HttpClient httpClient;
        public HealthEduService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<HealthEdu> AddHealthEduAsync(HealthEdu model)
        {
            var healthEdu = await httpClient.PostAsJsonAsync("api/HealthEdu/Add-HealthEdu", model);
            var response = await healthEdu.Content.ReadFromJsonAsync<HealthEdu>();
            return response!;
        }

        public async Task<HealthEdu> DeleteHealthEduAsync(int healthEduId)
        {
            var healthEdu = await httpClient.DeleteAsync($"api/HealthEdu/Delete-HealthEdu/{healthEduId}");
            var response = await healthEdu.Content.ReadFromJsonAsync<HealthEdu>();
            return response!;
        }

        async Task<List<HealthEdu>> IHealthEduRepository.GetAllHealthEdusAsync()
        {
            var healthEdus = await httpClient.GetAsync("api/HealthEdu/All-HealthEdus");
            var response = await healthEdus.Content.ReadFromJsonAsync<List<HealthEdu>>();
            return response!;
        }

        public async Task<HealthEdu> GetHealthEduByIdAsync(int healthEduId)
        {
            var healthEdu = await httpClient.GetAsync($"api/HealthEdu/Single-HealthEdu/{healthEduId}");
            var response = await healthEdu.Content.ReadFromJsonAsync<HealthEdu>();
            return response!;
        }

        public async Task<HealthEdu> UpdateHealthEduAsync(HealthEdu model)
        {
            var healthEdu = await httpClient.PutAsJsonAsync("api/HealthEdu/Update-HealthEdu", model);
            var response = await healthEdu.Content.ReadFromJsonAsync<HealthEdu>();
            return response!;
        }


        public async Task<List<HealthEdu>> GetHealthEduByClassAsync(string healthClass)
        {
            var healthEdu = await httpClient.GetAsync($"api/HealthEdu/ByClass/{healthClass}");
            var response = await healthEdu.Content.ReadFromJsonAsync<List<HealthEdu>>();
            return response!;
        }



    }
}

