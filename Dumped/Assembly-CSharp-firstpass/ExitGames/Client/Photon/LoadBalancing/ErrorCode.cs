/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace ExitGames.Client.Photon.LoadBalancing
{
	public class ErrorCode
	{
		// Fields
		public const int Ok = 0;
		public const int OperationNotAllowedInCurrentState = -3;
		[Obsolete]
		public const int InvalidOperationCode = -2;
		public const int InvalidOperation = -2;
		public const int InternalServerError = -1;
		public const int InvalidAuthentication = 32767;
		public const int GameIdAlreadyExists = 32766;
		public const int GameFull = 32765;
		public const int GameClosed = 32764;
		[Obsolete]
		public const int AlreadyMatched = 32763;
		public const int ServerFull = 32762;
		public const int UserBlocked = 32761;
		public const int NoRandomMatchFound = 32760;
		public const int GameDoesNotExist = 32758;
		public const int MaxCcuReached = 32757;
		public const int InvalidRegion = 32756;
		public const int CustomAuthenticationFailed = 32755;
		public const int AuthenticationTicketExpired = 32753;
		public const int PluginReportedError = 32752;
		public const int PluginMismatch = 32751;
		public const int JoinFailedPeerAlreadyJoined = 32750;
		public const int JoinFailedFoundInactiveJoiner = 32749;
		public const int JoinFailedWithRejoinerNotFound = 32748;
		public const int JoinFailedFoundExcludedUserId = 32747;
		public const int JoinFailedFoundActiveJoiner = 32746;
		public const int HttpLimitReached = 32745;
		public const int ExternalHttpCallFailed = 32744;
		public const int SlotError = 32742;
		public const int InvalidEncryptionParameters = 32741;
	
		// Constructors
		public ErrorCode();
	}
}
