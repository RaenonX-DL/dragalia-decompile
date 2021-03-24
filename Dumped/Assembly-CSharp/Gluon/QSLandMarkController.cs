/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QSLandMarkController : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public GameObject originalCell;
		protected LinkedList<GameObject> cellList;
		private List<QSTableViewData> tableData;
		private readonly string landmarkPosPrefabPathFormat;
		private Dictionary<int, chapterLandMarkPosInfo> chapterLandMarkInfoDic;
	
		// Nested types
		public class landMarkPosInfo
		{
			// Fields
			public Vector3 landMarkPosition;
			public Vector3[] dotPositionArray;
			public QuestLocationInfo questLocation;
	
			// Constructors
			public landMarkPosInfo();
		}
	
		public class chapterLandMarkPosInfo
		{
			// Fields
			public List<landMarkPosInfo> landMarkPosInfoList;
	
			// Constructors
			public chapterLandMarkPosInfo();
		}
	
		// Constructors
		public QSLandMarkController();
	
		// Methods
		private chapterLandMarkPosInfo GetChapterLandMarkPosInfo(int chapterNo);
		private GameObject GetGameObjectByIndex(GameObject[] objs, int index);
		public Vector3 GetLandmarkPos(int chapterNo, int routeGroupNumber, int routeIndex);
		private landMarkPosInfo GetLandmarkPosByQuestLocationInfo(chapterLandMarkPosInfo chapterLandMarkPosInfo, int routeGroupNumber, int routeIndex);
		public Vector3 GetRouteDotPos(int chapterNo, int routeGroupNumber, int routeIndex, int dotIndex);
		public int GetRouteDotNum(int chapterNo, int routeGroupNumber, int routeIndex);
		public void LoadData();
		private void Sort(ref List<QSTableViewData> table);
		public bool IsEnable(QuestMainMenuElement qmme);
		public bool IsAppear(QuestMainMenuElement a_qmme);
		public bool IsExist(QuestMainMenuElement a_qmme);
		protected void ClearCellsList();
	}
}
