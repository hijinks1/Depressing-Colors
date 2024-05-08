using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Typing : MonoBehaviour
{
     [SerializeField] public TextMeshProUGUI _textMeshPro;
     public string[] stringArray;
     [SerializeField] public float timeBetweenChars;
     [SerializeField] public float timeBetweenWords;
     private int i = 0;
    void Start()
    {
        EndCheck();
    }

    void EndCheck()
    {
        if (i <= stringArray.Length - 1)
        {
            _textMeshPro.text = stringArray[i];
            StartCoroutine(TextVisible());
        }
    }

    public IEnumerator TextVisible()
    {
        _textMeshPro.ForceMeshUpdate();
        int totalVisibleCharacters = _textMeshPro.textInfo.characterCount;
        int counter = 0;

        while (true)
        {
            int visibleCount = counter % (totalVisibleCharacters + 1);
            _textMeshPro.maxVisibleCharacters = visibleCount;

            if (visibleCount >= totalVisibleCharacters)
            {
                i += 1;
                Invoke("EndCheck", timeBetweenWords);
                break;
            }
            
            counter += 1;
            yield return new WaitForSeconds(timeBetweenChars);
        }
    }
   
}
