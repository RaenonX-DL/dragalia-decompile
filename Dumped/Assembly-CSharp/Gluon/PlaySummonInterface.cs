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
	public class PlaySummonInterface : IPlaySummonInterface
	{
		// Fields
		public static IPlaySummonInterface instance;
	
		// Properties
		public Transform node3d { get; }
		public FlashPlayerManager flashPlayerManager { get; }
		public CameraClearFlags oldFlashCameraClearFlags { get; set; }
		public RenderTexture charaWeaponRenderTexture { get; }
		public bool IsBoxSummon { get; }
	
		// Constructors
		public PlaySummonInterface();
		static PlaySummonInterface();
	
		// Methods
		public void StartWhiteOutEffect(float inTime, float outTime);
		public void OnBoxSummonEvent(BoxSummonEventId eid);
	}
}
