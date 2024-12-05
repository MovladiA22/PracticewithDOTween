using UnityEngine;
using DG.Tweening;

public class RotationChanger : DOTweenChanger
{
    [SerializeField] private Vector3 _rotation;

    private void Start()
    {
        Repeat(transform.DORotate(_rotation, _duration));
    }
}
