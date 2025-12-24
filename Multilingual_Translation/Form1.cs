using System.Text.RegularExpressions;

namespace Multilingual_Translation
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private async void btnTranslate_Click(object sender, EventArgs e)
        {
            string textToTranslate = txtSource.Text;
            if (string.IsNullOrWhiteSpace(textToTranslate)) return;

            string targetLang = "en"; // Varsayılan İngilizce

            // Seçilen dile göre kod belirle
            switch (cmbLang.SelectedItem?.ToString())
            {
                case "English": targetLang = "en"; break;
                case "Deutsch": targetLang = "de"; break;
                case "Français": targetLang = "fr"; break;
                case "Español": targetLang = "es"; break;
                default: targetLang = "en"; break;
            }

            txtTarget.Text = "The sentence is being translated";

            // Asıl işi yapan fonksiyonu çağırıyoruz
            string result = await TranslateText(textToTranslate, "tr", targetLang);
            txtTarget.Text = result;
        }

        private async Task<string> TranslateText(string input, string fromLang, string toLang)
        {
            // API Linki oluşturma
            string url = $"https://api.mymemory.translated.net/get?q={Uri.EscapeDataString(input)}&langpair={fromLang}|{toLang}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    // İsteği gönder
                    string response = await client.GetStringAsync(url);

                    // JSON içinde "translatedText":"Merhaba" diye gelir. Biz o kısmı alıyoruz.
                    var match = Regex.Match(response, "\"translatedText\":\"(.*?)\"");

                    if (match.Success)
                        return Regex.Unescape(match.Groups[1].Value);
                    else
                        return "Hata: Çeviri alınamadı.";
                }
                catch (Exception ex)
                {
                    return "Bağlantı Hatası: " + ex.Message;
                }
            }
        }
    }
}
