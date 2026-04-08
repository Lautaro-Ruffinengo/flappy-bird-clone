using UnityEngine;

public class TubesObstacle : MonoBehaviour
{
    [SerializeField] GameConfigSO gameConfigSO;

    [SerializeField] private float screenOffset = -10;

    private void Update()
    {
        //Debug.Log(Camera.main.WorldToScreenPoint(transform.position));
        LateralMovement();
        DestroyObject();
    }

    private void LateralMovement()
    {
        transform.Translate(Vector2.left * gameConfigSO.tubesMovementSpeed * Time.deltaTime);
    }

    private void DestroyObject()
    {
        //convert world position to screen pixels
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if(screenPosition.x < 0 + screenOffset)
        {
            Destroy(gameObject);
        }
    }
}
