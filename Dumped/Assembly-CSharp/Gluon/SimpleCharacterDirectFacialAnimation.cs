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
	[ExecuteInEditMode]
	public class SimpleCharacterDirectFacialAnimation : MonoBehaviour
	{
		// Fields
		private const int invalidPartsId = -1;
		private const int defaultEyePartsId = 101;
		private const int defaultMouthPartsId = 409;
		private const int textureNoBase = 100;
		[SerializeField]
		private float eyePartsID;
		[SerializeField]
		private float mouthPartsID;
		[SerializeField]
		public bool enableBlink;
		[SerializeField]
		public bool enableTalk;
		private int[] partsIndex;
		private bool prevEnableBlink;
		private bool prevEnableTalk;
		private SimpleCharacterModel model;
		private SimpleCharacterFacialControlDefaultEye.Work eyeWork;
		private SimpleCharacterFacialControlDefaultMouth.Work mouthWork;
	
		// Constructors
		public SimpleCharacterDirectFacialAnimation();
	
		// Methods
		private void Awake();
		private void Start();
		public void SetMouthGetNextIndex16Func(Func<int, int> getNextIndex16Func);
		private void Update();
		private void UpdateSub(SimpleCharacterModel.FacialControlKind facialKind, float inputPartsIndex);
		private void UpdateTexture(SimpleCharacterModel.FacialControlKind facialKind, int textureIndex);
		private void UpdateSprite(SimpleCharacterModel.FacialControlKind facialKind, int spriteIndex);
		private void SetEnableBlink(bool enable);
		private void SetEnableTalk(bool enable);
	}
}
