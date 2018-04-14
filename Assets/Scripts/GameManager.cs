using System.Collections;
using System.Net;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

public class GameManager : MonoBehaviour {
    string url = "http://dev.motivatedplay.com/api";
    // Use this for initialization
    IEnumerator Start()
    {
        /*
        WWWForm form = new WWWForm();
        form.AddField("title", "Ewwe");
        form.AddField("description", "Sdsd");
        form.AddField("catergory", "9");
        form.AddField("currency", "1");
        form.AddField("max_players", "2");
        form.AddField("min_players", "2");
        form.AddField("minimal_rate", "100");
        form.AddField("prize_number", "1");
        form.AddField("public", "true");
        UnityWebRequest wr2 = UnityWebRequest.Post(url+ "/games/create/", form);
        */
        UnityWebRequest wr2 = UnityWebRequest.Get(url + "/games/list");
        StreamWriter r = new StreamWriter(Application.dataPath + "/juj.json");
        wr2.SetRequestHeader("Authorization","Basic Y2hlbXNoZW5pazpOeWFzaGFfMjE=");
        yield return wr2.SendWebRequest();
        GameCollection game = JsonUtility.FromJson<GameCollection>(wr2.downloadHandler.text);
        //r.WriteLine(JsonUtility.FromJson<Game>(wr2.downloadHandler.text));
        r.Close();
        Debug.Log(wr2.downloadHandler.text);
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
