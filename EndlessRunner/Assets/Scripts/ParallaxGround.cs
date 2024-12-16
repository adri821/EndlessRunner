using UnityEngine;

public class ParallaxGround : MonoBehaviour {

    public float velocidadParallax = 0.5f; // Velocidad de desplazamiento de esta capa
    public GameObject camara; // Referencia p�blica a la c�mara
    private Vector3 posicionInicial; // Posici�n inicial del plano
    private Vector2 offsetInicial; // Offset inicial de la textura del material
    private Renderer planoRenderer; // Renderer del plano

    void Start() {
        // Almacenamos la posici�n inicial del plano y el offset inicial de la textura
        posicionInicial = transform.position;
        planoRenderer = GetComponent<Renderer>();
        offsetInicial = planoRenderer.material.mainTextureOffset;
    }

    void Update() {
        // Calculamos el desplazamiento del parallax basado en la posici�n de la c�mara
        float desplazamiento = -camara.transform.position.x * velocidadParallax;

        // Actualizamos el offset de la textura para simular el parallax
        Vector2 nuevoOffset = offsetInicial + Vector2.right * desplazamiento;
        planoRenderer.material.mainTextureOffset = nuevoOffset;

        // Si deseas reposicionar el plano para simular un efecto infinito, puedes hacerlo
        // aunque para la mayor�a de los casos con texturas repetitivas no es necesario.
        float diferencia = camara.transform.position.x - transform.position.x;
        if (Mathf.Abs(diferencia) >= 10f) // Por ejemplo, un l�mite de 10 unidades
        {
            transform.position += Vector3.right * Mathf.Sign(diferencia) * 10f;
        }
    }
}
