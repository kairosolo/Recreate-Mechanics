using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ActionScript : MonoBehaviour
{
    public static ActionScript Instance;
    [SerializeField] private TMP_Text actionText;

    private void Awake()
    {
        Instance = this;
    }

    public void PickUpText()
    {
        actionText.text = "Pick up";
    }

    public void ActionTextState(bool boolean)
    {
        actionText.gameObject.SetActive(boolean);
    }

    public void UpdateChargeText(float chargePercent)
    {
        actionText.text = $"Charging... {(chargePercent * 100):0}%";
    }

    public void ThrowText()
    {
        actionText.text = "E to drop\nHold F to throw";
    }
}