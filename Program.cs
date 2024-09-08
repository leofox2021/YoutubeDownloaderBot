using YoutubeDownloaderBot.Constants;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

if (Runtime.Token == null)
{
    Console.WriteLine("Your bot API token is not specified.");
    Console.WriteLine("Please create a global environmental variable called \"BOT_API_TOKEN\" " +
                      "so that the program can recognize it.");
    return;
}

using var cts = new CancellationTokenSource();
Runtime.BotClient = new TelegramBotClient(Runtime.Token, cancellationToken: cts.Token);
var me = await Runtime.BotClient.GetMeAsync();
Runtime.BotClient.OnMessage += OnMessage;

Console.WriteLine($"@{me.Username} is running... Press Enter to terminate");
Console.ReadLine();
cts.Cancel();

async Task OnMessage(Message message, UpdateType type)
{
    Console.WriteLine("Message received");
}