using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum BodyPart
{
    shoulder,
    chest,
    waist,
    hip,
    arm,
    leg
}
public class FitSclae : MonoBehaviour
{
    private Slider Bar;
    public Transform left;
    public Transform right;
    public BodyPart typeofBody;

    

    void Start()
    {
        Bar = this.GetComponent<Slider>();
        //waistBar.onValueChanged.AddListener(delegate { WaistSclae(); });
    }

    public void BodyPartSclae(float slidebarvalue)
    {
        switch(typeofBody)
        {
            case BodyPart.waist:
                left.localPosition = new Vector3(left.localPosition.x, -0.1f + slidebarvalue * (-1.0f), left.localPosition.z);
                right.localPosition = new Vector3(right.localPosition.x, slidebarvalue, right.localPosition.z);
                break;
            case BodyPart.hip:
                left.localPosition = new Vector3(left.localPosition.x, slidebarvalue * (-1.0f), left.localPosition.z);
                right.localPosition = new Vector3(right.localPosition.x, slidebarvalue, right.localPosition.z);
                break;
            case BodyPart.chest:
                left.localPosition = new Vector3(left.localPosition.x, slidebarvalue * (-1.0f), left.localPosition.z);
                right.localPosition = new Vector3(right.localPosition.x, slidebarvalue, right.localPosition.z);
                break;
            case BodyPart.shoulder:
                left.localPosition = new Vector3(slidebarvalue, left.localPosition.y, left.localPosition.z);
                right.localPosition = new Vector3(slidebarvalue, right.localPosition.y, right.localPosition.z);
                break;
            case BodyPart.arm:
                left.localScale = new Vector3(slidebarvalue, left.localScale.y, left.localScale.z);
                right.localScale = new Vector3(slidebarvalue, right.localScale.y, right.localScale.z);
                break;
            case BodyPart.leg:
                left.localScale = new Vector3(slidebarvalue, left.localScale.y, left.localScale.z);
                right.localScale = new Vector3(slidebarvalue, right.localScale.y, right.localScale.z);
                break;
        }



        
    }

  
}
