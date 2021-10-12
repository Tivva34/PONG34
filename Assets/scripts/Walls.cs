using UnityEngine;
using UnityEngine.EventSystems;
public class Walls : MonoBehaviour
{
    public EventTrigger.TriggerEvent _trigger;
    private object other;

    [SerializeField]
    private BoxCollider2D collider;

    public BoxCollider2D Collider { get => collider; private set => collider = value; }


    private void Start()
    {
        if (!Collider)
        {
            Collider = GetComponent<BoxCollider2D>();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            _trigger.Invoke(null);
            return;
        }


    }
}
