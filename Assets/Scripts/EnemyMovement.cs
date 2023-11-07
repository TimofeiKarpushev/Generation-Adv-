using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed;

    private void Update()
    {
        if (_target != null)
        {
            Vector3 direction = (_target.position - transform.position);
            direction.Normalize();

            transform.Translate(direction * _speed * Time.deltaTime);
        }
    }

    public void SetTarget(Transform target)
    {
        _target = target;
    }
}
