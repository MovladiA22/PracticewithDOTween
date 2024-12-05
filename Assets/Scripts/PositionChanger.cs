using UnityEngine;
using DG.Tweening;

public class PositionChanger : MonoBehaviour
{
    [SerializeField] private Vector3 _position;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeat;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOMove(_position, _duration).SetLoops(_repeat, _loopType);
    }
}
