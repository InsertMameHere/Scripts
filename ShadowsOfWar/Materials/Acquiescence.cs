/*
name: Farms Acquiescence
description: Farms the Acquiescence from Shadows of War
tags: acquiescence, shadows of war
*/
//cs_include Scripts/CoreBots.cs
//cs_include Scripts/CoreFarms.cs
//cs_include Scripts/CoreAdvanced.cs
//cs_include Scripts/CoreStory.cs
//cs_include Scripts/ShadowsOfWar/CoreSoWMats.cs
//cs_include Scripts/Story/ShadowsOfWar/CoreSoW.cs
using Skua.Core.Interfaces;

public class Acquiescence
{
    public IScriptInterface Bot => IScriptInterface.Instance;
    public CoreBots Core => CoreBots.Instance;
    public CoreSoWMats SOWM = new();

    public void ScriptMain(IScriptInterface bot)
    {
        Core.BankingBlackList.Add("Acquiescence");

        Core.SetOptions();

        SOWM.Acquiescence();

        Core.SetOptions(false);
    }
}
