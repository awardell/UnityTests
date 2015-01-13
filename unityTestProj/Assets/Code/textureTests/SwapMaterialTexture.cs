using UnityEngine;
using System.Collections;

public class SwapMaterialTexture : MonoBehaviour {

    public Texture tex1;
    public Texture tex2;
    public Material mat;

    private bool one = true;

    private void OnMouseDown()
    {
        Debug.Log("SwapMaterialTexture", this);
        if (one)
        {
            one = false;
            mat.SetTexture(0, tex1);
        }
        else
        {
            one = true;
            mat.SetTexture(0, tex2);
        }
    }
}
