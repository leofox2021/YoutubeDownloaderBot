using Telegram.Bot;

namespace YoutubeDownloaderBot.Constants;

public static class Runtime
{
    public static TelegramBotClient? BotClient;

    public static string? Token =>
        Environment.GetEnvironmentVariable("BOT_API_TOKEN", EnvironmentVariableTarget.Machine);
}