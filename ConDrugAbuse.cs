using Drugs;

class ConDrugAbuse : BadCondition
{
    public override bool CanManualRemove => true;

    public override string GetText() => "Withdrawal".lang();

    public override void Tick()
    {
        GetWithdrawalEffect();
    }
    public void GetWithdrawalEffect()
    {
        int typeRoll = EClass.rnd(101);

        if (typeRoll <= 90)
        {
            Plugin.Log.LogMessage("Safe");
        }
        else if (typeRoll <= 98)
        {
            Plugin.Log.LogMessage("Bad Effect");
            GetBadEffect();
        }
        else
        {
            Plugin.Log.LogMessage("Good Effect");
            GetGoodEffect();
        }
    }

    private void GetBadEffect()
    {
        int badEffectRoll = EClass.rnd(101);
        if (badEffectRoll <= 50)
        {
            // a bad effect
            owner.AddCondition<ConConfuse>();
        }
        else if (badEffectRoll <= 80)
        {
            // a very bad effect
            owner.AddCondition<ConParalyze>();
        }
        else
        {
            //a very unfortunate bad effect
            owner.AddCondition<ConInsane>();
        }
    }


    private void GetGoodEffect()
    {
        int goodEffectRoll = EClass.rnd(101); // 1 to 100
        if (goodEffectRoll <= 70)
        {
            //effect
        }
        else
        {
            //effect
            owner.stamina.Mod(owner.HasElement(69420) ? owner.elements.GetElement(69420).vBase * 5 : 5);
        }
    }


}

