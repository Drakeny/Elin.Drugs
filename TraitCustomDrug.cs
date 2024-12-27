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
                //test
                break;
            default:
                break;
        }

        if (c.IsPC)
        {
            Element e = c.elements.GetElement(69420);
            if (e != null)
            {
                e.vExp += 200;
                if (e.vExp >= (e.vBase + 1) * 1000 && e.vBase < 3)
                {
                    c.SetFeat(69420, e.vBase + 1, true);
                    e.vExp = e.vBase * 1000;
                }
            }
            else
            {
                c.SetFeat(69420, 1, true);
                c.elements.GetElement(69420).vExp = 1000;
            }
        }
    }

}
