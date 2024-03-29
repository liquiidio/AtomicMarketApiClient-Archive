﻿using AtomicMarketApiClient.Config;
using FluentAssertions;
using NUnit.Framework;

namespace AtomicMarketApiClient.Test.Config
{
    [TestFixture]
    public class ConfigApiTest
    {
        [Test]
        public void Config()
        {
            AtomicMarketApiFactory.Version1.ConfigApi.Config().Should().BeOfType<ConfigDto>();
            AtomicMarketApiFactory.Version1.ConfigApi.Config().Data.Should().BeOfType<ConfigDto.DataDto>();
        }
    }
}
