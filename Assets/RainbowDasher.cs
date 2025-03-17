using UnityEngine;

public class RainbowDasher : MonoBehaviour
{
    public Gradient grad;
    private Gradient[] ColList = new Gradient[9];
   
    private Color ColMemory;
    private int Index = 1;
    public float Lerper;
    void Start()
    {
        
        ColMemory = gameObject.GetComponent<MeshRenderer>().material.color;
         var colorKeys = new GradientColorKey[9];
        colorKeys[0] = new GradientColorKey(ColMemory,0.0F);
        colorKeys[1] = new GradientColorKey(ColMemory + new Color(1, 0, 0),0.125f);
        colorKeys[2] = new GradientColorKey(ColMemory + new Color(1, -1, 0),0.25f);
        colorKeys[3] = new GradientColorKey(ColMemory + new Color(1, -1, 1), 0.375f);
        colorKeys[4] = new GradientColorKey(ColMemory + new Color(1, 0, 1), 0.50f);
        colorKeys[5] = new GradientColorKey(ColMemory + new Color(0, 0, 1), 0.625f);
        colorKeys[6] = new GradientColorKey(ColMemory + new Color(0, -1, 1), 0.75f);
        colorKeys[7] = new GradientColorKey(ColMemory + new Color(1, -1, 1), 0.825f);
        colorKeys[8] = new GradientColorKey(ColMemory, 1f);

        var alphaKeys = new GradientAlphaKey[9];
        alphaKeys[0] = new GradientAlphaKey(1f, 0f);
        alphaKeys[1] = new GradientAlphaKey(1f, 0.125f);
        alphaKeys[2] = new GradientAlphaKey(1f, 0.25f);
        alphaKeys[3] = new GradientAlphaKey(1f, 0.375f);
        alphaKeys[4] = new GradientAlphaKey(1f, 0.50f);
        alphaKeys[5] = new GradientAlphaKey(1f, 0.625f);
        alphaKeys[6] = new GradientAlphaKey(1f, 0.75f);
        alphaKeys[7] = new GradientAlphaKey(1f, 0.825f);
        alphaKeys[8] = new GradientAlphaKey(1f, 1f);
        

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
        //GetComponent<MeshRenderer>().material.color = Color.Lerp(GetComponent<MeshRenderer>().material.color, ColList[Index], Lerper);
    }
}
