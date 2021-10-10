using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    [SerializeField]
    private GameObject page_op1;
    [SerializeField]
    private GameObject page_op2;

    [SerializeField]
    public GameObject page_mainMenu;

    private void Start()
    {
        StartCoroutine(ie_op1());
    }


    IEnumerator ie_op1()
    {
        yield return new WaitForSeconds(4f);
        StartCoroutine(ie_op2());
        page_op1.SetActive(false);

    }

    IEnumerator ie_op2()
    {
        page_op2.SetActive(true);
        yield return new WaitForSeconds(4f);
        page_op2.SetActive(false);
        page_mainMenu.SetActive(true);

    }

}
