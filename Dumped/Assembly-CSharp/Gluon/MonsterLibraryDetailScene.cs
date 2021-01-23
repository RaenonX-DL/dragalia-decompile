/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MonsterLibraryDetailScene : SceneBase
	{
		// Fields
		public GameObject bgPanel;
		public Canvas mainCanvas;
		public GameObject monsterNode;
		public GameObject mainCamera;
		public static int showMonsterId;
		private MonsterViewBase monsterViewBase;
		private MonsterInfoBase monsterInfoBase;
		private MonsterHeaderBase monsterHeaderBase;
		private MonsterDetailStep nowDetailStep;
		private int nowPieceCount;
		private int maxPieceCount;
		private EnemyDataElement masterEnemyData;
		private EnemyListElement masterEnemyList;
		private const string scenePrefabPath = "Prefabs/OutGame/Note/MonsterLibrary/MonsterLibraryDetail/";
		[SerializeField]
		private MonsterLibraryCamera libraryCameras;
		private Vector3 cameraPositionOffset;
		private List<MonsterLibraryPlayerData> playerDataList;
		private int nowPlayerDataIndex;
	
		// Constructors
		public MonsterLibraryDetailScene();
		static MonsterLibraryDetailScene();
	
		// Methods
		private void Start();
		private void BackButtonPressed();
		private void ChangePageButtonPressed(MonsterDetailArrow arrowDirection);
		private void PreviewButtonPressed();
		private void SetMonsterModel();
		private void SetNowDetailStep();
		private void SetMonsterHeader();
		private void SetMonsterInfo();
		private void SetCameraProperty();
		private void ReloadNowDetail();
		private bool SetupMonsterMasterData();
		[CompilerGenerated]
		private void _ChangePageButtonPressed_b__20_0();
	}
}
