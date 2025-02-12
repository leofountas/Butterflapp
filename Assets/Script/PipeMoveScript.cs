using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    private float moveSpeed = 10;
    public float deadZone = -50;

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        if (transform.position.x < deadZone) {
            Destroy(gameObject);
        } 
    }
}
