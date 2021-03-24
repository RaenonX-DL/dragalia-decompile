/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public interface FortUIEventInterface : IEventSystemHandler
	{
		// Methods
		void OnPlayRightSlideIn();
		void OnPlayRightSlideOut();
		void OnRightSlideIn();
		void OnRightSlideOut();
		void OnBottomSlideIn();
		void OnBottomSlideOut();
		void OnFacilitySelectCancel(bool playBottomSlideOut);
		void OnFacilityVanished(GameObject gameObject);
	}
}
