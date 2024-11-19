using UnityEngine;

public class CamaraMotion : MonoBehaviour
{
    // Atributo p�blico para especificar la velocidad de la c�mara
    public int cameraSpeed;
    // M�todo que se ejecuta una vez por cada frame
    private void Update() {
        // Detectamos si el desplazamiento es hacia la derecha
        /*if (Input.GetAxisRaw("Horizontal") == 1) {
            // Muevo la c�mara a la derecha
            transform.position = transform.position + (Vector3.right * cameraSpeed * Time.deltaTime);
        }
        // Detectamos si el desplazamiento es hacia la izquierda
        if (Input.GetAxisRaw("Horizontal") == -1) {
            // Muevo la c�mara a la izquierda
            transform.position = transform.position + (Vector3.left * cameraSpeed * Time.deltaTime);
        }*/
        transform.position = transform.position + (Vector3.right * cameraSpeed * Time.deltaTime);
    }
}
