using BestHTTP;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using UnityEngine;

using TigerForge;


public class WIGLEDataManager : MonoBehaviour
{
    public bool networksearchactive;

    public string bottomleftlatittude;
    public string toprightlatittude;
    public string bottomleftlongitude;
    public string toprightlongitude;

    public string networkoperator;
    public string lac;
    public string netid;
    public string cid;
    public string nettype;
    public string system;
    public string network;
    public string basestation;

    public string encryption;
    public string addresscode;
    public bool freenet;
    public bool paynet;
    public bool onlymine;
    public bool ssidexact;
    public string ssid;

    public string mcc;
    public string mnc;
    public int minQoS;


    private IEnumerator coroutine;

    // Start is called before the first frame update
    void Start()
    {
        EventManager.StartListening("MAP_LATLONG_BOUNDS", WIGLEDataManager_MAP_LATLONG_BOUNDS_CallBackFunction);
        print("wigledatamanager start");
        print("code is speech");

        // - After 0 seconds, prints "Before WaitAndPrint Finishes 0.0"
        // - After 2 seconds, prints "WaitAndPrint 2.0"
        //      print("Starting " + Time.time);

        // Start function WaitAndPrint as a coroutine.

        //        StartCoroutine(SendRequest_apiwiglenet_api_v2_network_search());

        //print("Before WaitAndPrint Finishes " + Time.time);

    }

    // Update is called once per frame
    void Update()
    {
        //  EventManager.StartListening("MAP_LATLONG_BOUNDS", WIGLEDataManager_CallBackFunction);
        //  print("wigledatamanager update " + Time.time);
        SendRequest_apiwiglenet_api_v2_network_search();
    }


    string Base64EncodededCredentials(string user, string password)
    {
        var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(user + ":" + password);
        return System.Convert.ToBase64String(plainTextBytes);
    }

    public string NonBlankValueOfURLVariable(string strVariableString, string strVariableValue)
    {
        return String.IsNullOrEmpty(strVariableValue) ? "" : strVariableValue;
    }

