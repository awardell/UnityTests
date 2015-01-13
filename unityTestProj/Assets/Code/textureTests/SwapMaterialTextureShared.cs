using UnityEngine;
using System.Collections;

public class SwapMaterialTextureShared : MonoBehaviour {

    public Texture tex1;
    public Texture tex2;

    private bool one = true;

    private void OnMouseDown()
    {
        Debug.Log("SwapMaterialTextureShared", this);
        if (one)
        {
            one = false;
            renderer.sharedMaterial.SetTexture(0, tex1);
        }
        else
        {
            one = true;
            renderer.sharedMaterial.SetTexture(0, tex2);
        }
    }
}
