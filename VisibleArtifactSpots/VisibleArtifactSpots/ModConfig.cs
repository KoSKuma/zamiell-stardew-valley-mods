using StardewModdingAPI.Utilities;

namespace VisibleArtifactSpots
{
    public sealed class ModConfig
    {
        public string HighlightType { get; set; } = "Border";
        // digspots
        public bool HighlightArtifactSpots { get; set; } = true;
        public bool HighlightSeedSpots { get; set; } = true;
        // debris
        public bool HighlightWeeds { get; set; } = false;
        public bool HighlightTwigs { get; set; } = false;
        public bool HighlightStones { get; set; } = false;
        // ore nodes
        public bool HighlightCopperNodes { get; set; } = false;
        public bool HighlightIronNodes { get; set; } = false;
        public bool HighlightGoldNodes { get; set; } = false;
        public bool HighlightIridiumNodes { get; set; } = false;
        public bool HighlightRadioactiveNodes { get; set; } = false;
        public bool HighlightCinderNodes { get; set; } = false;
        // gem nodes
        public bool HighlightAmethystNodes { get; set; } = false;
        public bool HighlightAquamarineNodes { get; set; } = false;
        public bool HighlightDiamondNodes { get; set; } = false;
        public bool HighlightEmeraldNodes { get; set; } = false;
        public bool HighlightJadeNodes { get; set; } = false;
        public bool HighlightRubyNodes { get; set; } = false;
        public bool HighlightTopazNodes { get; set; } = false;
        // special mining nodes
        public bool HighlightGeodeNodes { get; set; } = false;
        public bool HighlightGemNodes { get; set; } = false;
        public bool HighlightMysticStoneNodes { get; set; } = false;
        public bool HighlightBoneNodes { get; set; } = false;
        public bool HighlightClayNodes { get; set; } = false;
        public bool HighlightCoalNodes { get; set; } = false;
        public bool HighlightCalicoEggNodes { get; set; } = false;
        //farming-related tiles
        public bool HighlightNonPlanted { get; set; } = false;
        public bool HighlightNonWatered { get; set; } = false;
        public bool HighlightNonFertilized { get; set; } = false;
        public bool HighlightHoeableTile { get; set; } = false;
        // miscellaneous
        public bool HighlightChests { get; set; } = false;
        public bool HighlightForageable { get; set; } = false;
    }
}
