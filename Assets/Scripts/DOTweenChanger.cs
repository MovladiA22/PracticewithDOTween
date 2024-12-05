using DG.Tweening;
using UnityEngine;

public class DOTweenChanger : MonoBehaviour
{
    [SerializeField] protected float _duration;
    [SerializeField] private int _repeat;
    [SerializeField] private LoopType _loopType;

    protected Tween Repeat(Tween tween)
    {
        return tween.SetLoops(_repeat, _loopType);
    }    
}
