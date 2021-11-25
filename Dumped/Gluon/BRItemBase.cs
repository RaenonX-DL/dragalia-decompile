using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gluon.Dungeon.Gimmick;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class BRItemBase : MonoBehaviour
	{
		[HideInInspector]
		public float activateIntervalSec;

		private float elapsedSec;

		public Vector3 position;

		private int itemShaderPropertyId;

		private Renderer targetRenderer;

		private Material targetMaterial;

		private bool caughtFlag;

		public static readonly float rotationScaleDefault;

		public float rotationScale;

		private static readonly float checkRadItemToBush;

		private static readonly float checkRadItemToPlayer;

		private List<BushClip> bushClipList;

		private float updateShaderParamTimer;

		public BRItemId Id => default(BRItemId);

		public BRItemParam itemParam
		{
			[CompilerGenerated]
			get
			{
				return default(BRItemParam);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public virtual void SetItemParam(BRItemParam param)
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected void Awake()
		{
		}

		protected virtual void Update()
		{
		}

		protected void UpdateShaderParam()
		{
		}

		private bool IsInside(Vector3 pos1, Vector3 pos2, float rad)
		{
			return default(bool);
		}

		public void SetInBush(BushClip bushScr, bool enterFlag)
		{
		}

		public void SetInHouse(bool insideWithPlayer)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerStay(Collider other)
		{
		}

		private void TriggerCore(Collider other, bool enterFlag)
		{
		}

		public bool CanGetItem()
		{
			return default(bool);
		}

		public virtual void OnGotItem(CharacterBase chara)
		{
		}

		private IEnumerator CoGotItemDirection(CharacterBase chara)
		{
			return null;
		}

		private void SetCantGetItemDirection()
		{
		}

		protected virtual void Apply(CharacterBase chara)
		{
		}

		public virtual bool IsEffectiveFor(CharacterBase chara)
		{
			return default(bool);
		}

		public void OnDelete()
		{
		}

		private void SendRequestGetItem(CharacterBase chara)
		{
		}

		public BattleRoyalDungeonItemElement GetItemElem()
		{
			return null;
		}
	}
}
