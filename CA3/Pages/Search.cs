using CA3.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Threading.Tasks;

namespace CA3.Pages
{

    public class SearchFields
    {
        public string searchOption { get; set; }
        public string searchText { get; set; }

    }
    public partial class Search : ComponentBase
    {
        private Root[] Beer;
        private string ErrorMessage;
        private SearchFields search = new SearchFields();
        private string api = "https://api.punkapi.com/v2/beers?";
        private string searchString { get; set; } = "";

        public async Task SearchTables()
        {
            if (search.searchOption != null && search.searchText != null)
            {
                searchString = search.searchOption + "=" + search.searchText + "&per_page=33";
                await SearchDataAsync();

            }
            else
            {
                ErrorMessage = "Please fill out all search fields";
            }
        }
        public async Task SearchDataAsync()
        {
            try
            {
                string uri = api + searchString;
                Beer = await Http.GetJsonAsync<Root[]>(uri);
                ErrorMessage = String.Empty;
            }
            catch (Exception e)
            {
                ErrorMessage = e.Message;
            }
        }
    }
}
