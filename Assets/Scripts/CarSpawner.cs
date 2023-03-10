using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    //public float spawnDelay = .3f;

    public GameObject car;
    public Transform[] spawnPoints;

    float nextTimeToSpawn = 0f;

    float newspawn = SpawnSpeed.CarSpawnSpeed;

    void Update ()
    {
        if (nextTimeToSpawn <= Time.time)
        {
            SpawnCar();
            //nextTimeToSpawn = Time.time + spawnDelay;
            nextTimeToSpawn = Time.time + newspawn;
        }
    }

    void SpawnCar ()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];

        Instantiate(car, spawnPoint.position, spawnPoint.rotation);
    }
}
