/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace ExitGames.Client.Photon.LoadBalancing
{
	public class TypedLobby
	{
		// Fields
		public string Name;
		public LobbyType Type;
		public static readonly TypedLobby Default;
	
		// Properties
		public bool IsDefault { get; }
	
		// Constructors
		public TypedLobby();
		public TypedLobby(string name, LobbyType type);
		static TypedLobby();
	
		// Methods
		public override string ToString();
	}
}
