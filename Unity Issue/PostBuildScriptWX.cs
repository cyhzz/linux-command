//修改WXConvertCore中的这个func

private static void finishExport()
{
    int code = GenerateBinFile();
    if (code == 0)
    {
        convertDataPackage(false);
        UnityEngine.Debug.LogFormat("[Converter] All done!");
        // //ShowNotification(new GUIContent("转换完成"));

        System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo();
        psi.UseShellExecute = false;
        psi.RedirectStandardOutput = true;
        psi.FileName = "osascript";
        psi.Arguments = string.Format("-e 'tell application \"Terminal\" to do script \"sh {0}\"'", "~/Desktop/upload.sh");
        System.Diagnostics.Process p = System.Diagnostics.Process.Start(psi);
        p.WaitForExit();
        while (!p.StandardOutput.EndOfStream)
        {
            string line = p.StandardOutput.ReadLine();
            UnityEngine.Debug.Log(line);
        }
        UnityEngine.Debug.Log("finished");
        p.Close();
    }
    else
    {
        convertDataPackage(true);
    }
}