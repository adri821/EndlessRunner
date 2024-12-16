using TMPro;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    public int desplazamiento;

    void Update() {
        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * speed, desplazamiento), transform.position.z);
    }

    public void OnBodyCollisionWithWall(Collision collision) {
        GameObject nuevoEnemigo = Instantiate(Resources.Load<GameObject>("Prefabs/Enemy"), GameObject.FindGameObjectWithTag("SpawnPoint").transform.position, Quaternion.identity);
        nuevoEnemigo.transform.SetParent(null);
        nuevoEnemigo.transform.rotation = Quaternion.Euler(0, 180, 0);

        GameManager.score++;
        GameObject.FindGameObjectWithTag("Score").GetComponent<TextMeshProUGUI>().text = "Score: " + GameManager.score.ToString();

        Destroy(this.gameObject);
    }
}
