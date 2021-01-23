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
	public class BushManager : FastUpdateMonoBehaviour
	{
		// Fields
		public static BushManager instance;
		private static readonly float holeRadiusSizeMax;
		private static readonly float holeRadiusSizeMin;
		private static readonly float holeRadiusSizeLimit;
		private float holeRadiusSizeNow;
		private static readonly float holeRadiusLerpSpeed;
		private Dictionary<CharacterBase, int> charaHitBushCountList;
		private List<CharacterBase> inHoleCharas;
		private CharacterBase prevFocusChara;
	
		// Constructors
		public BushManager();
		static BushManager();
	
		// Methods
		public static void Initialize(Transform parentTransform);
		private void OnDestroy();
		public override void FastUpdate();
		public void OnCharaEnter(CharacterBase chara, Action<Vector3, bool> playHitEffectAction);
		public void OnCharaExit(CharacterBase chara, Action<Vector3, bool> playHitEffectAction);
		private bool IsInHoleRange(CharacterBase chara, CharacterBase focusChara);
		private void AddInHoleChara(CharacterBase chara);
		private void RemoveInHoleChara(CharacterBase chara);
		private void ClearInHoleCharas();
		public bool IsInvisibleChara(CharacterBase chara);
	}
}
