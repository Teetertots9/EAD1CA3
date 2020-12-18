﻿using CA3.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace CA3.Pages
{
    public partial class Index3 : ComponentBase
    {
        private Root[] Main3;
        private string ErrorMessage;
        private string api = "https://api.punkapi.com/v2/beers?page=3&per_page=33";

        private async Task GetDataAsync()
        {
            try
            {
                string uri = api;
                Main3 = await Http.GetJsonAsync<Root[]>(uri);
                ErrorMessage = String.Empty;
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
            }
        }

        protected override async Task OnInitializedAsync()
        {
            await GetDataAsync();
        }

    }
}
