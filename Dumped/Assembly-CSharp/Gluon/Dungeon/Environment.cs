/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	[ExecuteInEditMode]
	public class Environment : MonoBehaviour
	{
		// Fields
		[NonSerialized]
		public string BGM;
		[NonSerialized]
		public CameraType cameraType;
		[NonSerialized]
		public Gluon.BossCamera bossCameraType;
		[NonSerialized]
		public List<BossCameraEnemyData> bossCameraEnemyList;
		public GameObject[] clearObject;
		public float clearTermsTimeElapsed;
		public HpExpiration[] clearHpExpiration;
		[HideInInspector]
		[SerializeField]
		private List<HideObjectInfo> hideOnPlayingList;
	
		// Nested types
		[Serializable]
		public class BossCameraEnemyData
		{
			// Fields
			public int paramId;
			public Gluon.BossCameraPos positionId;
			public string shadowAttachNode;
			public float shadowScale;
	
			// Constructors
			public BossCameraEnemyData();
		}
	
		[Serializable]
		public class HpExpiration
		{
			// Fields
			public int paramId;
			public int hpRatio;
	
			// Constructors
			public HpExpiration();
		}
	
		[Serializable]
		public class HideObjectInfo
		{
			// Fields
			public List<int> siblingIndexPath;
	
			// Constructors
			public HideObjectInfo();
		}
	
		// Constructors
		public Environment();
	
		// Methods
		public void SetupFromMasterAreaData(DungeonAreaPlannerDataElement plannerAreaData, DungeonManager.eStageDifficulty stageDifficulty);
		public void ApplyHideObjecst();
	}
}
