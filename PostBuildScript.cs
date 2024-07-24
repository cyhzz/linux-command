using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class PostBuildScript : MonoBehaviour
{
    // #if UNITY_WEBGL
    // [PostProcessBuildAttribute(1000)]
    public static void OnPostprocessBuild(BuildTarget target, string pathToBuiltProject)
    {
        ProcessStartInfo psi = new ProcessStartInfo();
        psi.UseShellExecute = false;
        psi.RedirectStandardOutput = true;

        psi.FileName = "osascript";
        psi.Arguments = string.Format("-e 'tell application \"Terminal\" to do script \"sh {0}\"'", "~/Desktop/wechatupload.sh");

        Process p = Process.Start(psi);
        p.WaitForExit();
        while (!p.StandardOutput.EndOfStream)
        {
            string line = p.StandardOutput.ReadLine();
            Debug.Log(line);
            // do something with line
        }
        Debug.Log("finished");
        p.Close();
    }
    // #endif
}
