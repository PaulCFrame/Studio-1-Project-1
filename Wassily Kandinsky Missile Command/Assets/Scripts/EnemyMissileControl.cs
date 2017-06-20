using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMissileControl : MonoBehaviour {

    public int enemyTraj;

    // Use this for initialization
    void Start()
    {
        enemyTraj = Random.Range(1, 4);

        if (enemyTraj == 1)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -3);
        }

        if (enemyTraj == 2)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -4);
        }

        if (enemyTraj == 3)
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -5);
        }
    }

      public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Missile") || other.gameObject.CompareTag("Finish"))
            Destroy(other.gameObject);
    }

}
	


