using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EssenceBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxEssence(float essence)
    {
        slider.maxValue = essence;
        slider.value = essence;
    }

    public void SetEssence(float essence)
    {
        slider.value = essence;

    }

}
