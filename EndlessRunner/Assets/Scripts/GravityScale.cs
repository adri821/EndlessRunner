using UnityEngine;

public class GravityScale : MonoBehaviour
{
    public float gravityScale = 1f; //The gravity scale
    Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        rb.AddForce(Physics.gravity * gravityScale, ForceMode.Acceleration);//It has to be FixedUpdate, because it applies force to the rigidbody constantly.
    }
}