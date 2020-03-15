using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLine : MonoBehaviour
{
    public Material linemat;
    Color onoffcolor;
    public void LineAlpha(bool _toggle)
    {
        onoffcolor = linemat.GetColor("_TintColor");

        if (_toggle)
        {
            onoffcolor.a = 1;
        }
        else
        {
            onoffcolor.a = 0;

        }
        linemat.SetColor("_TintColor", onoffcolor);
    }

}
