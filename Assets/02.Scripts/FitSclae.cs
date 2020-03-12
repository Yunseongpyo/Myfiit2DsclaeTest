using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FitSclae : MonoBehaviour
{
    private Slider Bar;
    public Transform left;
    public Transform right;
    public BodyPart typeofBody;

    public enum BodyPart
    {
        shoulder,
        chest,
        waist,
        hip,
    }

    void Start()
    {
        Bar = this.GetComponent<Slider>();
        //waistBar.onValueChanged.AddListener(delegate { WaistSclae(); });
    }

    public void BodyPartSclae(float slidebarvalue)
    {
        switch(typeofBody)
        {
            case BodyPart.shoulder:
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
        }
        
    }

  
}
