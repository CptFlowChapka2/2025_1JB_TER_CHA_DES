using UnityEngine;

public class AnimalStart : MonoBehaviour
{
    public float speed = 5f; // Vitesse du mouvement

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("NPC"))
        {
            Destroy(gameObject);
        }
    }
}
