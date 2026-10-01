using UnityEngine;
using UnityEngine.Rendering;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;

    public float moveSpeed = 1;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Launch();
    }

    void Launch()
    {
        // Random initial direction
        float x = Random.value < 0.5f ? -1f : 1f;
        float y = Random.Range(-0.5f, 0.5f);
        Vector2 dir = new Vector2(x, y).normalized;
        rb.linearVelocity = dir * moveSpeed;
    }

    public void ResetBall()
    {
        transform.position = Vector2.zero;
        rb.linearVelocity = Vector2.zero;
        Launch();
    }
}
