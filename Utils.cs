using System;
using System.IO;
using System.IO.Hashing;
using System.Diagnostics;

public class Utils
{
    public static string CalculateFileCrc32(string filePath)
    {
        byte[] fileBytes = File.ReadAllBytes(filePath);
        var crc32 = new Crc32();
        crc32.Append(fileBytes);
        var checksum = crc32.GetCurrentHash();
        Array.Reverse(checksum);
        return BitConverter.ToString(checksum).Replace("-", "").ToLower();
    }

    private static void RunCommand(string command)
    {
        Process process = new Process();
        ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
        process.StartInfo = processInfo;
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.CreateNoWindow = true;
        process.Start();
        process.WaitForExit();
    }

    public static void ApplyTranslationPatch(string filePath)
    {
        if (File.Exists("Nova_Rom\\cdos_ptbr.nds"))
        {
            File.Delete("Nova_Rom\\cdos_ptbr.nds");
        }

        RunCommand("Tools\\xdelta.exe -d -s " + filePath + " Patches\\cdos_1.0.xdelta Nova_Rom\\cdos_ptbr.nds");
    }

    public static void ApplyDawnDignityPortraits()
    {
        RunCommand("Tools\\armips.exe Patches\\DawnDignity\\dos_insert_dawn_dignity_avatars.asm");
    }

    public static void ApplyPatchDisableMagicSeals()
    {
        RunCommand("Tools\\flips.exe --apply Patches\\DisableMagicSeals\\dos_no_required_touch_screen_v1.1.ips Nova_Rom\\cdos_ptbr.nds");
    }

    public static void ApplyPatchEnableLuckSoulFixes()
    {
        RunCommand("Tools\\flips.exe --apply Patches\\EnableLuckSoulFixes\\dos_fixed_luck.ips Nova_Rom\\cdos_ptbr.nds");
    }
}
