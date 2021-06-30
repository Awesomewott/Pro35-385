using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMove : MonoBehaviour
{
    private void OnEnable()
    {
        TouchManager.Instance.touchHeldEvent += Move;
    }

    private void OnDisable()
    {
        TouchManager.Instance.touchHeldEvent -= Move;
    }

    private void Move( Vector2 position)
    {
        Vector3 screen = new Vector3(position.x, position.y, 10);
        Vector3 world = Camera.main.ScreenToWorldPoint(screen);

        transform.position = world;
    }
}
