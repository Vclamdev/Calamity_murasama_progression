using Calamity_murasama_progression.Content.config;
using CalamityMod;
using Terraria;
using Terraria.ModLoader;

namespace Calamity_murasama_progression.Content.murasama.util;

public static class DamageCounterUtil
{

    public static float CountDamage()
    {
        float damageMultiplier = 0.008f; // start dmg +-= 0.8%
                
        if (NPC.downedBoss2)      { damageMultiplier += MurasamaConfig.Instance.EvilBossMult; } // evil biom boss (1.8%)
        if (NPC.downedBoss3)      { damageMultiplier += MurasamaConfig.Instance.SkeletronMult; } // skeletron (2.3%)
        if (Main.hardMode)        { damageMultiplier += MurasamaConfig.Instance.OnHardModeMult; } // hardMode (6%)
        if (NPC.downedMechBoss1)  { damageMultiplier += MurasamaConfig.Instance.DestroyerMult; } // destroyer (9%)
        if (NPC.downedMechBoss2)  { damageMultiplier += MurasamaConfig.Instance.TwinsMult; } // the twins (12%)
        if (NPC.downedMechBoss3)  { damageMultiplier += MurasamaConfig.Instance.SkeletronPMult; } // skeletron prime (15%)
        if (NPC.downedPlantBoss)  { damageMultiplier += MurasamaConfig.Instance.PlanteraMult; } // plantera (30%)
        if (NPC.downedMoonlord)   { damageMultiplier += MurasamaConfig.Instance.MoonLordMult; } // moonLord (80%)

        if (ModLoader.HasMod("CalamityMod"))
        {
            if (DownedBossSystem.downedProvidence) damageMultiplier += MurasamaConfig.Instance.ProvidenceMult; // providence (90%)
            if (DownedBossSystem.downedDoG) damageMultiplier += MurasamaConfig.Instance.DoGMult; // DoG (100% of base dmg)
            if (DownedBossSystem.downedYharon) damageMultiplier += MurasamaConfig.Instance.YharonMult; // yharon (115%)
            if (DownedBossSystem.downedExoMechs) damageMultiplier += MurasamaConfig.Instance.ExoMechsMult; // exo mechs (130%)
            if (DownedBossSystem.downedCalamitas) damageMultiplier += MurasamaConfig.Instance.CalamitasMult; // calamitas (145%)
        }

        return damageMultiplier;
    }
}