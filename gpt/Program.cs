using System;
using System.Net.Http;
using System.Text;
// using System.Text.Json;


namespace ChatGPT_CSharp_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Prompt the user for a question
                Console.WriteLine("Enter a question:");
                string question = Console.ReadLine();

                // Call ChatGPT with the question
                string response = CallChatGPT(question);

                // Print the response on the screen
                Console.WriteLine("ChatGPT says: " + response);
            }
        }

        static string CallChatGPT(string question)
        {
            // Set up the API request
            string apiKey = "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";
            string apiEndpoint = "https://api.openai.com/v1/completions";
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + apiKey);

            // Set up the request body
            string requestBody = "{\"model\": \"text-davinci-003\",  \"prompt\": \"" + question + "\", \"max_tokens\": 4000, \"temperature\": 0.5}";
            StringContent requestContent = new StringContent(requestBody, Encoding.UTF8, "application/json");

            // Send the API request and get the response
            HttpResponseMessage response = httpClient.PostAsync(apiEndpoint, requestContent).Result;
            string responseContent = response.Content.ReadAsStringAsync().Result;

            Console.WriteLine(responseContent);
            // Extract the response text from the JSON response
            // dynamic json = JsonSerializer.Deserialized(responseContent);
            dynamic json = Newtonsoft.Json.JsonConvert.DeserializeObject(responseContent);
            return json.choices[0].text;
        }
    }
}
