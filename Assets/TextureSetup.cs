using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureSetup : MonoBehaviour
{

    public Camera cameraInt;
    public Material cameraMatInt;

    // Start is called before the first frame update
    void Start()
    {
        if (cameraInt.targetTexture != null) 
        {
            cameraInt.targetTexture.Release();
        }
        cameraInt.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        cameraMatInt.mainTexture = cameraInt.targetTexture;
    }

    
}
