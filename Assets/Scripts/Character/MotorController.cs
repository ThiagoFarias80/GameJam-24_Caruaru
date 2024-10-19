using UnityEngine;

public class MotorController : MonoBehaviour
{
    private Vector2 _direction;
    [SerializeField] private float _manueverability;
    private void Update()
    {
        transform.position += new Vector3(_direction.x,0,0) * Time.deltaTime * _manueverability;
    }
    public void Move(Vector2 direction)
    {
         _direction = direction;
    }
}
