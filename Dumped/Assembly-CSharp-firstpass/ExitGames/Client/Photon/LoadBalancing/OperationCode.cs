﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace ExitGames.Client.Photon.LoadBalancing
{
	public class OperationCode
	{
		// Fields
		[Obsolete]
		public const byte ExchangeKeysForEncryption = 250;
		public const byte Join = 255;
		public const byte AuthenticateOnce = 231;
		public const byte Authenticate = 230;
		public const byte JoinLobby = 229;
		public const byte LeaveLobby = 228;
		public const byte CreateGame = 227;
		public const byte JoinGame = 226;
		public const byte JoinRandomGame = 225;
		public const byte Leave = 254;
		public const byte RaiseEvent = 253;
		public const byte SetProperties = 252;
		public const byte GetProperties = 251;
		public const byte ChangeGroups = 248;
		public const byte FindFriends = 222;
		public const byte GetLobbyStats = 221;
		public const byte GetRegions = 220;
		public const byte WebRpc = 219;
		public const byte ServerSettings = 218;
	
		// Constructors
		public OperationCode();
	}
}
