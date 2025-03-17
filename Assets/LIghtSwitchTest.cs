using UnityEngine;

public class LIghtSwitchTest : MonoBehaviour
{
    private Color ColMemory;//iniatlise une variable de type couleur


    private void Start()
    {
        ColMemory = gameObject.GetComponent<MeshRenderer>().material.color;//la variable se souvient de la couleur initial de cet object
    }
    private void OnMouseDown()
    {
        gameObject.GetComponent<MeshRenderer>().material.color = Color.black;//fais tou nouar
        gameObject.GetComponent<Light>().enabled= !gameObject.GetComponent<Light>().enabled;//inverse la valeur actuelle de enable , etant un bollean false->true ; true->false
        if ((gameObject.GetComponent<Light>().enabled ==true)&&(gameObject.GetComponent<Light>().intensity >0))//si light est true & si son intensité est supérieur à 0
        {
            gameObject.GetComponent<MeshRenderer>().material.color = ColMemory;//fais plus tou nouar , on reprend la couleur initiale
            gameObject.GetComponent<Light>().intensity += -0.1f;//on soustrait 0,1 à l'intensité ,c'est dans cette condition pour evité de faire du négatif (que unity aprecirait peux)
        }
        if (gameObject.GetComponent<Light>().intensity == 0)//y'as plus lumiére ?
        {
            gameObject.GetComponent<Light>().intensity = 1f;//nah y'as lumiére !(comme ça ça boucle )
        }
    }
}
    