    string UrlVarStringCreator(string encryption, string addresscode, string bottomleftlatittude, string toprightlatittude, string bottomleftlongitude, string toprightlongitude,
            string networkoperator, string lac, string netid, string cid, string nettype, string system, string network, string basestation, string ssid, 
            string mcc, string mnc, bool freenet, bool paynet, bool onlymine, bool ssidexact, int minQoS)
    {
        string varstring;

        varstring = "";

        varstring = varstring + "freenet=" + freenet;

        varstring = varstring + "paynet=" + paynet;


        varstring = varstring + "onlymine=" + onlymine;

        varstring = varstring + "ssidexact=" + ssidexact;

        varstring = varstring + "minQoS=" + minQoS;


        if (encryption != "")
            {
            String Test(string encryption)
            {
                if (String.IsNullOrEmpty(encryption))
                    return "is null or empty";
                else
                   return varstring = varstring + "encryption=" + encryption;
            }
            }

        if (addresscode != "")
        {
            String Test(string addresscode)
            {
                if (String.IsNullOrEmpty(addresscode))
                    return "is null or empty";
                else
                    return varstring = varstring + "addresscode=" + addresscode;
            }
        }
        if (bottomleftlatittude != "")
        {
            String Test(string bottomleftlatittude)
            {
                if (String.IsNullOrEmpty(bottomleftlatittude))
                    return "is null or empty";
                else
                    return varstring = varstring + "bottomleftlatittude=" + bottomleftlatittude;
            }
        }
        if (toprightlatittude != "")
        {
            String Test(string toprightlatittude)
            {
                if (String.IsNullOrEmpty(toprightlatittude))
                    return "is null or empty";
                else
                    return varstring = varstring + "toprightlatittude=" + toprightlatittude;
            }
        }
        if (bottomleftlongitude != "")
        {
            String Test(string bottomleftlongitude)
            {
                if (String.IsNullOrEmpty(bottomleftlongitude))
                    return "is null or empty";
                else
                    return varstring = varstring + "bottomleftlongitude=" + bottomleftlongitude;
            }
        }
        if (toprightlongitude != "")
        {
            String Test(string toprightlongitude)
            {
                if (String.IsNullOrEmpty(toprightlongitude))
                    return "is null or empty";
                else
                    return varstring = varstring + "toprightlongitude=" + toprightlongitude;
            }
        }
        if (networkoperator != "")
        {
            String Test(string networkoperator)
            {
                if (String.IsNullOrEmpty(networkoperator))
                    return "is null or empty";
                else
                    return varstring = varstring + "networkoperator=" + networkoperator;
            }
        }
        if (lac != "")
        {
            String Test(string lac)
            {
                if (String.IsNullOrEmpty(lac))
                    return "is null or empty";
                else
                    return varstring = varstring + "lac=" + lac;
            }
        }
        if (netid != "")
        {
            String Test(string netid)
            {
                if (String.IsNullOrEmpty(netid))
                    return "is null or empty";
                else
                    return varstring = varstring + "netid=" + netid;
            }
        }
        if (cid != "")
        {
            String Test(string cid)
            {
                if (String.IsNullOrEmpty(cid))
                    return "is null or empty";
                else
                    return varstring = varstring + "cid=" + cid;
            }
        }
        if (nettype != "")
        {
            String Test(string nettype)
            {
                if (String.IsNullOrEmpty(nettype))
                    return "is null or empty";
                else
                    return varstring = varstring + "nettype=" + nettype;
            }
        }
        if (system != "")
        {
            String Test(string system)
            {
                if (String.IsNullOrEmpty(system))
                    return "is null or empty";
                else
                    return varstring = varstring + "system=" + system;
            }
        }
        if (network != "")
        {
            String Test(string network)
            {
                if (String.IsNullOrEmpty(network))
                    return "is null or empty";
                else
                    return varstring = varstring + "network=" + network;
            }
        }
        if (basestation != "")
        {
            String Test(string basestation)
            {
                if (String.IsNullOrEmpty(basestation))
                    return "is null or empty";
                else
                    return varstring = varstring + "basestation=" + basestation;
            }
        }
        if (ssid != "")
        {
            String Test(string ssid)
            {
                if (String.IsNullOrEmpty(ssid))
                    return "is null or empty";
                else
                    return varstring = varstring + "ssid=" + ssid;
            }
        }
        if (mcc != "")
        {
            String Test(string mcc)
            {
                if (String.IsNullOrEmpty(mcc))
                    return "is null or empty";
                else
                    return varstring = varstring + "mcc=" + mcc;
            }
        }
        if (mnc != "")
        {
            String Test(string mnc)
            {
                if (String.IsNullOrEmpty(mnc))
                    return "is null or empty";
                else
                    return varstring = varstring + "mnc=" + mnc;
            }
        }





        Debug.Log("UrlVariables execute with " + varstring);

        return varstring;



    }

    void WIGLEDataManager_MAP_LATLONG_BOUNDS_CallBackFunction()
    {
        // Accessing to the data array.
        var eventData = EventManager.GetDataGroup("MAP_LATLONG_BOUNDS");

        // Array reading with proper values convertion.
        GameObject me = eventData[0].ToGameObject();
        bottomleftlatittude = eventData[1].ToString();


        Debug.Log("WIGLEDataManager_CallBackFunction execute with " + bottomleftlatittude);

        toprightlatittude = eventData[2].ToString();
        bottomleftlongitude = eventData[3].ToString();
        toprightlongitude = eventData[4].ToString();
    }

