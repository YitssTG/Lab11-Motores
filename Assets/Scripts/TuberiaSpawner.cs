using UnityEngine;

public class TuberiaSpawner : MonoBehaviour
{
    public GameObject tuberiaPrefab;
    public int cantidad = 5;
    public float distanciaEntreTuberias = 10f;
    public float startX = 10f;

    void Start()
    {
        for (int i = 0; i < cantidad; i++)
        {
            Vector3 pos = new Vector3(startX + i * distanciaEntreTuberias, Random.Range(-8f, -6f), 0f);
            GameObject tuberia = Instantiate(tuberiaPrefab, pos, Quaternion.identity);
        }
    }
}
