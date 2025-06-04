using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
public class OnClick : MonoBehaviour
{
    public UnityEvent onClickUp;
    public UnityEvent onClickDown;

    private float _height;
    private float _currentPosition;

    private void Start()
    {
        _height = Screen.height/2;
    }
    public void MoveMouse(InputAction.CallbackContext context)
    {
        _currentPosition = context.ReadValue<Vector2>().y;
    }
    public void OnClickPress(InputAction.CallbackContext context)
    {
        if(context.performed) return;
        if (_height > _currentPosition)
        {
            onClickDown?.Invoke();
        }
        else
        {
            onClickUp?.Invoke();
        }
    }
}


