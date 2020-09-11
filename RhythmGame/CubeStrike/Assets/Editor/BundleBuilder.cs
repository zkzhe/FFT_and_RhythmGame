using UnityEditor;
using System.IO;
public class BundleBuilder : Editor {
    [MenuItem("Assets/ Buile AssetBundles")]
    static void BuildAllAssetBundles()
    {
        string path = "AB";
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
        BuildPipeline.BuildAssetBundles(path, BuildAssetBundleOptions.None, BuildTarget.StandaloneWindows64);
        UnityEngine.Debug.Log("Finish");

    }
	
}
