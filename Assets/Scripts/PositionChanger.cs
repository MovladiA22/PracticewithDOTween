using UnityEngine;
using DG.Tweening;

public class PositionChanger : DOTweenChanger
{
    [SerializeField] private Vector3 _position;

    private void Start()
    {
        Repeat(transform.DOMove(_position, _duration));
    }
}
