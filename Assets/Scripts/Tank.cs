using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))] // ������ ��������� ���������� ������� � ������� �� ������� Rigidbody2D
public abstract class Tank : MonoBehaviour
{

    [Header("Общие характеристики:")]
    [Range(5, 50)][SerializeField] private int _maxHealth = 30;
    [Range(0f, 5f)][SerializeField] protected float _movementSpeed = 3f;
    [SerializeField] protected float _angleOffset = 90f;
    [Tooltip("Скорость поворота танка:")][SerializeField] protected float _rotationSpeed = 7f;
    [SerializeField] private int _points = 0;
    protected UI _ui;
    protected Rigidbody2D _rigidbody;
    protected int _currentHealth;





    protected virtual void Start()
    {
        _currentHealth = _maxHealth;
        _rigidbody = GetComponent<Rigidbody2D>();
        _ui = GameObject.FindGameObjectWithTag("UI").GetComponent<UI>();
    }

    public virtual void TakeDamage(int damage)
    {
        _currentHealth -= damage;
        if (_currentHealth <= 0)
        {
            Destroy(gameObject);
            Stats.Score += _points;
            _ui.UpdateScoreAndLevel();
        }
    }


    protected abstract void Move();


    protected void SetAngle(Vector3 target) // !!!!!!!!!!!!! ��������� !!!!!!!!!!!!!!!!
    {
        Vector3 deltaPosition = target - transform.position;
        float angleZ = Mathf.Atan2(deltaPosition.y, deltaPosition.x) * Mathf.Rad2Deg;
        Quaternion angle = Quaternion.Euler(0f, 0f, angleZ + _angleOffset);
        transform.rotation = Quaternion.Lerp(transform.rotation, angle, Time.deltaTime * _rotationSpeed);
    }


}
