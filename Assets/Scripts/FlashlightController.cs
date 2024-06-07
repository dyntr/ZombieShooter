using UnityEngine;
using UnityEngine.UI;

public class FlashlightController : MonoBehaviour
{
    public Light flashlight;
    public KeyCode toggleKey = KeyCode.F;
    public float maxBatteryLife = 15f; //15 sekund
    public Slider batteryBar;

    private float currentBatteryLife;
    private bool isFlashlightOn = false;
    private float initialIntensity;
    private float blinkTimer = 0f;
    private bool isBatteryBarVisible = true;

    void Start()
    {
        currentBatteryLife = maxBatteryLife;
        initialIntensity = flashlight.intensity;
        flashlight.enabled = false;
        UpdateBatteryBar();
    }

    void Update()
    {
        
        if (Input.GetKeyDown(toggleKey) && currentBatteryLife > 0)
        {
            isFlashlightOn = !isFlashlightOn;
            flashlight.enabled = isFlashlightOn;
            batteryBar.gameObject.SetActive(true);
        }

        if (isFlashlightOn)
        {
            DrainBattery();
            HandleFlickering();
        }
    }

    void DrainBattery()
    {
        if (currentBatteryLife > 0)
        {
            currentBatteryLife -= Time.deltaTime;
            UpdateBatteryBar();

            if (currentBatteryLife <= 0)
            {
                currentBatteryLife = 0;
                flashlight.enabled = false;
                isFlashlightOn = false;
            }
        }
    }

    void UpdateBatteryBar()
    {
        batteryBar.value = currentBatteryLife / maxBatteryLife;
    }

    void HandleFlickering()
    {
        flashlight.intensity = initialIntensity * (currentBatteryLife / maxBatteryLife);

        float batteryPercentage = currentBatteryLife / maxBatteryLife;
        float flickerFrequency = Mathf.Lerp(0.1f, 2f, 1 - batteryPercentage);

        blinkTimer += Time.deltaTime;

        if (blinkTimer >= flickerFrequency)
        {
            flashlight.enabled = !flashlight.enabled;
            isBatteryBarVisible = !isBatteryBarVisible;
            batteryBar.gameObject.SetActive(isBatteryBarVisible);
            blinkTimer = 0f;
        }

        if (flashlight.enabled == false && currentBatteryLife > 0)
        {
            flashlight.enabled = true;
        }
    }
}
