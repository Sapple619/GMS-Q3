using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DialogController : MonoBehaviour
{
    private VisualElement background;
    private Label dateLabel;
    private Label contentLabel;

    private List<string> dialogLines = new List<string>();
    private int currentLine = 0;

    private int currentImageIndex = 0;
    private string username = "이명박";

    void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        background = root.Q<VisualElement>("background");
        dateLabel = root.Q<Label>("date");
        contentLabel = root.Q<Label>("content");
        contentLabel.style.whiteSpace = WhiteSpace.Normal;
        string dialogText = System.IO.File.ReadAllText("Assets/Assets/Dialog/dialog.txt");
        dialogLines.AddRange(dialogText.Split('\n'));

        StartCoroutine(DialogCoroutine());
    }

    IEnumerator DialogCoroutine()
    {
        while (true)
        {
            if (Input.anyKeyDown)
            {
                UpdateDialog();
                yield return null;
            }

            yield return null;
        }
    }

    void UpdateDialog()
    {
        if (currentLine >= dialogLines.Count)
        {
            Debug.Log("스크립트 끝");
            return;
        }

        string line = dialogLines[currentLine];

        if (line.Contains("년"))
        {
            line = line.Trim();
            dateLabel.text = $"{line} {username}";
            currentLine++;
            line = dialogLines[currentLine];
        }

        contentLabel.text = line;

        currentLine++;
    }

}