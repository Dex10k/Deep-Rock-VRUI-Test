using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeed=1f;

    private void Update()
    {
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
