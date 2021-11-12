using UnityEngine;

public class Fuel : MonoBehaviour
{
    public EnemyFollow enemyFollow;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            FuelMeter.fuel++;          
            Destroy(gameObject);
            EnemySpeed();
        }
    }
    private void EnemySpeed()
    {
        enemyFollow = GameObject.Find("Enemy").GetComponent<EnemyFollow>();
        enemyFollow.speed+=0.5f;
    }
}
