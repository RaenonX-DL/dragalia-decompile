using System;
using System.Collections;
using System.Collections.Generic;
using Gluon.Event;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class DropItemBox : DungeonObjectBase
	{
		public enum TreasureBoxKind
		{
			Default = 0,
			EggHunt = 1,
			EnumMax = 2,
			None = -1
		}

		public enum TreasureRareKind
		{
			Normal,
			Rare,
			EnumMax
		}

		public float dropTime;

		public string openEffectName;

		public int openEffectTrigger;

		protected DropItemUI.Parameter itemParam;

		protected DropItemUI.Parameter itemParamItem;

		protected DropItemUI.Parameter itemParamWeapon;

		protected DropItemUI.Parameter itemParamMoney;

		protected DropItemUI.Parameter itemParamMaterial;

		protected DropItemUI.Parameter itemParamDungeonItem;

		protected DropItemUI.Parameter itemParamManaPoint;

		protected DropItemUI.Parameter itemParamRaidEventItem;

		protected DropItemUI.Parameter itemParamMazeEventItem;

		protected DropItemUI.Parameter itemParamOtherEventItem;

		private const int BombId = 3001;

		protected bool hitted;

		protected bool isCharaTalk;

		private GameObject bombObj;

		private int limitNum;

		private float numRatio;

		protected bool isRare;

		protected GameObject rareObj;

		protected GameObject normalObj;

		protected bool isStartTimeIniitialize;

		protected Action disppearCallback;

		protected static readonly List<string> treasureBoxNameList;

		protected static readonly List<string> treasureBoxRareSuffixList;

		private static readonly Dictionary<string, string> seTbl;

		public bool Hitted => default(bool);

		public static string GetTreasureBoxName(TreasureBoxKind boxKind, TreasureRareKind rareKind)
		{
			return null;
		}

		protected TreasureBoxKind GetTreasureBoxKind(string name)
		{
			return default(TreasureBoxKind);
		}

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public override void OnCollided(GameObject target, CollisionHitAttribute data)
		{
		}

		private void OnCollided(GameObject target, bool fromEvent)
		{
		}

		protected virtual IEnumerator DropItem(GameObject target)
		{
			return null;
		}

		private void Drop(DropItemUI.Parameter param)
		{
		}

		private Quaternion CalcHitRotation(GameObject target)
		{
			return default(Quaternion);
		}

		protected void PlaySE(GameObject target)
		{
		}

		private IEnumerator Disppear()
		{
			return null;
		}

		protected virtual List<EntityData> GetEntityData()
		{
			return null;
		}

		protected DropItemElement.Type GetEntityDataTypeToDropItemType(EntityData data, out int num, out int limit)
		{
			return default(DropItemElement.Type);
		}

		public override void OnEvent(DungeonObject eventObject, GameObject target)
		{
		}
	}
}
