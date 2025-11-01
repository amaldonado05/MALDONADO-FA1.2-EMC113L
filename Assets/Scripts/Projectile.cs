using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float lifetime = 5f;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (ScoreManager.instance != null)
            {
                ScoreManager.instance.AddScore(1);
            }

            EnemyRespawn respawn = collision.gameObject.GetComponent<EnemyRespawn>();
            if (respawn != null)
            {
                respawn.RespawnEnemy();
            }

            Destroy(gameObject);
        }
    }
}
