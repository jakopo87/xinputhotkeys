using SharpDX.XInput;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XInput_Hotkeys
{
	public struct XINPUT_GAMEPAD_SECRET
	{
		public uint eventCount;
		public ushort wButtons;
		public byte bLeftTrigger;
		public byte bRightTrigger;
		public short sThumbLX;
		public short sThumbLY;
		public short sThumbRX;
		public short sThumbRY;
	}

	public enum VIRTUAL_KEYS
	{
		VK_LWIN = 0x5B,
		VK_LMENU = 0xA4,
		VK_KEY_R = 0x52,
		VK_KEY_G = 0x47,
		VK_KEY_M = 0x4D,
		VK_KEY_B = 0x42,
		VK_KEY_W = 057,
		VK_SNAPSHOT = 0x2C
	}

	public enum KEYEVENTS
	{
		KEYEVENTF_KEYUP = 0x0002,
		KEYEVENTF_EXTENDEDKEY = 0x0001
	}

	public partial class MainForm : Form
	{
		[DllImport("xinput1_4.dll", EntryPoint = "#100")]
		static extern int Secret_get_gamepad(int playerIndex, out XINPUT_GAMEPAD_SECRET struc);

		[DllImport("user32.dll")]
		public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, uint dwExtraInfo);

		public static XINPUT_GAMEPAD_SECRET xgs1;

		public bool isGuidePressed = false;


		private void Keypress_chain(VIRTUAL_KEYS[] vkeys)
		{
			uint flags = 0;

			/* Key down */
			flags = (uint)(KEYEVENTS.KEYEVENTF_EXTENDEDKEY | 0);
			foreach (byte vk in vkeys)
			{
				keybd_event(vk, 0, flags, 0);
			}

			/* Key up */
			flags = (uint)(KEYEVENTS.KEYEVENTF_EXTENDEDKEY | KEYEVENTS.KEYEVENTF_KEYUP);
			foreach (byte vk in vkeys)
			{
				keybd_event(vk, 0, flags, 0);
			}
		}

		public MainForm()
		{
			InitializeComponent();
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			var c = new Controller(UserIndex.One);

			if (c.IsConnected == false)
			{
				isGuidePressed = false;
				return;
			}

			Secret_get_gamepad(0, out xgs1);

			if (xgs1.wButtons == 0x400)
			{
				isGuidePressed = true;
			}

			if (isGuidePressed && xgs1.wButtons != 0x400)
			{
				var s = c.GetState();
				switch (s.Gamepad.Buttons)
				{
					case GamepadButtonFlags.A:
						/* Capture screenshot */
						Debug.WriteLine("BUTTON A");
						Keypress_chain(new[] { VIRTUAL_KEYS.VK_LWIN, VIRTUAL_KEYS.VK_LMENU, VIRTUAL_KEYS.VK_SNAPSHOT });
						break;
					case GamepadButtonFlags.X:
						/* Record Highlight */
						Debug.WriteLine("BUTTON X");
						Keypress_chain(new[] { VIRTUAL_KEYS.VK_LWIN, VIRTUAL_KEYS.VK_LMENU, VIRTUAL_KEYS.VK_KEY_G });
						break;
					case GamepadButtonFlags.B:
						/* Start/Stop record */
						Debug.WriteLine("BUTTON B");
						Keypress_chain(new[] { VIRTUAL_KEYS.VK_LWIN, VIRTUAL_KEYS.VK_LMENU, VIRTUAL_KEYS.VK_KEY_R });
						break;
					default:
						Debug.WriteLine("GUIDE ALONE");
						Keypress_chain(new[] { VIRTUAL_KEYS.VK_LWIN, VIRTUAL_KEYS.VK_KEY_G });
						break;
				}

				isGuidePressed = false;
			}
		}

		private void ShowMenuItem_Click(object sender, EventArgs e)
		{
			Visible = true;
			WindowState = FormWindowState.Normal;
		}

		private void QuitMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			/* Do not close the application if the user closes then form */
			e.Cancel = e.CloseReason == CloseReason.UserClosing;
			Visible = false;
		}

		private void TrayIcon_DoubleClick(object sender, EventArgs e)
		{
			Visible = !Visible;
		}

		private void InstallServiceBtn_Click(object sender, EventArgs e)
		{
			var command = "\"" + Application.ExecutablePath + "\" " + Program.INSTALL_SVC_ARGUMENT;

			Program.LaunchCommand(command, true);
		}

		private void UninstallServiceBtn_Click(object sender, EventArgs e)
		{
			var command = "\"" + Application.ExecutablePath + "\" " + Program.UNINSTALL_SVC_ARGUMENT;

			Program.LaunchCommand(command, true);
		}
	}
}
