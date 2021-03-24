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
	public class GraphicUtility
	{
		// Constructors
		public GraphicUtility();
	
		// Methods
		public static void InstantiateMaterial(GameObject gameObject, bool isMaterialShared);
		public static void SetLerpRimParam(float statusLerpRimWidth, float statusLerpRimMax, float statusLerpRimSpeed, float statusLerpRimOffset);
		public static void SetCharaColor(MaterialPropertyBlock materialPropertyBlock, CharacterColor colorCtrl, bool isStatusColorSet);
		public static void SetMixingPropertyRatio(MaterialPropertyBlock materialPropertyBlock, int propertyID, float ratio, float min = 0f, float max = 1f);
		public static void SetMixingTexture(MaterialPropertyBlock materialPropertyBlock, int preId, Texture2D preImage, int postId, Texture2D postImage, int preSTId, Vector2 scale, Vector2 offset);
		public static void SetMixingTextureRatio(MaterialPropertyBlock materialPropertyBlock, float ratio);
		public static void SetAuraCutoutRaito(MaterialPropertyBlock materialPropertyBlock, float ratio);
		public static void SetAuraColorRaito(MaterialPropertyBlock materialPropertyBlock, float ratio);
	}
}
