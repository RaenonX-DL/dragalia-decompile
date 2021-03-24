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
	public interface IPlaySummonInterface
	{
		// Properties
		Transform node3d { get; }
		FlashPlayerManager flashPlayerManager { get; }
		CameraClearFlags oldFlashCameraClearFlags { get; set; }
		RenderTexture charaWeaponRenderTexture { get; }
		bool IsBoxSummon { get; }
	
		// Methods
		void StartWhiteOutEffect(float inTime, float outTime);
		void OnBoxSummonEvent(BoxSummonEventId eid);
	}
}
