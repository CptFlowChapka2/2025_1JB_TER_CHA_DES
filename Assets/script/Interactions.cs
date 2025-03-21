using UnityEngine;

public class Interactions : MonoBehaviour
{
    [SerializeField] private bool animReady = true;
    [SerializeField] private string idle = "Idle";
    [SerializeField] private string talking = "Talking";
    [SerializeField] private Animator animGuard;

    private void Start()
    {
        animGuard = GetComponent<Animator>();
    }


    private void OnTriggerEnter(Collider other)
    {
        // Vérifie si le joueur a activé le trigger
        if (other.CompareTag("Player") && animReady == true)
        {
            animGuard.Play(talking, 0, 0.0f); // AnimatorName.Play(animation, layer, time before the animation start)
            animReady = false;

        }

        else
        {
            animGuard.Play(idle, 0, 0.0f); // AnimatorName.Play(animation, layer, time before the animation start)
        }
    }




}
