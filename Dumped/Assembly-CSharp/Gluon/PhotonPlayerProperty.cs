/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;
using ExitGames.Client.Photon.LoadBalancing;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PhotonPlayerProperty
	{
		// Fields
		private Player _player;
		private Hashtable _failedChangeProperty;
	
		// Constructors
		public PhotonPlayerProperty(Player player);
	
		// Methods
		public bool TrySetProperty(string key, object value);
		public static bool TryGetProperty(Player player, string key, out object value);
		public bool TryGetProperty(string key, out object value);
		public void Resend();
		public bool IsSelf(Player player);
	}
}
