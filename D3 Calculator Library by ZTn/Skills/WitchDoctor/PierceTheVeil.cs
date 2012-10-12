﻿using ZTn.BNet.D3.Items;

namespace ZTn.BNet.D3.Calculator.Skills.WitchDoctor
{
    public class PierceTheVeil : D3SkillModifier
    {
        readonly double multiplier = 0.20;

        public override ItemAttributes getBonus(D3Calculator calculator)
        {
            return (new DamageMultiplier(multiplier)).getBonus(calculator);
        }
    }
}
