using System.Collections.Generic;
using Cute.Core;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class BushClip : FastUpdateMonoBehaviour
	{
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

		public void SetBurn(string label, int triggerId)
		{
		}

		public void Awake()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void PlayHitEffect(Vector3 pos, bool isEnter)
		{
		}

		private bool CanPlayHitEffect()
		{
			return default(bool);
		}
	}
}
