using UnityEngine;

public class NaviagateToPage : MonoBehaviour
{
    public string Url;

    public void Open()
    {
        Application.OpenURL(Url);
    }

}
