using UnityEngine;

public class FollowCar : MonoBehaviour
{
    public Transform carTransform;
    public float distance = 10.0f;
    public float height = 5.0f;

    void LateUpdate()
    {
        // Calcula la posición de la cámara
        Vector3 newPosition = carTransform.position - carTransform.forward * distance;
        newPosition.y = carTransform.position.y + height;

        // Actualiza la posición de la cámara
        transform.position = newPosition;

        // Hace que la cámara mire hacia el coche
        transform.LookAt(carTransform);
    }
}
