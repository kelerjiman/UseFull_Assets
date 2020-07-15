using RTLTMPro;
using UnityEngine;
using UnityEngine.UI;

public class sliderScript : MonoBehaviour
{
    [SerializeField] private Image filledArea;

    [SerializeField] private RTLTextMeshPro sliderText;
//    [SerializeField] private int remains, value;
//
//    private void Update()
//    {
//        SetSliderValues(remains,value);
//    }
    public void SetSliderValues(float remains, float value)
    {
        var precent = remains / 100;
        var valueToPercent = value / precent;
        if (valueToPercent >= 100)
        {
            filledArea.fillAmount = 1;
            sliderText.text = $"{remains}/{remains}";
            return;
        }

        if (value <= 0)
        {
            sliderText.text =
                sliderText.text = $"0/{remains}";
            return;
        }
        // ReSharper disable once PossibleLossOfFraction
        filledArea.fillAmount = value / 100;
        sliderText.text = $"{value}/{remains}";
    }
}