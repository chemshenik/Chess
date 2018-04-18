using System.Collections;
using System.Net;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;
public class JsonHelper{
    public static T[] getJsonArray<T>(string json) {
        string newJson = "{\array\": " + json + "}";
        Wrapper<T> wrapper = JsonUtility.FromJson<Wrapper<T>>(newJson);
        return wrapper.array;
    }

    [System.Serializable]
    class Wrapper<T> {
        public T[] array;
    }
    }
public class GameManager : MonoBehaviour {
    string url = "http://dev.motivatedplay.com/api";
    GameCollection gameCollection;
    // Use this for initialization
    IEnumerator Start()
    {
        Hashtable data = new Hashtable();
        data.Add("title", "Game_02");
        data.Add("description", "Best game ever!");
        data.Add("currency", "1");
        data.Add("min_players", "2");
        data.Add("max_players", "2");
        data.Add("minimal_rate", "100");
        data.Add("prize_number", "1");


        /* UnityHTTP.Request someRequest = new UnityHTTP.Request("post", "http://someurl.com/some/post/handler", form);
         someRequest.Send((request) => {
             // parse some JSON, for example:
             bool result = false;
             Hashtable thing = (Hashtable)JSON.JsonDecode(request.response.Text, ref result);
             if (!result)
             {
                 Debug.LogWarning("Could not parse JSON response!");
                 return;
             }
         });*/
        UnityHTTP.Request someRequest = new UnityHTTP.Request("post", "http://dev.motivatedplay.com/api/games/create/", data);

        someRequest.SetHeader("Authorization", "Basic Y2hlbXNoZW5pazpOeWFzaGFfMjE=");
        someRequest.SetHeader("Content-Type", "application/json");
        someRequest.Send();

        while (!someRequest.isDone)
        {
            yield return null;
        }

        // parse some JSON, for example:
        var thing =  JSON.JsonDecode  (someRequest.response.Text) ;

        yield return null;

    }
    // Update is called once per frame
    void Update () {
    }
    public void Host() {
        //IPHostEntry ip = Dns.GetHostByName(Dns.GetHostName());
        string Host = System.Net.Dns.GetHostName();
        string IP = System.Net.Dns.GetHostEntry(Host).AddressList[0].ToString();
        IPAddress iP = System.Net.Dns.GetHostEntry(Host).AddressList[0];
        Debug.Log(iP);
    }
    public void Join()
    {

    }
}
