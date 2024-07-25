using UnityEngine;

public class FollowCar : MonoBehaviour
{
    public Transform carTransform;
    public float distance = 10.0f;
    public float height = 5.0f;

    void LateUpdate()
    {
        // Calcula la posici�n de la c�mara
        Vector3 newPosition = carTransform.position - carTransform.forward * distance;
        newPosition.y = carTransform.position.y + height;

        // Actualiza la posici�n de la c�mara
        transform.position = newPosition;

        // Hace que la c�mara mire hacia el coche
        transform.LookAt(carTransform);
    }
}
