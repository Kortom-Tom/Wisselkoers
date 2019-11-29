private void wisselKoers_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = TextBox.Text.Replace("€", "");
            TextBox.Text = TextBox.Text.Replace("$", "");
            decimal getal2 = 0;
            using (var client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
            {
                
                try
                {
                    getal2 = decimal.Parse(TextBox.Text);
                    client.BaseAddress = new Uri("https://api.exchangeratesapi.io/latest");
                    HttpResponseMessage response = client.GetAsync("?symbols=USD").Result;
                    response.EnsureSuccessStatusCode();
                    string result = response.Content.ReadAsStringAsync().Result;
                    string USD = result.Substring(16, 6);
                    string USD1 = USD.Replace(".", ".");
                    string USD2 = USD1.Replace("}", "");
                    string USD3 = USD2.Replace(",", "");
                    string USD4 = USD3.Replace("\"", "");
                    decimal USD5 = Convert.ToDecimal(USD4);
                    decimal antwoord = getal2 * USD5;
                    decimal antwoord2 = Math.Round(antwoord, 2);
                    TextBox.Text = Convert.ToString("$" + antwoord2);
                    getal2 = 0;
                }
                catch(Exception ex)
                {
                    
                    decimal USD2 = Convert.ToDecimal(1.102);
                    decimal antwoord = getal2 * USD2;
                    decimal antwoord2 = Math.Round(antwoord, 2);
                    TextBox.Text = Convert.ToString("Schatting: $" + antwoord2);
                    getal2 = 0;
                    Console.WriteLine(ex.Message);
                }

            }
        }
        private void wisselKoersDollar_Click(object sender, RoutedEventArgs e)
        { 
                TextBox.Text = TextBox.Text.Replace("€", "");
                TextBox.Text = TextBox.Text.Replace("$", "");
                using (var client = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate }))
                {
                decimal getal2 = 0;
                try
                {
                    getal2 = decimal.Parse(TextBox.Text);
                    client.BaseAddress = new Uri("https://api.exchangeratesapi.io/latest");
                    HttpResponseMessage response = client.GetAsync("?symbols=USD").Result;
                    response.EnsureSuccessStatusCode();
                    string result = response.Content.ReadAsStringAsync().Result;
                    string USD = result.Substring(16, 6);
                    string USD1 = USD.Replace(".", ".");
                    string USD2 = USD1.Replace("}", "");
                    string USD3 = USD2.Replace(",", "");
                    string USD4 = USD3.Replace("\"", "");
                    decimal USD5 = Convert.ToDecimal(USD4);
                    decimal antwoord = getal2 / USD5;
                    decimal antwoord2 = Math.Round(antwoord, 2);
                    TextBox.Text = Convert.ToString("€" + antwoord2);
                    getal2 = 0;
                }
                catch (Exception ex)
                {
                    decimal USD2 = Convert.ToDecimal(1.102);
                    decimal antwoord = getal2 / USD2;
                    decimal antwoord2 = Math.Round(antwoord, 2);
                    TextBox.Text = Convert.ToString("Schatting:€" + antwoord2);
                    getal2 = 0;
                    Console.WriteLine(ex.Message);
                }
