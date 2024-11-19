using TMPro;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    public int desplazamiento;

    void Update()
    {
        transform.position = new Vector2(transform.position.x, Mathf.PingPong(Time.time * speed, desplazamiento));
    }

    /*private void OnBecameInvisible() {
        transform.position = GameObject.FindGameObjectWithTag("SpawnPoint").transform.position;
    }*/

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.CompareTag("Muro")) {
            //transform.position = GameObject.FindGameObjectWithTag("SpawnPoint").transform.position;
            GameObject nuevoEnemigo = Instantiate(Resources.Load<GameObject>("Prefabs/Enemy"), GameObject.FindGameObjectWithTag("SpawnPoint").transform);
            nuevoEnemigo.transform.SetParent(null);
            GameManager.score++;
            GameObject.FindGameObjectWithTag("Score").GetComponent<TextMeshProUGUI>().text = "Score: " + GameManager.score.ToString();
            Destroy(this.gameObject);
        }
    }
}
