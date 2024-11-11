///TODO:
///from this list the user will select a game
///click on confirm/ok button
///this will fill in the releveant information in the ad game form
/// 
///maybe move this functionality to the SearchWindow instead
/// 
/// look at passing data from the selection to the addBoardGame form.
using System.Xml;
using System.Xml.Linq;


//display the results of hitting search in a window where you selec tthe copy of the game that applies
//get game id and name, store both in seperate lists?
//when player selects and confirms
//call function to pull up information from specific game using game id
//use xmlapi/boardgame/<gameid>
namespace bgpicker2
{
    public class BggAPITest
    {
        static readonly HttpClient _client = new HttpClient();
        bool searching = false;
        //search for specified game
        public static async Task<string> SearchTest(string inString)
        {
            try
            {
                string url = "https://boardgamegeek.com/xmlapi2/search?query=" + inString;
                using HttpResponseMessage response = await _client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error";
            }
        }
        //Lookup specific game using game id
        public static async Task<string> LookupGame(int gameid)
        {
            try
            {
                string url = "https://boardgamegeek.com/xmlapi/boardgame/" + gameid.ToString();
                using HttpResponseMessage response = await _client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch (HttpRequestException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error";
            }
        }
    }
}
