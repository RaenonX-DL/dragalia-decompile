/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FlashPlayerManager : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private int flashPlayingMax;
		private PoolableObject<FlashPlayer> flashPlayerPool;
	
		// Constructors
		public FlashPlayerManager();
	
		// Methods
		public FlashPlayer GetflashPlayer();
		private void OnDestroy();
		private void InitFlashPlayerPool();
		private FlashPlayer GetFlashPlayerFromPool();
	}
}
