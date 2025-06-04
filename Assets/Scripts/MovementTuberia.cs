using UnityEngine;

public class MovementTuberia : MonoBehaviour
{
    public float speed = 5f;
    public float minX = -15f;
    public float distanciaEntreTuberias = 10f;
    public int cantidadTotal = 5; 

    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.fixedDeltaTime;

        if (transform.position.x <= minX)
        {
            float nuevaY = Random.Range(-8f, -6f);

            float nuevoX = transform.position.x + (distanciaEntreTuberias * cantidadTotal);
            transform.position = new Vector3(nuevoX, nuevaY, transform.position.z);
        }
    }
}
