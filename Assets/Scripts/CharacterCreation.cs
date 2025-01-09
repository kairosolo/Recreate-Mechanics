using UnityEngine;
using Unity.Cinemachine;
using UnityEngine.UI;

public class CharacterCreation : MonoBehaviour
{
    [SerializeField] private GameObject startUI;
    [SerializeField] private GameObject customizationUI;
    [SerializeField] private Button createCharacterButton;
    [SerializeField] private CinemachineCamera cCamera;
    [SerializeField] private CharacterCustomization characterCustomization;

    private void Awake()
    {
        createCharacterButton.onClick.AddListener(CreateCharacter);
    }

    private void CreateCharacter()
    {
        startUI.SetActive(false);
        customizationUI.SetActive(true);
        cCamera.Follow = characterCustomization.transform;
    }
}