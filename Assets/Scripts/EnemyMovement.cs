using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveRange = 3f;
    public float moveSpeed = 2f;
    public float pulseSpeed = 2f;
    public float pulseSize = 0.3f;

    private Vector3 startPos;
    private Vector3 startScale;

    void Start()
    {
        GetComponent<Renderer>().material = new Material(GetComponent<Renderer>().material);

        startPos = transform.position;
        startScale = transform.localScale;
    }

    void Update()
    {
        float offset = Mathf.Sin(Time.time * moveSpeed) * moveRange;
        transform.position = startPos + new Vector3(offset, 0, 0);

        float scaleFactor = 1 + Mathf.Sin(Time.time * pulseSpeed) * pulseSize;
        transform.localScale = startScale * scaleFactor;
    }
}
