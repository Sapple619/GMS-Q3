using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Button : MonoBehaviour
{
    [SerializeField] GameObject stamp;
    [SerializeField] GameObject topSecret;
    [SerializeField] TMP_InputField playerNameInput;
    string playerName;
    public void start(){
        SceneManager.LoadScene("Start");
    }
    public void main(){
        stamp.SetActive(true);
        topSecret.SetActive(true);
        playerName = playerNameInput.text;
        if(string.IsNullOrWhiteSpace(playerName)){
            playerName = "최재령";
            playerNameInput.text = "최재령";
        }
        PlayerPrefs.SetString("PlayerName", playerName);
        playerNameInput.readOnly = true;
        StartCoroutine(WaitForIt());
    }

    IEnumerator WaitForIt()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Dialog");
    }
}
