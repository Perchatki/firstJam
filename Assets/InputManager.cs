using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;

    public UnityEvent LeftMouseButtonDown;

    public Vector3 MoveDirection
    {
        get =>
            ((Input.GetAxisRaw("Vertical") * Vector3.up) +
            (Input.GetAxisRaw("Horizontal") * Vector3.right)).normalized;
        private set { }
    }

    public Vector3 MousePosition { get => Camera.main.ScreenToWorldPoint(Input.mousePosition); private set { } }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance);
        }
        Instance = this;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) LeftMouseButtonDown.Invoke();
    }
}
