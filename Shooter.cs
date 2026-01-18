using UnityEngine;
public class Shooter : MonoBehaviour {
    void Update() {
        if (Input.GetMouseButtonDown(0)) { // Clic gauche
            GameObject ball = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            ball.transform.position = transform.position;
            Rigidbody rb = ball.AddComponent<Rigidbody>();
            rb.AddForce(transform.forward * 1500f); // Propulse la balle
            Destroy(ball, 3f); // Détruit la balle après 3s pour ne pas ramer
        }
    }
}