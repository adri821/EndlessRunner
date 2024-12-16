using UnityEngine;

public class PlayerController : MonoBehaviour
{
   /* public int fuerza = 1;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) GetComponent<Rigidbody2D>().AddForce(Vector2.up * fuerza, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.CompareTag("Enemy")) Time.timeScale = 0;
        if (collision.collider.CompareTag("Ground")) Time.timeScale = 0;
    }*/
    public int fuerza = 1;

    private void Update() {
        // Aplicar fuerza hacia arriba al presionar la barra espaciadora
        if (Input.GetKeyDown(KeyCode.Space)) {
            GetComponent<Rigidbody>().AddForce(Vector3.up * fuerza, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision) {
        // Detener el tiempo si colisiona con un objeto con la etiqueta "Enemy" o "Ground"
        if (collision.collider.CompareTag("Body") 
            //|| collision.collider.CompareTag("Ground")
            ) {
            Time.timeScale = 0;
        }
    }
}
