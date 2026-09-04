using TMPro;
using UnityEngine;

public class Demo : MonoBehaviour
{
    public TextMeshProUGUI textbox;

    public TextMeshProUGUI textbox2;

    public void ButtonClickMethod()
    {
        textbox.text = "I have changed";
    }
}
