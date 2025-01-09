using System.Collections.Generic;
using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCustomization : MonoBehaviour
{
    [SerializeField] private CharacterCustomization otherCharacterCustomization;
    [SerializeField] private Button changeGenderButton;
    [SerializeField] private CinemachineCamera cCamera;
    [SerializeField] private bool isDefault;

    [Space]
    [SerializeField] private List<Button> leftButtonList;

    [SerializeField] private List<Button> rightButtonList;

    [Space]
    [SerializeField] private List<GameObject> hairList;

    [SerializeField] private List<GameObject> topList;
    [SerializeField] private List<GameObject> bottomList;

    [Space]
    [SerializeField] private int currentHair;

    [SerializeField] private int currentTop;
    [SerializeField] private int currentBottom;

    private void Awake()
    {
        if (!isDefault) return;

        AssignButtons();
    }

    #region Hair Methods

    private void ChangeHairLeft()
    {
        currentHair--;
        if (currentHair < 0)
        {
            currentHair = hairList.Count - 1;
        }
        UpdateHairVisibility();
    }

    private void ChangeHairRight()
    {
        currentHair++;
        if (currentHair > hairList.Count - 1)
        {
            currentHair = 0;
        }
        UpdateHairVisibility();
    }

    private void UpdateHairVisibility()
    {
        foreach (var item in hairList)
        {
            item.SetActive(false);
        }
        hairList[currentHair].SetActive(true);
    }

    #endregion Hair Methods

    #region Top Methods

    private void ChangeTopLeft()
    {
        currentTop--;
        if (currentTop < 0)
        {
            currentTop = topList.Count - 1;
        }
        UpdateTopVisibility();
    }

    private void ChangeTopRight()
    {
        currentTop++;
        if (currentTop > topList.Count - 1)
        {
            currentTop = 0;
        }
        UpdateTopVisibility();
    }

    private void UpdateTopVisibility()
    {
        foreach (var item in topList)
        {
            item.SetActive(false);
        }
        topList[currentTop].SetActive(true);
    }

    #endregion Top Methods

    #region Bottom Methods

    private void ChangeBottomLeft()
    {
        currentBottom--;
        if (currentBottom < 0)
        {
            currentBottom = bottomList.Count - 1;
        }
        UpdateBottomVisibility();
    }

    private void ChangeBottomRight()
    {
        currentBottom++;
        if (currentBottom > bottomList.Count - 1)
        {
            currentBottom = 0;
        }
        UpdateBottomVisibility();
    }

    private void UpdateBottomVisibility()
    {
        foreach (var item in bottomList)
        {
            item.SetActive(false);
        }
        bottomList[currentBottom].SetActive(true);
    }

    #endregion Bottom Methods

    private void ChangeGender()
    {
        Debug.Log("Should Work");
        foreach (var item in leftButtonList)
        {
            item.onClick.RemoveAllListeners();
        }
        foreach (var item in rightButtonList)
        {
            item.onClick.RemoveAllListeners();
        }
        changeGenderButton.interactable = false;

        cCamera.Follow = otherCharacterCustomization.gameObject.transform;
        otherCharacterCustomization.AssignButtons();
    }

    private void AssignButtons()
    {
        changeGenderButton.onClick.AddListener(ChangeGender);
        changeGenderButton.interactable = true;

        // Hair buttons
        leftButtonList[0].onClick.AddListener(ChangeHairLeft);
        rightButtonList[0].onClick.AddListener(ChangeHairRight);

        // Top buttons
        leftButtonList[1].onClick.AddListener(ChangeTopLeft);
        rightButtonList[1].onClick.AddListener(ChangeTopRight);

        // Bottom buttons
        leftButtonList[2].onClick.AddListener(ChangeBottomLeft);
        rightButtonList[2].onClick.AddListener(ChangeBottomRight);
    }
}