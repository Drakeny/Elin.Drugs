using Drugs;

class ConDrugAbuse : BadCondition
{
    public override bool CanManualRemove => false;

    public override string GetText() => "Withdrawal".lang();

    public override void Tick()
    {
        base.Tick();
        GetWithdrawalEffect();
    }
    public void GetWithdrawalEffect()
    {
        int typeRoll = EClass.rnd(101);

        if (typeRoll <= 90)
        {
        }
        else if (typeRoll <= 98)
        {
            int msgnum = EClass.rnd(3) + 1;
            Msg.SetColor(Msg.colors.Negative);
            Msg.Say($"withdrawal_badeffect{msgnum}".lang());
            GetBadEffect();
        }
        else
        {
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
            Msg.SetColor(Msg.colors.Ono);
            Msg.Say($"withdrawal_goodeffect2".lang());
            owner.sleepiness.Mod(owner.HasElement(69420) ? owner.elements.GetElement(69420).vBase * -5 : -5);
        }
        else
        {
            //effect
            Msg.SetColor(Msg.colors.Ono);
            Msg.Say($"withdrawal_goodeffect1".lang());
            owner.stamina.Mod(owner.HasElement(69420) ? owner.elements.GetElement(69420).vBase * 5 : 5);
        }
    }


}

