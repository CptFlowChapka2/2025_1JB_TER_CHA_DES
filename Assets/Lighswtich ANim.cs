using UnityEngine;

public class LIghtSwitchANim : MonoBehaviour
{
    private Color ColMemory;

    private void Start()
    {
        ColMemory = gameObject.GetComponent<MeshRenderer>().material.color;
        gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
    }

    private void Update()
    {
        GetComponent<MeshRenderer>().material.color += new Color(0, 0.1f, 0) * Time.deltaTime;
        if (GetComponent<MeshRenderer>().material.color.g < 1f)
        {
            GetComponent<MeshRenderer>().material.color += new Color(0, 0.1f, 0) * Time.deltaTime;
        }
        else
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
        }
        if (GetComponent<Light>().intensity < 1f)
        {
            GetComponent<Light>().intensity += 0.1f * Time.deltaTime;
        }
        else
        {
            GetComponent<Light>().intensity = 0f;
        }
    }
}