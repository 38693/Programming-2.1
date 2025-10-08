using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    public GameObject towerPrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            Vector3 randomPos = new Vector3(
                Random.Range(-10f, 10f),
                0,
                Random.Range(-10f, 10f)
            );

            Instantiate(towerPrefab, randomPos, Quaternion.identity);
        }
    }
}