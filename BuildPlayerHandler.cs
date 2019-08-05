using System.IO;
using UnityEditor;
using UnityEngine;

public static class BuildPlayerHandler
{

    [InitializeOnLoadMethod]
    private static void Initialize()
    {
        BuildPlayerWindow.RegisterBuildPlayerHandler(BuildPlayer);
    }

    private static void BuildPlayer(BuildPlayerOptions options)
    {
        // options let you access build options and parameters

        BuildTarget buildTarget = EditorUserBuildSettings.activeBuildTarget;

        // PUT CONDITION OR ELSE HERE

        // DO THE BUILD
        BuildPlayerWindow.DefaultBuildMethods.BuildPlayer(options);
    }
}
