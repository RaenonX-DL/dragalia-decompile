/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	public interface ICuttTimelineCharactorLocator
	{
		// Properties
		bool cuttCharaVisible { get; set; }
		CuttCharaPosition cuttCharaStandingPosition { get; set; }
		Vector3 cuttCharaInitialPosition { get; set; }
		Vector3 cuttCharaHeadPosition { get; }
		Vector3 cuttCharaChestPosition { get; }
		Vector3 cuttCharaFootPosition { get; }
		Animation cuttAnimationComponent { get; }
		Transform cuttRootTransform { get; }
		int cuttCharaHeightLevel { get; set; }
		float cuttCharaHeightValue { get; }
		float cuttCharaHeightRatio { get; set; }
	}
}
