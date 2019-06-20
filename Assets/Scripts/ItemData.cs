
using UnityEngine;

public static class ItemData
{
    public static Item CreateItem(int itemID)
    {
        //stored data for items
        string name = "";
        int value = 0;
        string description = "";
        string icon = "";
        string mesh = "";
        ItemType type = ItemType.Food;
        int heal = 0;
        int damage = 0;
        int armour = 0;
        int amount = 0;

        //switch for item ID for all items
        switch (itemID)
        {
            #region Food 0-99
            case 0:
                name = "Meat";
                value = 15;
                description = "Animal produce ";
                icon = "Meat_Icon";
                mesh = "Meat_Mesh";
                type = ItemType.Food;
                heal = 17;
                amount = 1;
                break;
            case 1:
                name = "Chicken";
                value = 10;
                description = "Bird meat ";
                icon = "Chicken_Icon";
                mesh = "Chicken_Mesh";
                type = ItemType.Food;
                heal = 14;
                amount = 1;
                break;
            case 2:
                name = "Bread";
                value = 5;
                description = "Bread makes you fat ";
                icon = "Bread_Icon";
                mesh = "Bread_Mesh";
                type = ItemType.Food;
                heal = 5;
                amount = 1;
                break;
            #endregion
            #region Weapon 100-199
            case 100:
                name = "Short Sword";
                value = 30;
                description = "Short range blade";
                icon = "ShortSword_Icon";
                mesh = "ShortSword_Mesh";
                type = ItemType.Weapon;
                damage = 15;
                amount = 1;
                break;
            case 101:
                name = "Long Sword";
                value = 40;
                description = "Long bladeed Sword";
                icon = "LongSword_Icon";
                mesh = "LongSword_Mesh";
                type = ItemType.Weapon;
                damage = 25;
                amount = 1;
                break;
            case 102:
                name = "Axe";
                value = 35;
                description = "Hand Axe";
                icon = "Axe_Icon";
                mesh = "Axe_Mesh";
                type = ItemType.Weapon;
                damage = 20;
                amount = 1;
                break;
            #endregion
            #region Apparel 200-299
            case 200:
                name = "Wizard Hat";
                value = 80;
                description = "Magic hat";
                icon = "WizardHat_Icon";
                mesh = "WizardHat_Mesh";
                type = ItemType.Apparel;
                armour = 5;
                amount = 1;
                break;
            case 201:
                name = "Leather Cap";
                value = 20;
                description = "Leather headware";
                icon = "LeatherCap_Icon";
                mesh = "LeatherCap_Mesh";
                type = ItemType.Apparel;
                armour = 10;
                amount = 1;
                break;
            case 202:
                name = "Full Helm";
                value = 150;
                description = "Metal Heml";
                icon = "FullHelm_Icon";
                mesh = "FullHelm_Mesh";
                type = ItemType.Apparel;
                armour = 30;
                amount = 1;
                break;
            #endregion
            #region Crafting 300-399
            case 300:
                name = "Iron Ingot";
                value = 80;
                description = "Used for crafting";
                icon = "IronIngot_Icon";
                mesh = "IronIngot_Mesh";
                type = ItemType.Crafting;
                amount = 1;
                break;
            case 301:
                name = "Malchite Ingot";
                value = 150;
                description = "Used for crafting";
                icon = "MalchiteIngot_Icon";
                mesh = "MalchiteIngot_Mesh";
                type = ItemType.Crafting;
                amount = 1;
                break;
            case 302:
                name = "Glass";
                value = 40;
                description = "Used for crafting";
                icon = "Glass_Icon";
                mesh = "Glass_Mesh";
                type = ItemType.Crafting;
                amount = 1;
                break;
            #endregion
            #region Quest 400-499
            case 400:
                name = "Hammer of the big Yeouch";
                value = 1000;
                description = "Yeouch!";
                icon = "YeouchHammer_Icon";
                mesh = "YeouchHammer_Mesh";
                type = ItemType.Quest;
                amount = 1;
                break;
            case 401:
                name = "Bespeckled Cephalopod";
                value = 2000;
                description = "Belongs in the sea";
                icon = "Cephalopod_Icon";
                mesh = "Cephalopod_Mesh";
                type = ItemType.Quest;
                amount = 1;
                break;
            case 402:
                name = "Aunt janet's Wallet";
                value = 1000;
                description = "Bring me back my wallet you";
                icon = "JanetWallet_Icon";
                mesh = "JanetWallet_Mesh";
                type = ItemType.Quest;
                amount = 1;
                break;
            #endregion
            #region Ingredients 500-599
            case 500:
                name = "Sugar";
                value = 5;
                description = "Sweet!";
                icon = "Sugar_Icon";
                mesh = "Sugar_Mesh";
                type = ItemType.Ingredients;
                amount = 1;
                break;
            case 501:
                name = "Brussel Sprouts";
                value = 4;
                description = "Pranked";
                icon = "BrusselSprouts_Icon";
                mesh = "BrusselSprouts_Mesh";
                type = ItemType.Ingredients;
                amount = 1;
                break;
            case 503:
                name = "Old Spice";
                value = 100;
                description = "Real old spice";
                icon = "OldSpice_Icon";
                mesh = "OldSpice_Mesh";
                type = ItemType.Ingredients;
                amount = 1;
                break;
            #endregion
            #region Potions 600-699
            case 600:
                name = "Small Health Potion";
                value = 25;
                description = "Heal a bit";
                icon = "SmallHealPot_Icon";
                mesh = "SmallHealPot_Mesh";
                type = ItemType.Potions;
                heal = 25;
                amount = 1;
                break;
            case 601:
                name = "Large Health Potion";
                value = 60;
                description = "Heal a Lot";
                icon = "LargeHealPot_Icon";
                mesh = "LargeHealPot_Mesh";
                type = ItemType.Potions;
                heal = 60;
                amount = 1;
                break;
            case 602:
                name = "Bone Hurting Juice";
                value = 1000;
                description = "Unheal";
                icon = "BoneHurtJuice_Icon";
                mesh = "BoneHurtJuice_Mesh";
                type = ItemType.Potions;
                heal = -1000;
                amount = 1;
                break;
            #endregion
            #region Scrolls 700-799
            case 700:
                name = "Small Health spell";
                value = 55;
                description = "Heal a bit";
                icon = "SmallHealScroll_Icon";
                mesh = "SmallHealScroll_Mesh";
                type = ItemType.Scrolls;
                heal = 25;
                amount = 1;
                break;
            case 701:
                name = "Voice of the big Yeouch";
                value = 5000;
                description = "Do not speak these words for they yeouch";
                icon = "YeouchScroll_Icon";
                mesh = "YeouchScroll_Mesh";
                type = ItemType.Scrolls;
                damage = 55000;
                amount = 1;
                break;
            case 702:
                name = "Small storm spell";
                value = 55;
                description = "Do a Storm";
                icon = "StormSpell_Icon";
                mesh = "StormSpell_Mesh";
                type = ItemType.Scrolls;
                damage = 30;
                amount = 1;
                break;
            #endregion
            default:
                 case 4:
                name = "Apple";
                value = 55;
                description = "apple";
                icon = "Apple_Icon";
                mesh = "Apple_Mesh";
                type = ItemType.Food;
                heal = 5;
                amount = 1;
                break;
        }
        Item temp = new Item
        {
            Name = name,
            Description = description,
            ID = itemID,
            Value = value,
            Icon = Resources.Load("Icons/" + icon) as Texture2D,
            Mesh = Resources.Load("Prefabs/" + mesh) as GameObject,
            Heal = heal,
            Damage = damage,
            Armour = armour,
            Amount = amount,
            Type = type,
        };
        return temp;
    }
}
