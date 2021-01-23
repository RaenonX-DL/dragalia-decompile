/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MatchingRoomTempData : MonoBehaviour
	{
		// Fields
		private static MatchingRoomTempData instance;
		private MatchingService.Room _room;
		private MatchingService.Player _player;
	
		// Properties
		public MatchingService.Room room { get; set; }
		public MatchingService.Player player { get; set; }
		public static MatchingRoomTempData Instance { get; }
	
		// Constructors
		public MatchingRoomTempData();
	
		// Methods
		public static void Create();
		public static void Destroy();
	}
}
