using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    private Transform _transform;
    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        var mousePosition = Input.mousePosition;
        _transform.position = new Vector2(mousePosition.x, mousePosition.y);
    }
}
