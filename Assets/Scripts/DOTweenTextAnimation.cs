using UnityEngine;
using TMPro;
using DG.Tweening;
using System.Collections;

public class DOTweenTextAnimation : MonoBehaviour
{
    public TMP_Text tmpText;

    private string fullText =
        "Name of Creator: Oden Emmanuel Mbang\n\n" +
        "Intake: January 2023\n\n" +
        "Specialization: AR/VR\n\n" +
        "This is a Face-Filter Project designed to work on just Android devices. " +
        "The goal of the project is to track the user's face and implement three filters: " +
        "a mask, a hat, and a cat nose.";

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
