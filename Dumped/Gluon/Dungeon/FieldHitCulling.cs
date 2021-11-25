using System.Collections;
using System.Collections.Generic;
using Gluon.Dungeon.Gimmick;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class FieldHitCulling : GimmickBase
	{
		[SerializeField]
		private Transform cullTargetTransform;

		private List<Renderer> cullTargetRendererList;

		private List<Material> cullTargetMaterialList;

		[SerializeField]
		private Transform removeForWinProductionTransform;

		private bool burnFlag;

		[SerializeField]
		private List<Transform> removeForFireBallTransformList;

		[SerializeField]
		private List<Transform> appearForFireBallTransformList;

		[SerializeField]
		private float inFadeTime;

		private static readonly float inFadeValue;

		[SerializeField]
		private float outFadeTime;

		private static readonly float outFadeValue;

		private List<BRItemBase> brItemBaseList;

		private Collider hitCollider;

		private Coroutine _progressCoroutine;

		private HashSet<CharacterBase> insideCharas;

		private CharacterBase prevFocusChara;

		protected virtual Coroutine progressCoroutine
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public void SetBurn(string label, int triggerId)
		{
		}

		protected override void Awake()
		{
		}

		public override void FastUpdate()
		{
		}

		private void UpdateItem(bool insideWithPlayer)
		{
		}

		private bool IsFadeOK(CharacterBase chara)
		{
			return default(bool);
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		protected virtual void StartFadeIn()
		{
		}

		protected virtual void StartFadeOut()
		{
		}

		protected void StartFadeCoroutine(bool inFlag, float fadeValue, float fadeTime)
		{
		}

		private IEnumerator TransitionAlpha(bool inFlag, float toValue, float maxSec)
		{
			return null;
		}

		private void ChangeEffectAlpha(float alpha)
		{
		}

		private bool IsCameraFocusCharaInside()
		{
			return default(bool);
		}

		private void SetCharaVisibility(CharacterBase chara, bool visibility, bool force)
		{
		}

		public override void OnProductionTime()
		{
		}
	}
}
