using UnityEngine;

public class Step : MonoBehaviour
{
    public string DebugHeaderText;
    public string LocalText;

    [TextArea(4, 6)]
    public string DescriptionText;

    [TextArea(4, 6)]
    public string ChoicesText;

    public Step[] Choices;
}