using UnityEngine;
using System.Collections;

public class SwapShaderTexture : MonoBehaviour {

    public Texture tex1;
    public Texture tex2;

    private bool one = true;

    private void OnMouseDown()
    {
        Debug.Log("SwapShaderTexture", this);
        if (one)
        {
            one = false;
            Shader.SetGlobalTexture(0, tex1);
        }
        else
        {
            one = true;
            Shader.SetGlobalTexture(0, tex2);
        }
    }
}
