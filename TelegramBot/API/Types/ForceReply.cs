﻿using Newtonsoft.Json;

namespace TelegramBot.API.Types
{
    /// <summary>
    /// Upon receiving a message with this object, Telegram clients will display a reply interface to the user (act as if the user has selected the bot‘s message and tapped ’Reply'). 
    /// This can be extremely useful if you want to create user-friendly step-by-step interfaces without having to sacrifice privacy mode.
    /// </summary>
    internal class ForceReply
    {
        /// <summary>
        /// Shows reply interface to the user, as if they manually selected the bot‘s message and tapped ’Reply'
        /// </summary>
        [JsonProperty("force_reply")]
        internal bool forceReply { get; set; }

        /// <summary>
        /// Optional. Use this parameter if you want to force reply from specific users only. 
        /// Targets: 1) users that are @mentioned in the text of the Message object; 2) if the bot's message is a reply (has reply_to_message_id), sender of the original message.
        /// </summary>
        [JsonProperty("selective")]
        internal bool Selective { get; set; }
    }
}
