using DG.Tweening;
using UnityEngine;

public class ScaleChanger : DOTweenChanger
{
    [SerializeField] private Vector3 _scale;

    private void Start()
    {
        Repeat(transform.DOScale(_scale, _duration));
    }
}
