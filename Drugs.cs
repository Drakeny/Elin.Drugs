using System;
using System.Linq;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;

namespace Drugs;

[BepInPlugin("DrakenyDev.Elin.Drugs", "Drugs", "1.0.0")]
public class Plugin : BaseUnityPlugin
{
    internal static ManualLogSource Log;
    private static Harmony harmony;

    private void Start()
    {

        Log = base.Logger;
        harmony = new Harmony("DrakenyDev.Elin.Drugs");
        harmony.PatchAll();
        Log.LogInfo("DrakenyDev.Elin.Drugs loaded");
    }
}

