using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller  : MonoBehaviour
{
    [Header("Sensibilité de la caméra")]
    public float sensX = 100f;
    public float sensY = 100f;

    public Transform Orientation; // Orientation du joueur (le Transform qui guide la rotation)

    // Variables pour stocker les rotations de la caméra
    float rotX;
    float rotY;

    void Start()
    {
        // Verrouille le curseur au centre de l'écran et le rend invisible
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        HandleCameraRotation();
    }

    /// Gestion de la rotation de la caméra
    private void HandleCameraRotation()
    {
        // Récupère les inputs de la souris
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * sensY;

        rotX -= mouseY;
        rotY += mouseX;

        // Limite la rotation verticale pour éviter que la caméra ne fasse un tour complet sur l'axe X
        rotX = Mathf.Clamp(rotX, -90f, 90f);

        // Applique la rotation à la caméra
        transform.rotation = Quaternion.Euler(rotX, rotY, 0);

        // Oriente le joueur (Orientation) selon la rotation horizontale
        Orientation.rotation = Quaternion.Euler(0, rotY, 0);

    }
}
