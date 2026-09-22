using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace Calamity_murasama_progression.Content.config;

public class MurasamaConfig : ModConfig
{
    public static MurasamaConfig Instance;
    
    public override ConfigScope Mode => ConfigScope.ServerSide;

    [DefaultValue(true)]
    public bool EnableMurasamaProgression;
    
    [Header("MurasamaDmgModifiers")]

    [DefaultValue(0.01f)]
    [Range(0.001f, 0.3f)]
    [Slider]
    public float EvilBossMult;
    
    [DefaultValue(0.005f)]
    [Range(0.001f, 0.3f)]
    [Slider]
    public float SkeletronMult;
    
    [DefaultValue(0.037f)]
    [Range(0.001f, 0.3f)]
    [Slider]
    public float OnHardModeMult;
    
    [DefaultValue(0.03f)]
    [Range(0.001f, 0.3f)]
    [Slider]
    public float DestroyerMult;
    
    [DefaultValue(0.03f)]
    [Range(0.001f, 0.3f)]
    [Slider]
    public float TwinsMult;
    
    [DefaultValue(0.03f)]
    [Range(0.001f, 0.3f)]
    [Slider]
    public float SkeletronPMult;
    
    [DefaultValue(0.15f)]
    [Range(0.001f, 0.3f)]
    [Slider]
    public float PlanteraMult;
    
    [DefaultValue(0.5f)]
    [Range(0.001f, 0.3f)]
    [Slider]
    public float MoonLordMult;
    
    
    [DefaultValue(0.1f)]
    [Range(0.001f, 0.3f)]
    [Slider]
    public float ProvidenceMult;
    
    [DefaultValue(0.2f)]
    [Range(0.001f, 0.3f)]
    [Slider]
    public float DoGMult;
    
    [DefaultValue(0.15f)]
    [Range(0.001f, 0.3f)]
    [Slider]
    public float YharonMult;
    
    [DefaultValue(0.15f)]
    [Range(0.001f, 0.3f)]
    [Slider]
    public float ExoMechsMult;

    [DefaultValue(0.15f)] [Range(0.001f, 20)] [Slider]
    public float CalamitasMult;
}