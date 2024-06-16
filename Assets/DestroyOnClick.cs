using UnityEngine;

public class DestroyOnClick : MonoBehaviour
{
    void Update()
    {
        // Debug Log to check the camera reference
        Debug.Log("Main Camera: " + Camera.main);

        if (Input.GetMouseButtonDown(0))
        {
            // Create a ray from the camera through the mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            // Storage for information about the hit
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                // Debug Log to confirm hitInfo
                Debug.Log("Raycast Hit: " + hitInfo.collider);

                // Ensure the hit object is not null and the game object matches
                if (hitInfo.collider != null && hitInfo.collider.gameObject == gameObject)
                {
                    // Debug Log before destroy
                    Debug.Log("Destroying GameObject: " + gameObject.name);

                    // Destroy the game object
                    Destroy(gameObject);
                }
            }
        }
    }
}
