using System;
using System.IO;
using System.IO.Hashing;
using System.Diagnostics;

public class Utils
{
    private static readonly string logFilePath = "log.txt";
    public static string CalculateFileCrc32(string filePath)
    {
        byte[] fileBytes = File.ReadAllBytes(filePath);
        var crc32 = new Crc32();
        crc32.Append(fileBytes);
        var checksum = crc32.GetCurrentHash();
        Array.Reverse(checksum);
        return BitConverter.ToString(checksum).Replace("-", "").ToLower();
    }

    private static void LogMessage(string message)
    {
        using (StreamWriter writer = new StreamWriter(logFilePath, true))
        {
            writer.WriteLine($"{DateTime.Now}: {message}");
        }
    }

    private static bool RunCommand(string command)
    {
        try
        {
            Process process = new Process();
            ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            process.StartInfo = processInfo;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;

            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();

            process.WaitForExit();

            LogMessage($"Command: {command}");
            LogMessage($"Output: {output}");
            LogMessage($"Error: {error}");

            return process.ExitCode == 0;
        }
        catch (Exception ex)
        {
            LogMessage($"Exception: {ex.Message}");
            return false;
        }
    }

    public static void DeleteRomFileIfExists()
    {
        if (File.Exists("Nova_Rom\\cdos_ptbr.nds"))
        {
            File.Delete("Nova_Rom\\cdos_ptbr.nds");
        }
    }

    public static bool ApplyTranslationPatch(string filePath)
    {
        DeleteRomFileIfExists();
        return RunCommand("Tools\\xdelta.exe -d -s \"" + filePath + "\" Patches\\cdos_ptbr.xdelta Nova_Rom\\cdos_ptbr.nds");
    }

    public static bool ApplyDawnDignityPortraits()
    {
        return RunCommand("Tools\\armips.exe Patches\\DawnDignity\\dos_insert_dawn_dignity_avatars.asm");
    }

    public static bool ApplyPatchDisableMagicSeals()
    {
        return RunCommand("Tools\\flips.exe --apply Patches\\DisableMagicSeals\\dos_no_required_touch_screen_v1.1.ips Nova_Rom\\cdos_ptbr.nds");
    }

    public static bool ApplyPatchEnableLuckSoulFixes()
    {
        return RunCommand("Tools\\flips.exe --apply Patches\\EnableLuckSoulFixes\\dos_fixed_luck.ips Nova_Rom\\cdos_ptbr.nds");
    }
}
