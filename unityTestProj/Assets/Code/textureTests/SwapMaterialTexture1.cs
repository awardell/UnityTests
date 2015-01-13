using UnityEngine;
using System.Collections;

public class SwapMaterialTexture1 : MonoBehaviour {

    public Texture tex1;
    public Texture tex2;
    public Material mat;

    private bool one = true;

    private void OnMouseDown()
    {
        Debug.Log("SwapMaterialTexture1", this);
        if (one)
        {
            one = false;
            mat.mainTexture = tex1;
        }
        else
        {
            one = true;
            mat.mainTexture = tex2;
        }
    }
}
