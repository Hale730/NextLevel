using UnityEngine;

public class Brick : MonoBehaviour
{
    void OnMouseDown()
    {
        // This is called when the user clicks on the collider
        Destroy(gameObject);
    }
}
