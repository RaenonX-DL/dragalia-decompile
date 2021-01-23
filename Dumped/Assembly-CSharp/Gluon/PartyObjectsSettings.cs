/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[Serializable]
	[ExecuteAlways]
	public class PartyObjectsSettings : MonoBehaviour
	{
		// Fields
		public Vector3 cameraPosition;
		public Vector3 cameraRotation;
		public Vector3 cameraCharaScenePosition;
		public Vector3 cameraCharaSceneRotation;
		public Vector3[] cameraEquipScenePositions;
		public Vector3[] cameraEquipSceneRotations;
		public float[] cameraEquipSceneFOVs;
		public float cameraTopSceneFOV;
		public float cameraCharacterSceneFOV;
		public float cameraNear;
		public float cameraFar;
		public Ease ToTopEase;
		public Ease ToCharacterEase;
		public Ease ToEquipEase;
		public float ToTopTime;
		public float ToCharacterTime;
		public float ToEquipTime;
		public float shadowCastMargin;
		public float shadowScale;
		public Vector3[] characterTopScenePositions;
		public Vector3[] characterTopSceneRotations;
		public Vector3[] characterEditScenePositions;
		public Vector3[] characterEditSceneRotations;
	
		// Constructors
		public PartyObjectsSettings();
	
		// Methods
		private void OnValidate();
		public void Reset();
	}
}
