using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RangeSlider : MonoBehaviour
{
    // Start is called before the first frame update
    private Slider slider;
    private int counter;

    public int deviceRange = 6;
    public Image Fill;  // assign in the editor the "Fill"
    public Color FullRangeColor = Color.green;
    public Color NoRangeColor = Color.red;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
        Fill = GameObject.FindObjectOfType<Image>();
        //counter = MaxHealth;            // just for testing purposes
    }

    private void Start()
    {
       slider.wholeNumbers = true;        // I dont want 3.543 Health but 3 or 4
        slider.minValue = 0f;
        slider.maxValue = deviceRange;
       // slider.value = 0;        // start with full health
    }

    //private void Update()
    //{
    //    UpdateHealthBar(counter);        // just for testing purposes
    //    counter--;                        // just for testing purposes
    //}

    public void rangDist(int dist)
    {
        slider.value = dist;
        print("range bar" + ((float)dist / deviceRange));
        Fill.color = Color.Lerp(FullRangeColor, NoRangeColor, (float)dist / deviceRange);
    }
}
