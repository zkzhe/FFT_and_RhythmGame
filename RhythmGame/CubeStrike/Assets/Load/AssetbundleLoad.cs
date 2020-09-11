using System.Collections;
using UnityEngine;
using System.IO;
using UnityEngine.Networking;
public class AssetbundleLoad : MonoBehaviour {
 
    void Start () {
        // StartCoroutine(fromMemery());
        //StartCoroutine(fromFileOne());
        StartCoroutine(fromUnityWebRequest());
    }
	
    void Update () {
		
	}
    //內存
    IEnumerator fromMemery()
    {
        string path = @"C:\Users\ZHE\Desktop\RhythmGame\CubeStrike\AB\cube.3d";
        string matpath= @"C:\Users\ZHE\Desktop\RhythmGame\CubeStrike\AB\color.blue";
        byte[] bytes = File.ReadAllBytes(path);
        byte[] matbytes = File.ReadAllBytes(matpath);
        AssetBundle assetBundle = AssetBundle.LoadFromMemory(bytes);
        AssetBundle matassetBundle = AssetBundle.LoadFromMemory(matbytes);
        GameObject prefabGO = assetBundle.LoadAsset("Cube") as GameObject;
        GameObject go = GameObject.Instantiate(prefabGO);
        yield return null;

    }
    //文件讀取
    IEnumerator fromFileOne()
    {
        string path = @"C:\Users\ZHE\Desktop\RhythmGame\CubeStrike\AB\cube.3d";
        string matpath = @"C:\Users\ZHE\Desktop\RhythmGame\CubeStrike\AB\color.blue";
        AssetBundle asset = AssetBundle.LoadFromFile(path);
        AssetBundle matasset = AssetBundle.LoadFromFile(matpath);
        GameObject prefabGO = asset.LoadAsset("Cube") as GameObject;
        GameObject go = GameObject.Instantiate(prefabGO);
        yield return null;
    }
    //unityWebRequest
    IEnumerator fromUnityWebRequest()
    {
        string path = @"http://localhost/Unity//AssetBumdle/game";
        UnityWebRequest unityWebRequest;
        unityWebRequest = UnityWebRequestAssetBundle.GetAssetBundle(path);
        yield return unityWebRequest.SendWebRequest();
        AssetBundle assetBundle = DownloadHandlerAssetBundle.GetContent(unityWebRequest);
        GameObject prefabGO = assetBundle.LoadAsset("GameObject") as GameObject;
        GameObject go = GameObject.Instantiate(prefabGO);
        yield return null;
        /*string matpath = @"C:\Users\ZHE\Desktop\RhythmGame\CubeStrike\AB\color.blue";
        UnityWebRequest matunityWebRequest = UnityWebRequestAssetBundle.GetAssetBundle(matpath);
        yield return matunityWebRequest.SendWebRequest();
        AssetBundle matassetBundle = DownloadHandlerAssetBundle.GetContent(matunityWebRequest);*/
    }
}
