using UnityEngine;
using System.Collections;

public class EnemyRespawn : MonoBehaviour
{
    public float respawnTime = 3f; 
    private Renderer rend;
    private Collider col;

    void Start()
    {
        rend = GetComponent<Renderer>();
        col = GetComponent<Collider>();
    }

    public void RespawnEnemy()
    {
        StartCoroutine(RespawnRoutine());
    }

    IEnumerator RespawnRoutine()
    {
        rend.enabled = false;
        col.enabled = false;

        yield return new WaitForSeconds(respawnTime);

        rend.enabled = true;
        col.enabled = true;
    }
}
