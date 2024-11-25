using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace BotHost.Controllers.Commands
{
    public class InlineCommand : ICommand
    {
        public TelegramBotClient Client => Bot.GetTelegramBot().Result;

        public string Name => "/inline";


        public async Task Execute(Update update)
        {
            long chatId = update.Message.Chat.Id;


            var inlineKeyboard = new InlineKeyboardMarkup(new[] {
                new [] {
                    InlineKeyboardButton.WithUrl("Розклад", "https://student.lpnu.ua/students_schedule"),
                    InlineKeyboardButton.WithUrl("Викладачі", "https://amath.lp.edu.ua/staff/teachers")
            },
                new [] {
                    InlineKeyboardButton.WithUrl("Студентам", "https://amath.lp.edu.ua/"),
                    InlineKeyboardButton.WithUrl("Абітуріентам", "https://amath.lp.edu.ua/invitation"),
            },
         });

            await Client.SendTextMessageAsync(
            chatId: chatId,
            text: "Виберіть пункт меню: ",
                replyMarkup: inlineKeyboard
                );
        }



    }
}
