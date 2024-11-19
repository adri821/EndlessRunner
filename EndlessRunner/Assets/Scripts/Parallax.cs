using UnityEngine;

public class Parallax : MonoBehaviour {

    public float velocidadParallax = 0.5f; // Velocidad de desplazamiento de esta capa
    public GameObject camara; // Referencia p�blica a la c�mara
    private Vector3 posicionInicial; // Posici�n inicial de la imagen del fondo
                                     // -------------------------------------------------------------------------
    private float anchoImagen; // Tama�o del fondo para saber cu�ndo repetirlo
                               // -------------------------------------------------------------------------
                               // Start se llama una vez antes de la ejecuci�n del primer frame
    void Start() {
        posicionInicial = transform.position; // Almacenamos la posici�n inicial del fondo
                                              // ----------------------------------------------------------------------------------------
        SpriteRenderer renderer = GetComponent<SpriteRenderer>(); // Obtenemos el ancho del fondo
        anchoImagen = renderer.bounds.size.x; // usando el tama�o del SpriteRenderer
                                              // ----------------------------------------------------------------------------------------
    }
    // Update se llama una vez en cada frame
    void Update() {
        // Movemos la capa en funci�n de la pos. actual de la c�mara y la vel. del parallax
        float desplazamiento = camara.transform.position.x * velocidadParallax;
        // Aplicamos el nuevo posicionamiento del fondo
        transform.position = (Vector2)posicionInicial + (Vector2.right * desplazamiento);
        // -----------------------------------------------------------------------------------------------------------------
        // Verificamos si la c�mara ha llegado al borde de la imagen
        if (camara.transform.position.x - transform.position.x >= anchoImagen) {
            posicionInicial += Vector3.right * anchoImagen; // Reposicionamos la capa para que parezca un fondo infinito
        }
        else if (transform.position.x - camara.transform.position.x >= anchoImagen) {
            posicionInicial -= Vector3.right * anchoImagen; // Reposicionamos la capa para que parezca un fondo infinito
        }
        // -----------------------------------------------------------------------------------------------------------------
    }
}
