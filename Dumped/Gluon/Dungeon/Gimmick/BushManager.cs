using System;
using System.Collections.Generic;
using Cute.Core;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class BushManager : FastUpdateMonoBehaviour
	{
		public static BushManager instance;

		private static readonly float holeRadiusSizeMax;

		private static readonly float holeRadiusSizeMin;

		private static readonly float holeRadiusSizeLimit;

		private float holeRadiusSizeNow;

		private static readonly float holeRadiusLerpSpeed;

		private Dictionary<CharacterBase, int> charaHitBushCountList;

		private List<CharacterBase> inHoleCharas;

		private CharacterBase prevFocusChara;

		public static void Initialize(Transform parentTransform)
		{
		}

		private void OnDestroy()
		{
		}

		public override void FastUpdate()
		{
		}

		public void OnCharaEnter(CharacterBase chara, Action<Vector3, bool> playHitEffectAction)
		{
		}

		public void OnCharaExit(CharacterBase chara, Action<Vector3, bool> playHitEffectAction)
		{
		}

		private bool IsInHoleRange(CharacterBase chara, CharacterBase focusChara)
		{
			return default(bool);
		}

		private void AddInHoleChara(CharacterBase chara)
		{
		}

		private void RemoveInHoleChara(CharacterBase chara)
		{
		}

		private void ClearInHoleCharas()
		{
		}

		public bool IsInvisibleChara(CharacterBase chara)
		{
			return default(bool);
		}
	}
}
