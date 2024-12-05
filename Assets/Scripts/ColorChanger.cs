using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class ColorChanger : DOTweenChanger
{
    [SerializeField] private Color _color;

    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void Start()
    {
        Repeat(_renderer.material.DOColor(_color, _duration));
    }
}
