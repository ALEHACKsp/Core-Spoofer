using System;
using System.Threading;

namespace Core
{
	// Token: 0x02000002 RID: 2
	internal class Misc
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00002050
		public static void DrawASCII()
		{
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine(" ▄████▄   ▒█████   ██▀███  ▓█████  ▐██▌ ");
			Thread.Sleep(50);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("▒██▀ ▀█  ▒██▒  ██▒▓██ ▒ ██▒▓█   ▀  ▐██▌ ");
			Thread.Sleep(50);
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("▒▓█    ▄ ▒██░  ██▒▓██ ░▄█ ▒▒███    ▐██▌ ");
			Thread.Sleep(50);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("▒▓▓▄ ▄██▒▒██   ██░▒██▀▀█▄  ▒▓█  ▄  ▓██▒ ");
			Thread.Sleep(50);
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("▒ ▓███▀ ░░ ████▓▒░░██▓ ▒██▒░▒████▒ ▒▄▄  ");
			Thread.Sleep(50);
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("░ ░▒ ▒  ░░ ▒░▒░▒░ ░ ▒▓ ░▒▓░░░ ▒░ ░ ░▀▀▒ ");
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Thread.Sleep(50);
			Console.WriteLine("  ░  ▒     ░ ▒ ▒░   ░▒ ░ ▒░ ░ ░  ░ ░  ░ ");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("░        ░ ░ ░ ▒    ░░   ░    ░       ░ ");
			Thread.Sleep(50);
			Console.ForegroundColor = ConsoleColor.DarkYellow;
			Console.WriteLine("░ ░          ░ ░     ░        ░  ░ ░    ");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000213C File Offset: 0x0000213C
		public static void start()
		{
			Console.BackgroundColor = ConsoleColor.Black;
			Console.Clear();
			Misc.DrawASCII();
			Console.Clear();
			Misc.DrawASCII();
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Title = "Core Spoofer | Loaded, Working. Version 3.0.1";
			Thread.Sleep(2000);
			Console.Title = "Created by | Fimxi#0003, Trix#0666! | ";
			Misc.HashText("====================");
			Misc.OptionText("Spoof [Unban]");
			Misc.HashText("====================");
			Console.ForegroundColor = ConsoleColor.White;
			Misc.OptionText("Clean Traces [No Kick]");
			Misc.HashText("====================");
			Console.ForegroundColor = ConsoleColor.Blue;
			Misc.OptionText("Clean and Spoof (What i do)");
			Misc.HashText("====================");
			Console.ForegroundColor = ConsoleColor.White;
			Misc.OptionText("Youtube");
			Misc.HashText("====================");
			Console.ForegroundColor = ConsoleColor.Blue;
			Misc.HashText("Created by |Fimxi#0003, Trix#0666 |");
			Console.ForegroundColor = ConsoleColor.White;
			Misc.HashText("Option | ");
			string text = Console.ReadLine();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x0000223C File Offset: 0x0000223C
		public static void DrawASCII3()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Misc.HashText("O");
			Thread.Sleep(100);
			Misc.HashText("f");
			Misc.HashText("f");
			Thread.Sleep(100);
			Misc.HashText("c");
			Misc.HashText("i");
			Thread.Sleep(100);
			Misc.HashText("a");
			Thread.Sleep(100);
			Misc.HashText("l");
			Thread.Sleep(100);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000022C7 File Offset: 0x000022C7
		public static void HashText(string text)
		{
			Console.Write("\n ");
			Console.Write("");
			Console.Write("");
			Console.Write(text);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000022F2 File Offset: 0x000022F2
		public static void OptionText(string text)
		{
			Console.Write("\n[+] ");
			Misc.number++;
			Console.Write(Misc.number);
			Console.Write(" ");
			Console.Write(text);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002329 File Offset: 0x00002329
		private static void ResetOption()
		{
			Misc.number = 0;
		}

		// Token: 0x04000001 RID: 1
		private static int number;
	}
}
