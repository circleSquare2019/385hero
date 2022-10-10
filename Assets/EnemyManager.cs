using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject plane; //blueprint for planes = prefab

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    
    }

    public void createPlane()
    {
        GameObject spawnedPlane = Instantiate(plane);
        spawnedPlane.GetComponent<Enemy>().manager = this;
        Vector2 v = Random.insideUnitCircle * 90f;

        spawnedPlane.transform.position = new Vector3(v.x, v.y, 0.0f);;

    }
}
