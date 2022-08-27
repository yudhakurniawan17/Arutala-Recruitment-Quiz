using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Save : MonoBehaviour
{
    Texture2D tex;
    Screenshot snapShot;
    RawImage mediaImage;

    public void SaveScreenshot()
    {
        ScreenCapture.CaptureScreenshot("Screenshot.png");
    }

}
