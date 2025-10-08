using UnityEngine;

public class Tower : MonoBehaviour
{
    void Start()
    {
        float randomScale = Random.Range(0.5f, 2.0f);

        transform.localScale = new Vector3(1, randomScale, 1);
    }
}