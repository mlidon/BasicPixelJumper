using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed = 2f;
    public Transform pointA, pointB;
    private Vector3 target;
    private SpriteRenderer sr;

    void Start()
    {
        target = pointB.position;
        sr = GetComponent<SpriteRenderer>();
        
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (Vector3.Distance(transform.position, target) < 0.1f)
            target = target == pointA.position ? pointB.position : pointA.position;

        // Voltear sprite dependiendo de hacia dónde va
        sr.flipX = target == pointB.position; 
    }
}
