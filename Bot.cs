using Telegram.Bot;

namespace BotHost
{
    public class Bot
    {
        private static TelegramBotClient? client { get; set; }
        public static async Task<TelegramBotClient> GetTelegramBot()
        {
            if (client != null)
            {
                return client;
            }
            client = new TelegramBotClient("7879072794:AAHvXaVWVbNqZVFuZV7YSUUiILaUPIj0myI");
            string hook = "tgsofiabot-cxc8ecdugmdvh6cw.polandcentral-01.azurewebsites.net";
            await client.SetWebhookAsync(hook);
            return client;
        }
    }
}
