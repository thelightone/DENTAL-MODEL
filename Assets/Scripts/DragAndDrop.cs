using UnityEngine;

public class DragAndDrop : MonoBehaviour
{

    private void OnMouseDrag()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        float plane = transform.position.z;

        float distance = (plane - ray.origin.z) / ray.direction.z;
        Vector3 point = ray.origin + ray.direction * distance;

        point.z = plane;

        transform.position = point;
    }
}
    

