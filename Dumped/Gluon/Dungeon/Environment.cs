using System;
using System.Collections.Generic;
using Gluon.Master;
using UnityEngine;

namespace Gluon.Dungeon
{
	[ExecuteInEditMode]
	public class Environment : MonoBehaviour
	{
		[Serializable]
		public class BossCameraEnemyData
		{
			public int paramId;

			public BossCameraPos positionId;

			public string shadowAttachNode;

			public float shadowScale;
		}

		[Serializable]
		public class HpExpiration
		{
			public int paramId;

			public int hpRatio;
		}

		[Serializable]
		public class HideObjectInfo
		{
			public List<int> siblingIndexPath;
		}

		[NonSerialized]
		public string BGM;

		[NonSerialized]
		public CameraType cameraType;

		[NonSerialized]
		public BossCamera bossCameraType;

		[NonSerialized]
		public List<BossCameraEnemyData> bossCameraEnemyList;

		public GameObject[] clearObject;

		public float clearTermsTimeElapsed;

		public HpExpiration[] clearHpExpiration;

		[SerializeField]
		[HideInInspector]
		private List<HideObjectInfo> hideOnPlayingList;

		public void SetupFromMasterAreaData(DungeonAreaPlannerDataElement plannerAreaData, DungeonManager.eStageDifficulty stageDifficulty)
		{
		}

		public void ApplyHideObjecst()
		{
		}
	}
}
