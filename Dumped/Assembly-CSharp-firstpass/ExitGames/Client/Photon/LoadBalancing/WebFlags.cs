/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace ExitGames.Client.Photon.LoadBalancing
{
	public class WebFlags
	{
		// Fields
		public static readonly WebFlags Default;
		public byte WebhookFlags;
		public const byte HttpForwardConst = 1;
		public const byte SendAuthCookieConst = 2;
		public const byte SendSyncConst = 4;
		public const byte SendStateConst = 8;
	
		// Properties
		public bool HttpForward { get; set; }
		public bool SendAuthCookie { get; set; }
		public bool SendSync { get; set; }
		public bool SendState { get; set; }
	
		// Constructors
		public WebFlags(byte webhookFlags);
		static WebFlags();
	}
}
