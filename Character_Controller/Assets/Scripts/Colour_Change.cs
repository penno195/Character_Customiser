using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Colour_Change : MonoBehaviour
{
    [SerializeField] private Image Rotate_Image;
    [SerializeField] private Color Rotate_Logo_Colour_On;
    [SerializeField] private Color Rotate_Logo_Colour_Off;
    public static bool Rotate_Off;

    // Start is called before the first frame update
    void Start()
    {
        Rotate_Logo_Colour_Off.a = 1;
        Rotate_Logo_Colour_On.a = 1;
    }

    public void ChangeColour()
    {
        if (Rotate_Off)
        {
            Rotate_Image.color = Rotate_Logo_Colour_Off;
            Rotate_Off = false;
        }
        else if (!Rotate_Off)
        {
            Rotate_Image.color = Rotate_Logo_Colour_On;
            Rotate_Off = true;
        }
        
    }
}
