﻿using System;
using Shiny.Integrations.Sqlite;
using Shiny.Testing;


namespace Shiny.Tests
{
    public static class Helper
    {
        public static ShinySqliteConnection GetConnection()
            => new ShinySqliteConnection(new TestPlatform());
    }
}
