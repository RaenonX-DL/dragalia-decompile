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
	public class GrowthWeaponObjectsSettings : MonoBehaviour
	{
		// Fields
		[HideInInspector]
		public Vector3 render3dCameraPos;
		[HideInInspector]
		public Vector3 render3dCameraRot;
		[HideInInspector]
		public float render3dCameraFOV;
		[HideInInspector]
		public float render3dCameraNear;
		[HideInInspector]
		public float render3dCameraFar;
		[HideInInspector]
		public Vector3[] weaponPosList;
		[HideInInspector]
		public Vector3[] weaponRotList;
		[HideInInspector]
		public float[] weaponScaleList;
		[HideInInspector]
		public CraftEffectSceneBase crafctEffectScene;
	
		// Constructors
		public GrowthWeaponObjectsSettings();
	
		// Methods
		private void OnValidate();
		private void SetParameters();
	}
}
