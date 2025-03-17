using System;
using UnityEngine;

public class RainbowDash : MonoBehaviour
{
    private Color[] ColList=new Color[8];
    private Color ColMemory;
    private int Index = 1;
    public float Lerper;
    void Start()
    {
        ColMemory = gameObject.GetComponent<MeshRenderer>().material.color;
        ColList[0] = ColMemory;
        ColList[1] = ColMemory + new Color(1, 0, 0);
        ColList[2] = ColMemory + new Color(1, -1, 0);
        ColList[3] = ColMemory + new Color(1, -1, 1);
        ColList[4] = ColMemory + new Color(1, 0, 1);
        ColList[5] = ColMemory + new Color(0, 0, 1);
        ColList[6] = ColMemory + new Color(0, -1, 1);
        ColList[7] = ColMemory + new Color(1, -1, 1);



    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        if (Index < 7)
        {
            Index += 1;
        }
        else
        {
            Index = 0;
        }
       GetComponent<MeshRenderer>().material.color = Color.Lerp(GetComponent<MeshRenderer>().material.color, ColList[Index],Lerper);
    }
}
