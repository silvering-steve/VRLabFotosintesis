using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageCredit : MonoBehaviour
{
    private void OnEnable()
    {
        StartCoroutine(ie_exit());
    }

    IEnumerator ie_exit()
    {
        yield return new WaitForSeconds(4f);
        Application.Quit();
    }
}
