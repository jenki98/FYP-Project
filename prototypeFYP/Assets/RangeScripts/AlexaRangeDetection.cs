using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlexaRangeDetection : MonoBehaviour
{

    private int range = 12; //example of device range tbc 
    private Transform device;
    private Transform player; //change to user
    private RangeSlider rs;

    private void Awake()
    {
        device = this.transform;
        player = GameObject.FindGameObjectWithTag("Player").transform;
        rs = GameObject.FindObjectOfType<RangeSlider>();
        //This will then change to vr position 'HeadAnchor', 'HeadsetAlias', 'VRTK Player'

    }

    //int distance;
    int dist;
    private void Distance()
    {

            dist = (int)Vector3.Distance(player.position, device.position);

    }
    private void Update()
    {
        if (player)
        {
            Distance();
            rs.rangDist(dist);
            print(player.name + " is " + dist.ToString() + " units from " + device.name); //Just to test that is calculates range until I get range bar working
        }
          

    }
    private void DeviceAction()
    {
        if(range > dist)
        {
            //do action e.g turn sound on
        }
        else
        {
            //turn off device (do it gradually)
        }
    }
    
}
