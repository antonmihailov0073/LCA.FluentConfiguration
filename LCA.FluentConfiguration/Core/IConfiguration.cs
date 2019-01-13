﻿using LCA.FluentConfiguration.Settings;

namespace LCA.FluentConfiguration.Core
{
    public interface IConfiguration
    {
        SettingsDictionary ConnectionStrings { get; }


        TSection GetSection<TSection>(string name)
            where TSection : ASection;
    }
}
