﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Microsoft.Bot.Solutions;
using MrStrains.TokenExchange;

namespace MrStrains.Services
{
    public class BotSettings : BotSettingsBase
    {
        public TokenExchangeConfig TokenExchangeConfig { get; set; }
    }
}