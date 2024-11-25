using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace BotHost.Controllers.Commands
{
    public class KeyboardCommand : ICommand
    {
        public TelegramBotClient Client => Bot.GetTelegramBot().Result;

        public string Name => "/keyboard";

        public async Task Execute(Update update)
        {
            long chatId = update.Message.Chat.Id;

            ReplyKeyboardMarkup replyKeyboardMarkup = new(new[]
            {
                new [] {
                    new KeyboardButton("Історія НУ ЛП"),
                    new KeyboardButton("Розклад перерв"),
                },
            })
            {
                ResizeKeyboard = true // Кнопки адаптовані до екрану
            };

            await Client.SendTextMessageAsync(
                chatId: chatId,
                text: "Оберіть дію:",
                replyMarkup: replyKeyboardMarkup
            );
        }
    }
}
