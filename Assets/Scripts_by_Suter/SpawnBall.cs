using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject tennisBall;
    public GameObject ballSpawner;
    public Vector3 ballSpawnLoc;

    // Start is called before the first frame update
    void Start()
    {
        ballSpawnLoc = ballSpawner.transform.position;
    }

    public void SpawnBallNow()
    {
        Instantiate(tennisBall, ballSpawnLoc, Quaternion.identity);
    }
}
