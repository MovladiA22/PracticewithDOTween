using UnityEngine;
using DG.Tweening;

public class RotationChanger : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeat;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DORotate(_rotation, _duration).SetLoops(_repeat, _loopType);
    }
}
