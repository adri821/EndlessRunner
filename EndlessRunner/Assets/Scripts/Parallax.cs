using UnityEngine;

public class Parallax : MonoBehaviour {

    public float velocidadParallax = 0.5f; // Velocidad de desplazamiento de esta capa
    public GameObject camara; // Referencia pública a la cámara
    private Vector3 posicionInicial; // Posición inicial de la imagen del fondo
                                     // -------------------------------------------------------------------------
    private float anchoImagen; // Tamaño del fondo para saber cuándo repetirlo
                               // -------------------------------------------------------------------------
                               // Start se llama una vez antes de la ejecución del primer frame
    void Start() {
        posicionInicial = transform.position; // Almacenamos la posición inicial del fondo
                                              // ----------------------------------------------------------------------------------------
        SpriteRenderer renderer = GetComponent<SpriteRenderer>(); // Obtenemos el ancho del fondo
        anchoImagen = renderer.bounds.size.x; // usando el tamaño del SpriteRenderer
                                              // ----------------------------------------------------------------------------------------
    }
    // Update se llama una vez en cada frame
    void Update() {
        // Movemos la capa en función de la pos. actual de la cámara y la vel. del parallax
        float desplazamiento = camara.transform.position.x * velocidadParallax;
        // Aplicamos el nuevo posicionamiento del fondo
        transform.position = (Vector2)posicionInicial + (Vector2.right * desplazamiento);
        // -----------------------------------------------------------------------------------------------------------------
        // Verificamos si la cámara ha llegado al borde de la imagen
        if (camara.transform.position.x - transform.position.x >= anchoImagen) {
            posicionInicial += Vector3.right * anchoImagen; // Reposicionamos la capa para que parezca un fondo infinito
        }
        else if (transform.position.x - camara.transform.position.x >= anchoImagen) {
            posicionInicial -= Vector3.right * anchoImagen; // Reposicionamos la capa para que parezca un fondo infinito
        }
        // -----------------------------------------------------------------------------------------------------------------
    }
}
