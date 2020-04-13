﻿using Newtonsoft.Json;

namespace Slack.NetStandard.EventsApi.CallbackEvents
{
    public class InviteRequested : CallbackEvent
    {
        public const string EventType = "invite_requested";

        [JsonProperty("invite_request")]
        public InviteRequest InviteRequest { get; set; }
    }
}