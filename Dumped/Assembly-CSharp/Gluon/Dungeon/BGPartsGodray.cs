/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	[ExecuteInEditMode]
	public class BGPartsGodray : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private float FadeOutStartDistance;
		[SerializeField]
		private float FadeOutEndDistance;
		private MeshCollider meshCollider;
		private float prevAlpha;
		private MaterialPropertyBlock[] materialPropertyBlockArray;
		private int programmableColorId;
		[NonSerialized]
		public float masterAlpha;
	
		// Constructors
		public BGPartsGodray();
	
		// Methods
		private void Start();
		private void Update();
		private void UpdateFadeout();
		private void InitializeGodRay();
		private void InitializeMaterial();
		private void ApplyMaterialAlpha(float alpha);
	}
}
