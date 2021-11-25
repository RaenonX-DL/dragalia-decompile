using System;
using System.Collections;
using Gluon.Event;
using Gluon.Master;
using UnityEngine;

namespace Gluon.Dungeon.Gimmick
{
	public class BreakableGimmick : DungeonObjectBase
	{
		[Serializable]
		public class ModelData
		{
			public float activeRate;

			public GameObject activeObject;

			public ModelData(float rate)
			{
			}
		}

		private GimmickDurablePillarElement variationData;

		[SerializeField]
		[Lock]
		private string soundLabelDamage;

		[SerializeField]
		[Lock]
		private string soundLabelBreak;

		[SerializeField]
		[Lock]
		private string effectLabelBreak;

		private EffectObject effectObj;

		[SerializeField]
		[Lock]
		private int effectTriggerDamage;

		[SerializeField]
		[Lock]
		private int effectTriggerBreak;

		[SerializeField]
		[Lock]
		private float lifeMax;

		private float lifeNow;

		private bool eventInitializedFlag;

		private int changeModelDataIndex;

		[SerializeField]
		private ModelData[] changeModelDataArray;

		[SerializeField]
		private GameObject[] lastRemoveObjectArray;

		private bool hitFlag;

		private static readonly int disableCollisionOffsetY;

		protected override void Awake()
		{
		}

		private IEnumerator StartAction()
		{
			return null;
		}

		private void SetDrawObject(int id, bool effectFlag)
		{
		}

		public override void OnCollided(GameObject target, CollisionHitAttribute data)
		{
		}

		public override void OnEvent(DungeonObject eventObject, GameObject target)
		{
		}
	}
}
