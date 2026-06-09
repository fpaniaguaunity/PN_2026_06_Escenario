using UnityEngine;

public class MultiCameraController : MonoBehaviour
{
    public Camera[] cameras; // Array de cámaras a controlar
    private int currentCameraIndex = 0; // Índice de la cámara actualmente activa
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cameras[currentCameraIndex].gameObject.SetActive(true); // Activar la primera cámara al inicio
        // Desactivar las demás cámaras
        for (int i = 1; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            // Desactivar la cámara actual
            cameras[currentCameraIndex].gameObject.SetActive(false);
            // Incrementar el índice de la cámara
            currentCameraIndex = (currentCameraIndex + 1) % cameras.Length; // Volver al inicio si se supera el número de cámaras
            // Activar la nueva cámara
            cameras[currentCameraIndex].gameObject.SetActive(true);
        }
    }
    
}
