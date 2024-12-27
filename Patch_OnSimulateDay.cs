using HarmonyLib;

namespace Drugs;

[HarmonyPatch]
public class Patch_OnSimulateDay
{
    [HarmonyPostfix, HarmonyPatch(typeof(Zone), "OnSimulateDay")]
    public static void OnSimulateDay(Zone __instance)
    {
        Element e = EClass.pc.elements.GetElement(69420);
        if (e != null)
        {
            e.vExp -= 200;
            if (e.vExp <= e.vBase * 1000)
            {
                int x = e.vExp;
                EClass.pc.SetFeat(69420, e.vBase - 1);
                e.vExp = x;
            }
        }

    }
}