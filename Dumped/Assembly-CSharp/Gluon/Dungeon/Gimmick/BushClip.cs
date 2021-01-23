/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon.Gimmick
{
	public class BushClip : FastUpdateMonoBehaviour
	{
		// Fields
		[SerializeField]
		private string hitEffectLabel;
		[SerializeField]
		private int hitEffectTrigger;
		[SerializeField]
		private string hitSoundLabel;
		[SerializeField]
		private string outSoundLabel;
		[SerializeField]
		private bool ignoreItemHitFlag;
		private bool burnFlag;
		[SerializeField]
		private List<Transform> removeForFireBallTransformList;
		[SerializeField]
		private List<Transform> appearForFireBallTransformList;
		private List<CharacterBase> insideCharaBaseList;
		private List<BRItemBase> insideItemList;
	
		// Constructors
		public BushClip();
	
		// Methods
		public void SetBurn(string label, int triggerId);
		public void Awake();
		private void OnTriggerEnter(Collider other);
		private void OnTriggerExit(Collider other);
		private void PlayHitEffect(Vector3 pos, bool isEnter);
		private bool CanPlayHitEffect();
	}
}
