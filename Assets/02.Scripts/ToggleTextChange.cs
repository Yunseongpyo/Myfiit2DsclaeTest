using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ToggleTextChange : MonoBehaviour
{
    public Text unittext;
    private Toggle togglecolor;
    private void Start()
    {
        togglecolor = this.GetComponent<Toggle>();
    }
    public void textchange(bool inchtocm)
    {
        if(inchtocm == true)
        {
            unittext.text = " inch";
        }
        else
        {
            unittext.text = " cm";
        }

    }
 
}
