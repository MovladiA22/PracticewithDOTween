using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    private const string Text1 = "Заменил";
    private const string Text2 = "Добавил";
    private const string Text3 = "Взломал";

    [SerializeField] private Text _textFild;
    [SerializeField] private float _firstDelay;
    [SerializeField] private float _secondDelay;
    [SerializeField] private float _duration;

    private void Start()
    {
        _textFild.DOText(Text1, _duration);
        _textFild.DOText(Text2, _duration).SetRelative().SetDelay(_firstDelay);
        _textFild.DOText(Text3, _duration, true, ScrambleMode.All).SetDelay(_secondDelay);
    }
}
