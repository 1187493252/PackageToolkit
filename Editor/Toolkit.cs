using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public static class Toolkit 
{
     static Dictionary<string,string> packageUrlData=new Dictionary<string,string>();
    public static string GetPackageUrl(string key)
    { 
        if (packageUrlData.Count==0)
        {
            LoadPackageUrlData();
        }
        return packageUrlData[key];
    }
    public static void LoadPackageUrlData()
    {
        var jsondata = AssetDatabase.LoadAssetAtPath<TextAsset>($"Packages/com.sc.packages/PackageUrl.json");
        PackageUrlData  data=    JsonUtility.FromJson<PackageUrlData>(jsondata.text);
        foreach (Config config in data.config)
        {
            packageUrlData[config.key]=config.value;
        }
    }

    class PackageUrlData
    {
        public Config[] config;
    }

    class Config
    {
        public string key;
        public string value;
    }
}
