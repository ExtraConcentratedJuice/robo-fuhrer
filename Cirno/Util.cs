﻿using Discord;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;

namespace CirnoBot
{
    public static class Util
    {
        public static Color CyanColor { get => new Color(81, 172, 214); }

        public static string GenerateInvalidUsage(CirnoBot bot, CirnoCommand command) =>
            $"Invalid parameters.\nUsage: ``{bot.Configuration.Prefix}{command.Syntax}``";

        public static int GuildCount(CirnoBot bot) =>
            bot.Client.Guilds.Count;

        public static SocketTextChannel ParseTextChannel(string channel, DiscordSocketClient client) =>
            ulong.TryParse(new String(channel.Where(x => Char.IsDigit(x)).ToArray()), out ulong cId) ? client.GetChannel(cId) as SocketTextChannel : null;

        public static String BBCodeToMarkdown(string str) =>
            str.Replace("[i]", "*").Replace("[/i]", "*").Replace("[b]", "**").Replace("[/b]", "**");
    }
}
