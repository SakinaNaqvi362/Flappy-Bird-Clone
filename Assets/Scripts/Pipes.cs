using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 5f;
    private float leftEdge;

    private void Start()
    {
        // Calculate off-screen position where pipes should be destroyed
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }

    private void Update()
    {
        // Move pipes left
        transform.position += Vector3.left * speed * Time.deltaTime;

        // Destroy when off-screen
        if (transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }
}