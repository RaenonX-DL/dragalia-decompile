/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ExitGames.Client.Photon;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class PhotonRoomProperty
	{
		// Fields
		private PhotonClient _client;
		private Hashtable _failedChangeProperty;
		private Hashtable _propertyCache;
	
		// Constructors
		public PhotonRoomProperty(PhotonClient client);
	
		// Methods
		public bool TrySetProperty(string key, object value);
		public bool TryGetProperty(string key, out object value);
		public void Resend();
	}
}