    /**
     *   https://api.wigle.net/api/v2/network/search?onlymine=false&latrange1=2&latrange2=1&freenet=false&paynet=false
     * latrange1
     * number
     * (query)
     * Lesser of two latitudes by which to bound the search(specify both)
     * 2
     * latrange2
     * number
     * (query)
     * Greater of two latitudes by which to bound the search(specify both)
     * 1
     * longrange1
     * number
     * (query)
     * Lesser of two longitudes by which to bound the search(specify both)
     * longrange1 - Lesser of two longitudes by which to bound the search(specify both)
     * longrange2
     * number
     * (query)
     * Greater of two longitudes by which to bound the search(specify both)
     * longrange2 - Greater of two longitudes by which to bound the search(specify both)
     *     encryption
     * string
     * (query)
     * Encryption detected: 'None', 'WEP', 'WPA', 'WPA2', 'WPA3', 'Unknown'.Case insensitive.
     * encryption - Encryption detected: 'None', 'WEP', 'WPA', 'WPA2', 'WPA3', 'Unknown'.Case insensitive.
     *     freenet
     * boolean
     * (query)
     * Include only networks that have been marked as free access.




     * false

     * paynet

     * boolean

     * (query)

     * Include only networks that have been marked as for-pay access.


     *     ssid

     * string

     * (query)

     * Include only networks exactly matching the string network name.


     * ssid - Include only networks exactly matching the string network name.

     * ssidlike

     * string

     * (query)

     * Include only networks matching the string network name, allowing wildcards '%'(any string) and '_'(any character).


     * ssidlike - Include only networks matching the string network name, allowing wildcards '%'(any string) and '_'(any character).






     * minQoS

     * integer($int32)

     * (query)

     * Minimum Quality of Signal(0 - 7).


     * minQoS - Minimum Quality of Signal(0 - 7).
    x

     * variance

     * number

     * (query)

     * How tightly to bound queries against the provided latitude / longitude box.Value must be between 0.001 and 0.2.Intended for use with non - exact decimals and geocoded bounds.


     * variance - How tightly to bound queries against the provided latitude / longitude box.Value must be between 0.001 and 0.2.Intended for use with non - exact decimals and geocoded bounds.


     * resultsPerPage - How many results to return per request.Defaults to 25 for COMMAPI, 100 for site.Bounded at 1000 for COMMAPI, 100 for site.

     * searchAfter

     * string

     * (query)

     * Put in the previous page's searchAfter result to get the next page. Use this instead of 'first'



     * searchAfter - Put in the previous page's searchAfter result to get the next page. Use this instead of 'first'


    current form

    https://api.wigle.net/api/v2/network/search?onlymine=false&latrange1=30.7359111148288&latrange2=43.2973895483872&longrange1=-129.119810180515&longrange2=30.7359111148288&encryption=&freenet=False&paynet=False&ssidexact=False&ssid=&minQoS=0

    proper form

    https://api.wigle.net/api/v2/cell/search?onlymine=false&notmine=false&latrange1=11.22&latrange2=11.22&longrange1=11.22&longrange2=11.22&lastupdt=false&showGsm=true&showCdma=true&showLte=true&showWcdma=true

    the problem is null values arent handled

*/
    void SendRequest_apiwiglenet_api_v2_network_search()
    {
        // Accessing to the data array.
        var eventData = EventManager.GetDataGroup("MAP_LATLONG_BOUNDS");

        // Array reading with proper values convertion.

        GameObject me = eventData[0].ToGameObject();
        bottomleftlatittude = eventData[1].ToString();

        Debug.Log("WIGLEDataManager_CallBackFunction execute with " + bottomleftlatittude);

        toprightlatittude = eventData[2].ToString();
        bottomleftlongitude = eventData[3].ToString();
        toprightlongitude = eventData[4].ToString();

        string requesturl = "https://api.wigle.net/api/v2/network/search?onlymine=false&" + "latrange1=" + bottomleftlatittude + "&" + "latrange2=" + toprightlatittude + "&"
                + "longrange1=" + bottomleftlongitude + "&" + "longrange2=" + toprightlongitude + "&" + "encryption=" + encryption + "&" + "freenet=" + freenet + "&" + "paynet=" + paynet + "&" + "ssidexact=" + ssidexact + "&"
                + "ssid=" + ssid + "&" + "minQoS=" + minQoS;

        Debug.Log(requesturl);


        var request = new HTTPRequest(new Uri(requesturl), callback: OnRequestFinished);


        string creds = Base64EncodededCredentials("username", "password");

        request.AddHeader("authorization", "Basic " + creds);

        request.AddHeader("accept", "application/json");

        request.Send();


        Debug.Log("logged request response is " + request.Response);

        //void OnRequestFinished(HTTPRequest req, HTTPResponse resp)
        // {
        // Debug.Log("logged request response is " + request.Response);
        //};
    }

