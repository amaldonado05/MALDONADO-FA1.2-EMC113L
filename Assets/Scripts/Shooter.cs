using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject projectilePrefab;  
    public Transform spawnPoint;         
    public float launchForce = 15f;      
    public float angle = 20f;            

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(projectilePrefab, spawnPoint.position, spawnPoint.rotation);

        Rigidbody rb = bullet.GetComponent<Rigidbody>();

        Vector3 direction = Quaternion.Euler(-angle, 0f, 0f) * transform.forward;

        rb.linearVelocity = direction * launchForce;
    }
}
