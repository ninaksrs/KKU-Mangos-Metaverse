using UnityEngine;

public class SkyboxToggleUI : MonoBehaviour
{
    public Material daySkybox;
    public Material nightSkybox;

    public void SetDay()
    {
        Apply(daySkybox);
    }

    public void SetNight()
    {
        Apply(nightSkybox);
    }

    private void Apply(Material skybox)
    {
        if (skybox == null)
        {
            return;
        }

        RenderSettings.skybox = skybox;
        DynamicGI.UpdateEnvironment();
    }
}
