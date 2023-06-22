using System;
using System.Collections.Generic;
using System.Text;

namespace ds.test.impl
{
    internal interface IPluginFactory
    {
        int PluginsCount { get; }
        string[] GetPluginNames { get; }

        IPlugin GetPlugin(string pluginName);
    }
}