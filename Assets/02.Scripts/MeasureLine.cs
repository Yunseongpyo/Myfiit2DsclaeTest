using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class MeasureLine : MonoBehaviour
{
    [System.Serializable]
    public struct BodySizeRange
    {
        public float min;
        public float max;
    }

    //Born position
    public Transform left;
    public Transform right;

    //측정라인
    private LineRenderer measureLine;

    public BodyPart typeofLine;
    public BodySizeRange partsize;

    //부모 오브젝트 슬라이드바
    private Slider parentBar;

    //치수 표시 텍스트
    public Text measureText;

    private bool changeCheckInch = true;

    void Start()
    {
        measureLine = this.GetComponent<LineRenderer>();
        parentBar = this.GetComponentInParent<Slider>();
    }

    string ChageInch(float a) // 슬라이드바 비율에 따른 인치 변화
    {
        float persecnt = (a - parentBar.minValue) / (parentBar.maxValue - parentBar.minValue);
        if(changeCheckInch == true)
        {
            return (Mathf.Round(Mathf.Lerp(partsize.min, partsize.max, persecnt) * 10f) * 0.1f).ToString() + " inch";
        }
        else
        {
            //return ((Mathf.Round(Mathf.Lerp(partsize.min, partsize.max, persecnt) * 10f) * 0.1f) * 2.54f).ToString() + " cm";
            return ((Mathf.Round(Mathf.Lerp(partsize.min, partsize.max, persecnt) * 2.54f * 10f) * 0.1f)).ToString() + " cm";
            //return Mathf.Round((Mathf.Lerp(partsize.min, partsize.max, persecnt) * 2.54f) * 0.1f).ToString() + " cm";

        }
    }

    public void InchToCm(bool _change)
    {
        changeCheckInch = _change;
    }

  
    void Update()
    {

        switch(typeofLine)
        {
            case BodyPart.shoulder:
                measureLine.SetPosition(0, new Vector3(left.position.x + 0.2f, right.position.y, -0.1f));
                measureLine.SetPosition(1, new Vector3(right.position.x - 0.3f, right.position.y, -0.1f));
                measureText.text = ChageInch(parentBar.value);
                break;
            case BodyPart.chest:
                measureLine.SetPosition(0, new Vector3(left.position.x + 0.6f, right.position.y, -0.1f));
                measureLine.SetPosition(1, new Vector3(right.position.x - 0.6f, right.position.y, -0.1f));
                measureText.text = ChageInch(parentBar.value);
                break;
            case BodyPart.waist:
                measureLine.SetPosition(0, new Vector3(left.position.x + 0.4f, right.position.y, -0.1f));
                measureLine.SetPosition(1, new Vector3(right.position.x - 0.7f, right.position.y, -0.1f));
                measureText.text = ChageInch(parentBar.value);
                break;
            case BodyPart.hip:
                measureLine.SetPosition(0, new Vector3(left.position.x + 0.9f, right.position.y, -0.1f));
                measureLine.SetPosition(1, new Vector3(right.position.x - 1f, right.position.y, -0.1f));
                measureText.text = ChageInch(parentBar.value);
                break;

            case BodyPart.arm:
                measureLine.SetPosition(0, new Vector3(left.position.x + 0.5f, left.position.y, -0.1f));
                measureLine.SetPosition(1, new Vector3(right.position.x + 0.5f , right.position.y , -0.1f));
                measureText.text = ChageInch(parentBar.value);
                break;
            case BodyPart.leg:
                measureLine.SetPosition(0, new Vector3(left.position.x + 1f, left.position.y, -0.1f));
                measureLine.SetPosition(1, new Vector3(right.position.x + 1f, right.position.y, -0.1f));
                measureText.text = ChageInch(parentBar.value);
                break;

        }
        //1.79 ~ 3.78 : 32 ~ 50


//        가슴사이즈(cm) : 82 86 90 94 98 102
//가슴사이즈(inch) : 32 33 35 37 98 40
//팔길이: 57, 59, 61, 63, 65, 67

//허리(inch) : 24, 26, 27, 28, 29 ,30
//허리(cm) : 62, 65, 68, 71, 74, 77


    }
}
