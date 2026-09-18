using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace Calamity_murasama_progression.Content.config;

public class MurasamaConfig : ModConfig
{
    public override ConfigScope Mode => ConfigScope.ServerSide;

    [DefaultValue(true)]
    public bool EnableMurasamaProgression;

    [DefaultValue(5)]
    [Range(1, 20)] // Ограничение ползунка от 1 до 20
    [Slider] // Отображать в виде ползунка (slider)
    public int Multiplier;
}