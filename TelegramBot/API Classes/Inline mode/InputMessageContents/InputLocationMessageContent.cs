﻿using Newtonsoft.Json;

namespace TelegramBot.API_Classes.Inline_mode.InputMessageContents
{
    public class InputLocationMessageContent: InputMessageContent
    {
        //Latitude of the location in degrees
        [JsonProperty("latitude")]
        internal float Latitude { get; set; }

        //Longitude of the location in degrees
        [JsonProperty("longitude")]
        internal float Longtitude { get; set; }
    }
}
