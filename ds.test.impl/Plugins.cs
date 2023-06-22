using System.Collections.Generic;
using System.Linq;

namespace ds.test.impl
{
    public static class Plugins

    {
        private static List<IPlugin> pList = new List<IPlugin>()
        {
            new Sum(), new Multiply(), new Division(), new Difference()
        };

        public static int PluginsCount
        { get { return pList.Count; } }

        public static string[] GetPluginNames
        {
            get
            {
                return pList.Select(x => x.PluginName).ToArray();
            }
        }

        public static IPlugin GetPlugin(string pluginName) =>
            pList.Where(x => x.PluginName == pluginName).ElementAt(0);
    }
}