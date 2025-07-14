using UnityEngine;
using TMPro;
using DG.Tweening;
using System.Collections;

public class DOTweenTextAnimation2 : MonoBehaviour
{
    public TMP_Text tmpText;

    private string fullText =
        "Welcome to the creator app.\n\n" +
        "You are only a click away to your best filter experience.";


    public float typeDelay = 0.05f;

    private void Start()
    {
        AnimateText();
    }

    void AnimateText()
    {
        tmpText.alpha = 0;
        tmpText.transform.localScale = Vector3.zero;

        tmpText.DOFade(1, 1f).SetEase(Ease.InOutSine);
        tmpText.transform.DOScale(Vector3.one, 1f).SetEase(Ease.OutBounce).OnComplete(() =>
        {
            StartCoroutine(Typewriter());
        });
    }

    IEnumerator Typewriter()
    {
        tmpText.text = "";
        foreach (char c in fullText)
        {
            tmpText.text += c;
            yield return new WaitForSeconds(typeDelay);
        }
    }
}
