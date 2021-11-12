using System.Collections;
using UnityEngine;

public class RandomSpawn : MonoBehaviour
{
    public float spawn_delay = 5f;
    public GameObject prefab;
    public Transform spawn_point;
    public Vector2 volume;
    int spawn_count = 10;

    void  Start()
    {
        StartCoroutine("Medicine"); 
    }
         IEnumerator Medicine()
        {
            GameObject parent = new GameObject();
            while (spawn_count > 0)
            {
                spawn_count--;
                Vector2 pos = new Vector2(Random.Range(spawn_point.position.x - volume.x, spawn_point.position.x + volume.x), 
                    Random.Range(spawn_point.position.y - volume.y, spawn_point.position.y + volume.y));
                GameObject obj = Instantiate(prefab, pos, Quaternion.identity, parent.transform);
                yield return new WaitForSeconds(spawn_delay);
            }
        }
    }

   