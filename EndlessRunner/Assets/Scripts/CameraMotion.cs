using UnityEngine;

public class CamaraMotion : MonoBehaviour
{
    // Atributo público para especificar la velocidad de la cámara
    public int cameraSpeed;
    // Método que se ejecuta una vez por cada frame
    private void Update() {
        // Detectamos si el desplazamiento es hacia la derecha
        /*if (Input.GetAxisRaw("Horizontal") == 1) {
            // Muevo la cámara a la derecha
            transform.position = transform.position + (Vector3.right * cameraSpeed * Time.deltaTime);
        }
        // Detectamos si el desplazamiento es hacia la izquierda
        if (Input.GetAxisRaw("Horizontal") == -1) {
            // Muevo la cámara a la izquierda
            transform.position = transform.position + (Vector3.left * cameraSpeed * Time.deltaTime);
        }*/
        transform.position = transform.position + (Vector3.right * cameraSpeed * Time.deltaTime);
    }
}
