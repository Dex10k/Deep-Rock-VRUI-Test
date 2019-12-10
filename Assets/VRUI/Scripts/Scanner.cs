using UnityEngine;

public class Scanner : MonoBehaviour
{
    public Transform laserTarget;
    public float laserThickness;
    private bool isEnabled;
    private void OnEnable()
    {
        isEnabled = true;
    }

    private void OnDisable()
    {
        isEnabled = false;
    }

    private void Update()
    {
        if (isEnabled)
        {
            LineRenderer laser = GetComponent<LineRenderer>();
            laser.SetPosition(0, transform.TransformPoint(transform.position));
            laser.SetPosition(1, laserTarget.TransformPoint(laserTarget.position));
            laser.startWidth = laserThickness;
            laser.endWidth = laserThickness;
        }
        else
        {
            LineRenderer laser = GetComponent<LineRenderer>();
            laser.SetPosition(0, transform.TransformPoint(transform.position));
            laser.SetPosition(1, transform.TransformPoint(transform.position));
            laser.startWidth = 0f;
            laser.endWidth = 0f;
        }
    }
}
