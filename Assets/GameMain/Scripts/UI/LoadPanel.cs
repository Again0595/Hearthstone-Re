using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using Unity.UNetWeaver;
using System;

public class LoadPanel : MonoBehaviour
{
    [SerializeField]
    private Text tips;
    [SerializeField]
    private Image logo;

    private void Start()
    {
        LoadingAni();
    }

    private void LoadingAni()
    {
        Sequence seq = DOTween.Sequence();
        seq.Append(logo.DOFade(1, 2));
        seq.Append(logo.DOFade(0, 2)).SetDelay(2f);
        seq.Append(tips.DOFade(1, 2));
        seq.Append(tips.DOFade(0, 2)).SetDelay(2f);
    }
}
