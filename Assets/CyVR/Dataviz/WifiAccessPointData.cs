using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TigerForge;


public class WifiAccessPointData : MonoBehaviour
{


        public string bottomleftlatittude;
        public string toprightlatittude;
        public string bottomleftlongitude;
        public string toprightlongitude;


        public string trilat;
    public string trilong;
    public string ssid;
    public int qos;
    public string transid;
    public string firsttime;
    public string lasttime;
    public string lastupdt;
    public string netid;
    public string name;
    public string type;
    public string comment;
    public string wep;
    public int bcninterval;
    public string freenet;
    public string dhcp;
    public string paynet;
    public string userfound;
    public string channel;
    public string encryption;
    public string country;
    public string region;
    public string housenumber;
    public string road;
    public string city;
    public string postalcode;


    // Start is called before the first frame update
    void Start()
        {
            EventManager.StartListening("MAP_LATLONG_BOUNDS", WIGLEDataManager_MAP_LATLONG_BOUNDS_CallBackFunction);
            print("wifiaccesspoint data event listener start");

        }

    // Update is called once per frame
    void Update()
    {

    }



        void WIGLEDataManager_MAP_LATLONG_BOUNDS_CallBackFunction()
        {
            // Accessing to the data array.
            var eventData = EventManager.GetDataGroup("MAP_LATLONG_BOUNDS");

            // Array reading with proper values convertion.

            GameObject me = eventData[0].ToGameObject();
            bottomleftlatittude = eventData[1].ToString();

            print("WIGLEDataManager_CallBackFunction execute with " + bottomleftlatittude);

            toprightlatittude = eventData[2].ToString();
            bottomleftlongitude = eventData[3].ToString();
            toprightlongitude = eventData[4].ToString();
        }

    }
