using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Char_Customiser : MonoBehaviour
{
    public int[] currentlySelectedIndex = new int[6];
    private int itemType = 0;
    public Char_Scriptable_Object Assets;

    public SkinnedMeshRenderer Hair;
    public SkinnedMeshRenderer ShoulderPads;
    public SkinnedMeshRenderer Clothes;
    public SkinnedMeshRenderer Belts;    
    public SkinnedMeshRenderer Gloves;    
    public SkinnedMeshRenderer Shoes;

    public int[] Item_Cost = new int[6];
    public int Total_Item_Cost;
    public int Available_Money = 5000;
    public Text Item_Cost_Text;
    public Text Available_Money_Text;

    public void SetItem(SkinnedMeshRenderer Meshrenderer, Mesh[] meshArray)
    {
        Meshrenderer.sharedMesh = meshArray[currentlySelectedIndex[itemType]];
    }
    public void Increment()
    {

        switch (itemType)
        {
            case 0:
                if (currentlySelectedIndex[itemType] < Assets.Hair.Length - 1)
                {
                    currentlySelectedIndex[itemType]++;
                    Hair.sharedMesh = Assets.Hair[currentlySelectedIndex[itemType]];
                }
                break;
            case 1:
                if (currentlySelectedIndex[itemType] < Assets.Shoulderpads.Length - 1)
                {
                    currentlySelectedIndex[itemType]++;
                    ShoulderPads.sharedMesh = Assets.Shoulderpads[currentlySelectedIndex[itemType]];
                }
                break;
            case 2:
                if (currentlySelectedIndex[itemType] < Assets.Clothes.Length - 1)
                {
                    currentlySelectedIndex[itemType]++;
                    Clothes.sharedMesh = Assets.Clothes[currentlySelectedIndex[itemType]];
                }
                break;
            case 3:
                if (currentlySelectedIndex[itemType] < Assets.Belts.Length - 1)
                {
                    currentlySelectedIndex[itemType]++;
                    SetItem(Belts, Assets.Belts);
                }
                break;
            case 4:
                if (currentlySelectedIndex[itemType] < Assets.Gloves.Length - 1)
                {
                    currentlySelectedIndex[itemType]++;
                    Gloves.sharedMesh = Assets.Gloves[currentlySelectedIndex[itemType]];
                }
                break;
            case 5:
                if (currentlySelectedIndex[itemType] < Assets.Shoes.Length - 1)
                {
                    currentlySelectedIndex[itemType]++;
                    Shoes.sharedMesh = Assets.Shoes[currentlySelectedIndex[itemType]];
                }
                break;
            default:
                break;
        }
    }
    public void Decrement()
    {
        switch (itemType)
        {
            case 0:
                if (currentlySelectedIndex[itemType] > 0)
                {
                    currentlySelectedIndex[itemType]--;
                    SetItem(Hair, Assets.Hair);
                }
                break;
            case 1:
                if (currentlySelectedIndex[itemType] > 0)
                {
                    currentlySelectedIndex[itemType]--;
                    SetItem(ShoulderPads, Assets.Shoulderpads);
                }
                break;
            case 2:
                if (currentlySelectedIndex[itemType] > 0)
                {
                    currentlySelectedIndex[itemType]--;
                    SetItem(Clothes, Assets.Clothes);
                }
                break;
            case 3:
                if (currentlySelectedIndex[itemType] > 0)
                {
                    currentlySelectedIndex[itemType]--;
                    SetItem(Belts, Assets.Belts);
                }
                break;
            case 4:
                if (currentlySelectedIndex[itemType] > 0)
                {
                    currentlySelectedIndex[itemType]--;
                    SetItem(Gloves, Assets.Gloves);
                }
                break;
            case 5:
                if (currentlySelectedIndex[itemType] > 0)
                {
                    currentlySelectedIndex[itemType]--;
                    SetItem(Shoes, Assets.Shoes);
                }
                break;
            default:
                break;
        }
        
    }
    public void SetItemNumber(int value)
    {
        itemType = value;
        
    }
    public void Total_Cost()
    {
        
        Item_Cost[0] = 100 * 12 * (currentlySelectedIndex[0] + 1) / 20;
        Item_Cost[1] = 140 * 14 * (currentlySelectedIndex[1] + 1) / 10;
        Item_Cost[2] = 180 * 16 * (currentlySelectedIndex[2] + 1) / 30;
        Item_Cost[3] = 250 * 18 * (currentlySelectedIndex[3] + 1) / 40;
        Item_Cost[4] = 120 * 10 * (currentlySelectedIndex[4] + 1) / 10;
        Item_Cost[5] = 150 * 14 * (currentlySelectedIndex[5] + 1) / 10;

        Total_Item_Cost = Item_Cost[0] + Item_Cost[1] + Item_Cost[2] + Item_Cost[3] + Item_Cost[4] + Item_Cost[5];
        Item_Cost_Text.text = ("$" + Total_Item_Cost);
        Available_Money_Text.text = ("$" + Available_Money);

    }
    public void Update()
    {
        Total_Cost();
    }
}
