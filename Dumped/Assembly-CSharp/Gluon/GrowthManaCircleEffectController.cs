/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircleEffectController : MonoBehaviour
	{
		// Fields
		public GrowthManaCircleScene scene;
		public GrowthManaCircleEffectControllerImpl impl;
	
		// Constructors
		public GrowthManaCircleEffectController();
	
		// Methods
		public void PreLoad();
		public void OnReleasePoint(GrowthManaCircleManaPieceObject touchedPoint);
		public void OnReleaseAuto(List<GrowthManaCircleManaPieceObject> pointList);
		public void OnReleaseAutoCannotDueToLimit();
		public void OnReleaseLimit();
		public void PlayReleaseLimitFlash();
		public void ApplyFogSettings();
	}
}
