using CalamityMod;
using Terraria;
using Terraria.ModLoader;

namespace Calamity_murasama_progression.Content.murasama.util;

public static class DamageCounterUtil
{
    public static float CountDamage()
    {
        float damageMultiplier = 0.008f; // start dmg +-= 0.8%
                
        if (NPC.downedBoss2)      { damageMultiplier += 0.01f; } // evil biom boss (1.8%)
        if (NPC.downedBoss3)      { damageMultiplier += 0.005f; } // skeletron (2.3%)
        if (Main.hardMode)        { damageMultiplier += 0.037f; } // hardMode (6%)
        if (NPC.downedMechBoss1)  { damageMultiplier += 0.03f; } // destroyer 9%)
        if (NPC.downedMechBoss2)  { damageMultiplier += 0.03f; } // the twins (12%)
        if (NPC.downedMechBoss3)  { damageMultiplier += 0.03f; } // skeletron prime (15%)
        if (NPC.downedPlantBoss)  { damageMultiplier += 0.15f; } // plantera (30%)
        if (NPC.downedMoonlord)   { damageMultiplier += 0.5f; } // moonLord (80%)

        if (ModLoader.HasMod("CalamityMod"))
        {
            if (DownedBossSystem.downedProvidence) damageMultiplier += 0.1f; // providence (90%)
            if (DownedBossSystem.downedDoG) damageMultiplier += 0.2f; // DoG (100% of base dmg)
            if (DownedBossSystem.downedYharon) damageMultiplier += 0.15f; // yharon (115%)
            if (DownedBossSystem.downedExoMechs) damageMultiplier += 0.15f; // exo mechs (130%)
            if (DownedBossSystem.downedCalamitas) damageMultiplier += 0.15f; // calamitas (145%)
        }

        return damageMultiplier;
    }
}