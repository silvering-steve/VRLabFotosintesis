using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Popup : MonoBehaviour
{
    public TextMeshProUGUI txtPopup;

    public void SetData(string value)
    {
        gameObject.SetActive(true);

        txtPopup.text = value;
    }

    public void ClickOk()
    {
        gameObject.SetActive(false);
    }
}
