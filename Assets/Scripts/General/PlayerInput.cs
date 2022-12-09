using UnityEngine;
public class PlayerInput : MonoBehaviour
{
    public Vector3 InputVector()
    {
        return Input.acceleration;
    }
}