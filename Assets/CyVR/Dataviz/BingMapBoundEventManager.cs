using Microsoft.Maps.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;

using UnityEngine.Events;



// Create custom event when some arguments needs to be passed with it
// Skip this if argument passing is not required and use UnityEvent instead

namespace cyvr.dataviz
{

    [System.Serializable]
    public class BingMapBoundEventManager : MonoBehaviour
    {

        void Update()
        {
            // invoke event
            var bottomleftlatittude = gameObject.GetComponent<MapRenderer>().Bounds.BottomLeft.LatitudeInDegrees.ToString();
            var toprightlatittude = gameObject.GetComponent<MapRenderer>().Bounds.TopRight.LatitudeInDegrees.ToString();
            var bottomleftlongitude = gameObject.GetComponent<MapRenderer>().Bounds.BottomLeft.LongitudeInDegrees.ToString();
            var toprightlongitude = gameObject.GetComponent<MapRenderer>().Bounds.BottomLeft.LatitudeInDegrees.ToString();

            EventManager.SetDataGroup("MAP_LATLONG_BOUNDS", gameObject, bottomleftlatittude, toprightlatittude, bottomleftlongitude, toprightlongitude);
            EventManager.EmitEvent("MAP_LATLONG_BOUNDS");
            Debug.Log("Event MAP_LATLONG_BOUNDS with payload: " + gameObject + "," + bottomleftlatittude + "," + toprightlatittude + "," + bottomleftlongitude + "," + toprightlongitude);
        }

        void Start()
        {
        }
    }
}

