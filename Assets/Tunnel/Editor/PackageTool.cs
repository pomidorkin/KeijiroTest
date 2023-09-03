using UnityEngine;
using UnityEditor;

public class PackageToolTwoCust
{
    [MenuItem("Package/Update Package")]
    static void UpdatePackage()
    {
        AssetDatabase.ExportPackage("Assets/Kvant", "KvantTunnel.unitypackage", ExportPackageOptions.Recurse);
    }
}
