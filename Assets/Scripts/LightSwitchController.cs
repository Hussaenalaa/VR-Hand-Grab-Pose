using UnityEngine;

public class LightSwitchController : MonoBehaviour
{
    public GameObject lightObject; // assign the Spot Light GameObject

    public void ToggleLight()
    {
        if (lightObject) lightObject.SetActive(!lightObject.activeSelf);
    }
}