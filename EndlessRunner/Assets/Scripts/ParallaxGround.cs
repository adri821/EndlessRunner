using UnityEngine;

public class ParallaxGround : MonoBehaviour {

    public float velocidadParallax = 0.5f; // Velocidad de desplazamiento de esta capa
    public GameObject camara; // Referencia pública a la cámara
    private Vector3 posicionInicial; // Posición inicial del plano
    private Vector2 offsetInicial; // Offset inicial de la textura del material
    private Renderer planoRenderer; // Renderer del plano

    void Start() {
        // Almacenamos la posición inicial del plano y el offset inicial de la textura
        posicionInicial = transform.position;
        planoRenderer = GetComponent<Renderer>();
        offsetInicial = planoRenderer.material.mainTextureOffset;
    }

    void Update() {
        // Calculamos el desplazamiento del parallax basado en la posición de la cámara
        float desplazamiento = -camara.transform.position.x * velocidadParallax;

        // Actualizamos el offset de la textura para simular el parallax
        Vector2 nuevoOffset = offsetInicial + Vector2.right * desplazamiento;
        planoRenderer.material.mainTextureOffset = nuevoOffset;

        // Si deseas reposicionar el plano para simular un efecto infinito, puedes hacerlo
        // aunque para la mayoría de los casos con texturas repetitivas no es necesario.
        float diferencia = camara.transform.position.x - transform.position.x;
        if (Mathf.Abs(diferencia) >= 10f) // Por ejemplo, un límite de 10 unidades
        {
            transform.position += Vector3.right * Mathf.Sign(diferencia) * 10f;
        }
    }
}
