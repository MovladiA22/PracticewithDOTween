using DG.Tweening;
using UnityEngine;

public class ScaleChanger : MonoBehaviour
{
    [SerializeField] private Vector3 _scale;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeat;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOScale(_scale, _duration).SetLoops(_repeat, _loopType);
    }
}
