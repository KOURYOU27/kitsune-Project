using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageChoice : MonoBehaviour {

    public static bool en_button;
    public static bool ja_button;


    public void OnPointerUp(int number)
    {

        switch (number)
        {

            case 0:
                ja_button = true;
                en_button = false;
                break;
            case 1:
                ja_button = false;
                en_button = true;
                break;
            default:
                break;
        }

    }

    public static bool getA()
    {
        return ja_button;
    }

    public static bool getB()
    {
        return en_button;
    }
}
