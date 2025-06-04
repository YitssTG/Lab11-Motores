using UnityEngine;

public class UiManager : MonoBehaviour
{
    public GameObject popUpGameOver;
    private void Start()
    {
        popUpGameOver.SetActive(false);
    }
    private void OnEnable()
    {
        PlayerController.OnPlayerDeath += ShowPopUpGameOver;
    }
    private void OnDisable()
    {
        PlayerController.OnPlayerDeath -= ShowPopUpGameOver;
    }
    void ShowPopUpGameOver()
    {
        popUpGameOver.SetActive(true);
    }
}
