﻿using System.Collections.Generic;

namespace proxyServer
{
    interface ISettings
    {
        void LoadSettings(KeyValuePair<string, string> k);
        void WriteSettings(System.Xml.XmlWriter xml);
    }
}