HttpClient klient = new();

HttpResponseMessage odpowiedz =
  await klient.GetAsync("http://www.apple.com/");

WriteLine("Strona główna firmy Apple ma {0:N0} bajtów.",
  odpowiedz.Content.Headers.ContentLength);