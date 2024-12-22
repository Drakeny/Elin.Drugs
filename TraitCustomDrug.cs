using Drugs;

class TraitCustomDrug : TraitDrink
{
    public override void OnDrink(Chara c)
    {
        switch (owner.id)
        {
            case "str_drug":
                c.AddCondition<ConStrDrug>();
                break;
            case "end_drug":
                c.AddCondition<ConEndDrug>();
                break;
            case "dex_drug":
                c.AddCondition<ConDexDrug>();
                break;
            case "per_drug":
                c.AddCondition<ConPerDrug>();
                break;
            case "ler_drug":
                c.AddCondition<ConLerDrug>();
                break;
            case "wil_drug":
                c.AddCondition<ConWilDrug>();
                break;
            case "mag_drug":
                c.AddCondition<ConMagDrug>();
                break;
            case "cha_drug":
                c.AddCondition<ConChaDrug>();
                break;
            case "spd_drug":
                c.AddCondition<ConSpdDrug>();
                break;
            case "drugabuse":
                Plugin.Log.LogMessage("Adding all drugs");
                c.AddCondition<ConStrDrug>();
                c.AddCondition<ConEndDrug>();
                c.AddCondition<ConDexDrug>();
                c.AddCondition<ConPerDrug>();
                c.AddCondition<ConLerDrug>();
                c.AddCondition<ConWilDrug>();
                c.AddCondition<ConMagDrug>();
                c.AddCondition<ConChaDrug>();
                c.AddCondition<ConSpdDrug>();
                break;
            default:
                break;
        }

        Element e = EClass.pc.elements.GetElement(69420);
        if (e != null)
        {
            e.vExp += 250;
            if (e.vExp >= 1000 && e.vBase < 3)
            {
                EClass.pc.SetFeat(69420, e.vBase + 1, true);
                e.vExp = 0;
            }
        }
        else
        {
            EClass.pc.SetFeat(69420, 1, true);
        }
    }

}