    public IEnumerator SendRequest_apiwiglenet_api_v2_network_geocode()
    {
        string creds = Base64EncodededCredentials("username", "password");

        var request = new HTTPRequest(new Uri("https://api.wigle.net/api/v2/network/geocode?addresscode=" + addresscode));

        request.AddHeader("accept", "application/json");
        request.AddHeader("authorization", "Basic " + creds);

        yield return request.Send();
    }



    // every 2 seconds perform the print()
    private IEnumerator WaitAndPrint(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            print("WaitAndPrint " + Time.time);
        }
    }

    public IEnumerator SendRequest_apiwiglenet_api_v2_network_detail()
    {
        string creds = Base64EncodededCredentials("username", "password");

        var request = new HTTPRequest(new Uri("https://api.wigle.net/api/v2/network/detail?netid=" + netid + "&operator=" + networkoperator + "&lac=" + lac + "&cid=" + cid + "&type=" + nettype + "&system=" + system + "&network=" + network + "&basestation=" + basestation));

        request.AddHeader("accept", "application/json");
        request.AddHeader("authorization", "Basic " + creds);

        yield return request.Send();
        Debug.Log(request.Response);
    }



    void SendRequest_apiwiglenet_api_v2_profile_user()
    {
        var request = new HTTPRequest(new Uri("https://api.wigle.net/api/v2/profile/user"), OnRequestFinished);

        string creds = Base64EncodededCredentials("username", "password");

        request.AddHeader("authorization", "Basic " + creds);

        request.AddHeader("accept", "application/json");

        request.Send();
    }



    void SendRequest_apiwiglenet_api_v2_cell_mccMnc()
    {
        var request = new HTTPRequest(new Uri("https://api.wigle.net/api/v2/cell/mccMnc?mcc=" + mcc + "&mnc=" + mnc), OnRequestFinished);

        string creds = Base64EncodededCredentials("username", "password");

        request.AddHeader("authorization", "Basic " + creds);

        request.AddHeader("accept", "application/json");

        request.Send();
    }

    private void OnRequestFinished(HTTPRequest req, HTTPResponse resp)
    {
        switch (req.State)
        {
            // The request finished without any problem.
            case HTTPRequestStates.Finished:
                if (resp.IsSuccess)
                {
                    // Everything went as expected!
                }
                else
                {
                    Debug.LogWarning(string.Format("Request finished Successfully, but the server sent an error.Status Code: { 0}-{1} Message: {2}",
                                                    resp.StatusCode,
                                                    resp.Message,
                                                    resp.DataAsText));
                }
                break;

            // The request finished with an unexpected error. The request's Exception property may contain more info about the error.
            case HTTPRequestStates.Error:
                Debug.LogError("Request Finished with Error! " + (req.Exception != null ? (req.Exception.Message + "\n" + req.Exception.StackTrace) : "No Exception"));
                break;

            // The request aborted, initiated by the user.
            case HTTPRequestStates.Aborted:
                Debug.LogWarning("Request Aborted!");
                break;

            // Connecting to the server is timed out.
            case HTTPRequestStates.ConnectionTimedOut:
                Debug.LogError("Connection Timed Out!");
                break;

            // The request didn't finished in the given time.
            case HTTPRequestStates.TimedOut:
                Debug.LogError("Processing the request Timed Out!");
                break;
        }
    }
}
