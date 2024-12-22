using HarmonyLib;

namespace Drugs;

[HarmonyPatch]
public class Patch_CharaTick
{
    static bool flip = true;
    [HarmonyPostfix, HarmonyPatch(typeof(Chara), "Tick")]
    public static void Tick(Chara __instance)
    {
        flip = !flip;
        if (flip) return;
        if (!__instance.IsPC) return;
        if (EClass.pc.elements.GetElement(69420) == null) return;
        Element e = EClass.pc.elements.GetElement(69420);

        Plugin.Log.LogMessage("Rolling Withdrawal");
        if (EClass.rnd(1000) <= e.vBase * 2 && !__instance.HasCondition<ConDrugAbuse>())
        {
            Plugin.Log.LogMessage("Adding Withdrawal");
            __instance.AddCondition<ConDrugAbuse>();
        }

    }
}