using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XInput_Hotkeys
{
	static class Program
	{
		public const string INSTALL_SVC_ARGUMENT = "inst_svc";
		public const string UNINSTALL_SVC_ARGUMENT = "uninst_svc";

		/// <summary>
		/// Punto di ingresso principale dell'applicazione.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			if (args.Length > 0 && args[0] != string.Empty)
			{
				string command;
				switch (args[0])
				{
					case INSTALL_SVC_ARGUMENT:
						command = "SC CREATE \"" + AppDomain.CurrentDomain.FriendlyName + "\" binpath=\"" + System.Reflection.Assembly.GetEntryAssembly().Location + "\"";
						break;
					case UNINSTALL_SVC_ARGUMENT:
						command = "SC DELETE \"" + AppDomain.CurrentDomain.FriendlyName + "\"";
						break;
					default:
						throw new Exception("Unknown argument");
				}

				var output = LaunchCommand(command);

				MessageBox.Show(output);

				Application.Exit();
			}
			else
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				_ = new MainForm();
				Application.Run();
			}
		}

		public static string LaunchCommand(string command, bool elevated = false)
		{
			var info = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				FileName = "cmd.exe",
				Arguments = "/C " + command
			};

			if (elevated)
			{
				info.Verb = "runas";
			}
			else
			{
				info.RedirectStandardOutput = true;
				info.UseShellExecute = false;
			}

			Process process = new Process
			{
				StartInfo = info
			};
			process.Start();

			string output = "";
			if (elevated == false)
			{
				output= process.StandardOutput.ReadToEnd();
			}
			process.WaitForExit();

			return output;
		}
	}
}
