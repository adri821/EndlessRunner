using UnityEngine;

public class BodyCollider : MonoBehaviour
{    
    public void OnCollisionEnter(Collision collision) {
        if (collision.collider.CompareTag("Muro")) {
            // Reenviar colisión al padre
            transform.parent.GetComponent<EnemyController>().OnBodyCollisionWithWall(collision);
        }
    }
}
