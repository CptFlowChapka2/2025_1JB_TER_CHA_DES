using UnityEngine;

public class Interactions : MonoBehaviour
{
    private bool animReady = true;
    [SerializeField] private Animator animGuard; //permet d'obtenir l'animateur

    [SerializeField] private string idleAnimBoolName; //permet de récupérer le nom de l'anim IDLE




    private void OnTriggerEnter(Collider other)
    {
        // Vérifie si le joueur a activé le trigger
        if (other.CompareTag("Player") && animReady == true)
        {
            animGuard.SetBool(idleAnimBoolName, false);
            animReady = false;


        }


    }
    
    private void OnTriggerExit(Collider other) //Check if the player leave the trigger
    {
       
        if (other.CompareTag("Player"))
        {
            animGuard.SetBool(idleAnimBoolName, true);
        }
    }


}
