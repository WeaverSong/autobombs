using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace autobombs
{
    public class gitem : GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            base.SetDefaults(item);
            if (item.type == ItemID.Bomb || item.type == ItemID.BombFish || item.type == ItemID.Dynamite ||
            item.type == ItemID.StickyBomb || item.type == ItemID.StickyDynamite || item.type == ItemID.BouncyBomb ||
            item.type == ItemID.BouncyDynamite)
            {
                item.autoReuse = true;
            }
        }
    }
}