using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
