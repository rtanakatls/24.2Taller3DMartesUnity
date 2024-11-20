using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextController : MonoBehaviour
{
    private static TextController instance;

    public static TextController Instance { get { return instance; } }

    [SerializeField] private GameObject container;
    [SerializeField] private TextMeshProUGUI messageText;
    private List<string> texts;
    private float delay;


    private void Awake()
    {
        instance = this;
    }

    public void SetUp(List<string> texts, float delay)
    {
        this.texts = texts;
        this.delay = delay;
        StopAllCoroutines();
        StartCoroutine(ShowText());
    }

    private IEnumerator ShowText()
    {
        container.SetActive(true);
        int currentIndex=0;
        while (currentIndex < texts.Count)
        {
            messageText.text = texts[currentIndex];
            currentIndex++;
            yield return new WaitForSeconds(delay);
        }

        container.SetActive(false);
    }


}
