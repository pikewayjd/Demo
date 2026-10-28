using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public GameObject[] enemyWaves;

    private float waveTimer = 0, waveWait = 4;
    // Update is called once per frame
    void Update()
    {
        waveTimer += Time.deltaTime;

        if (waveTimer > waveWait) {
            waveTimer = 0;
            Instantiate(enemyWaves[Random.Range(0, enemyWaves.Length -1)], transform.position, Quaternion.identity);
        }
    }
}
