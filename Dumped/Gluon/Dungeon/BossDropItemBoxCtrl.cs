using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class BossDropItemBoxCtrl : MonoBehaviour
	{
		[Serializable]
		private class PositionData
		{
			public Vector3 position;

			public float rotY;
		}

		public DropItemBox.TreasureBoxKind boxKind;

		private const int maxBox = 6;

		[SerializeField]
		private int normalNum;

		[SerializeField]
		private int normalTreasureTimeNum;

		[SerializeField]
		private int hardNum;

		[SerializeField]
		private int hardTreasureTimeNum;

		[SerializeField]
		private int veryHardNum;

		[SerializeField]
		private int veryHardTreasureTimeNum;

		[SerializeField]
		private int extremeNum;

		[SerializeField]
		private int extremeTreasureTimeNum;

		[SerializeField]
		private int hellNum;

		[SerializeField]
		private int hellTreasureTimeNum;

		[SerializeField]
		private int variation6Num;

		[SerializeField]
		private int variation6TreasureTimeNum;

		[SerializeField]
		private int variation7Num;

		[SerializeField]
		private int variation7TreasureTimeNum;

		[SerializeField]
		private int variation8Num;

		[SerializeField]
		private int variation8TreasureTimeNum;

		[SerializeField]
		private int variation9Num;

		[SerializeField]
		private int variation9TreasureTimeNum;

		[SerializeField]
		private int variation10Num;

		[SerializeField]
		private int variation10TreasureTimeNum;

		[SerializeField]
		private PositionData[] positionData01;

		[SerializeField]
		private PositionData[] positionData02;

		[SerializeField]
		private PositionData[] positionData03;

		[SerializeField]
		private PositionData[] positionData04;

		[SerializeField]
		private PositionData[] positionData05;

		[SerializeField]
		private PositionData[] positionData06;

		private List<PositionData[]> positionDataList;

		private List<BossDropItemBox> bossDropItemBoxList;

		private int bossDropItemBoxIndex;

		private int bossDropItemBoxUseCount;

		private int bossDropItemBoxOpenCount;

		private int bossDropItemBoxNumMax;

		private bool needAssignSerialNumberOnStart;

		private static readonly string[] boxPrefabNameArray;

		private void Start()
		{
		}

		public void SetParent(Transform parent)
		{
		}

		private void SetBossItem(DropItemUI.Parameter param)
		{
		}

		public void SetBossItemBox(DropItemUI.Parameter param)
		{
		}

		public void Display()
		{
		}

		public IEnumerator DisplayBossItemBox()
		{
			return null;
		}

		public void OnOpenBossItemBox()
		{
		}

		public bool IsOpenBossItemBox()
		{
			return default(bool);
		}

		public void AssignSerialNumbers()
		{
		}
	}
}
