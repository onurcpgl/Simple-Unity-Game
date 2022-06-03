using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public MoveDino DinoScript;
    public GameObject Borular;
    public float height;
    public float time;


    void Start()
    {
        StartCoroutine(SpawbObject(time));
    }
    public IEnumerator SpawbObject(float time)
    {
        while (!DinoScript.isDead)
        {
            Instantiate(Borular, new Vector3(13, Random.Range(-height, height), 0), Quaternion.identity);
            yield return new WaitForSeconds(time);
        }

    }
}
