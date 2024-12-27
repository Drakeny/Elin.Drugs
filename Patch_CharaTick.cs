using HarmonyLib;

namespace Drugs;

[HarmonyPatch]
public class Patch_CharaTick
{
    static bool flip = true;
    [HarmonyPostfix, HarmonyPatch(typeof(Chara), "Tick")]
    public static void Tick(Chara __instance)
    {
        if (!__instance.IsPC) return; //Player only for now...
        if (__instance.elements.GetElement(69420) == null || __instance.HasCondition<ConDrugAbuse>()) return;
        flip = !flip;
        if (flip) return;
        Element e = __instance.elements.GetElement(69420);
        if (EClass.rnd(1000) <= e.vBase * 2 && !__instance.HasCondition<ConDrugAbuse>())
        {
            __instance.AddCondition<ConDrugAbuse>(e.vBase);
        }

    }
}