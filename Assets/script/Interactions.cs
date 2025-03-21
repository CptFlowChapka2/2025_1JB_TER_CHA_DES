using UnityEngine;

public class Interactions : MonoBehaviour
{
    private bool animReady = true;
    [SerializeField] private Animator animGuard; //permet d'obtenir l'animateur

    [SerializeField] private string idleAnimName;




    private void OnTriggerEnter(Collider other)
    {
        // V�rifie si le joueur a activ� le trigger
        if (other.CompareTag("Player") && animReady == true)
        {
            animGuard.SetBool(idleAnimName, false);
            animReady = false;


        }


    }
    
    private void OnTriggerExit(Collider other) //Check if the player leave the trigger
    {
       
        if (other.CompareTag("Player"))
        {
            animGuard.SetBool(idleAnimName, true);
        }
    }


}
