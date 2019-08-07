using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LitJson;

public class readJson : MonoBehaviour
{
    public Text namaText;
    public Text keteranganText;
    public string id="";

    // Start is called before the first frame update
    IEnumerator Start () {
        string url = "http://192.168.43.40/armuseum/getData.php?id="+id;
        string jsonString;
        WWW www = new WWW(url);
        yield return www;
        if (www.error == null)
        {
            jsonString = www.text; //dapetin string nya
            Processjson(jsonString);
            // Debug.Log("Berhasil"+jsonString);
            
        }
        else
        {
            Debug.Log("ERROR: " + www.error);
        }
    }

    private void Processjson(string jsonString)
    {
        JsonData jsonvale = JsonMapper.ToObject(jsonString);
        //value change
        this.namaText.text = jsonvale[0]["nama"].ToString();
        this.keteranganText.text = jsonvale[0]["keterangan"].ToString();
    }
}
