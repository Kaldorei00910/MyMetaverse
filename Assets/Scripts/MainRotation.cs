using UnityEngine;

public class MainRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer charactorRenderer;

    private MainController controller;

    private void Awake()
    {
        controller = GetComponent<MainController>();
    }

    private void Start()
    {
        controller.OnLookEvent += OnAim;
    }

    private void OnAim(Vector2 direction)
    {
        RotateArm(direction);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotz = Mathf.Atan2(direction.y, direction.x)*Mathf.Rad2Deg;

        charactorRenderer.flipX = Mathf.Abs(rotz)>90f;
    }
}