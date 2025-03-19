using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller  : MonoBehaviour
{
    [Header("Sensibilit� de la cam�ra")]
    public float sensX = 100f;
    public float sensY = 100f;

    public Transform Orientation; // Orientation du joueur (le Transform qui guide la rotation)

    // Variables pour stocker les rotations de la cam�ra
    float rotX;
    float rotY;

    void Start()
    {
        // Verrouille le curseur au centre de l'�cran et le rend invisible
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        HandleCameraRotation();
    }

    /// Gestion de la rotation de la cam�ra
    private void HandleCameraRotation()
    {
        // R�cup�re les inputs de la souris
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * sensY;

        rotX -= mouseY;
        rotY += mouseX;

        // Limite la rotation verticale pour �viter que la cam�ra ne fasse un tour complet sur l'axe X
        rotX = Mathf.Clamp(rotX, -90f, 90f);

        // Applique la rotation � la cam�ra
        transform.rotation = Quaternion.Euler(rotX, rotY, 0);

        // Oriente le joueur (Orientation) selon la rotation horizontale
        Orientation.rotation = Quaternion.Euler(0, rotY, 0);

    }
}
