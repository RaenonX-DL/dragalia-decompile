/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using Cute.Master;
using Gluon;
using SerializableCollections;
using UnityEngine;
using UnityEngine.SceneManagement;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public static class Utility
	{
		// Fields
		public static readonly DungeonSubNode[] PrefabSubNodeList;
		public const string QuestPrefabPathBase = "Prefabs/InGame/Quest/";
		public const string QuestPrefabPath = "Assets/_GluonResources/Resources/Prefabs/InGame/Quest/";
		public static readonly string[] SubNodeNamesAuth;
		public static readonly string[] SubNodeNames;
		public const string PlayerPrefsKeyQuestPath = "DungeonName";
		public const string PlayerPrefsKeyAreaName = "QuestPrefabName";
		private const string UtilCaptureCameraPrefabPath = "Assets/_Debug/Utility/CaptureCamera.prefab";
		public static StringBuilder _bufferedLog;
	
		// Nested types
		public delegate bool CameraSettingDelegate(Camera cam);
	
		// Constructors
		static Utility();
	
		// Methods
		public static string GetSubNodeNameAuth(DungeonSubNodeAuth subNode);
		public static GameObject FindSubNodeAuth(GameObject parent, DungeonSubNodeAuth subNode);
		public static Transform FindSubNodeTransAuth(Transform parent, DungeonSubNodeAuth subNode);
		public static string GetSubNodeName(DungeonSubNode subNode);
		public static Transform FindSubNodeTrans(GameObject parent, DungeonSubNode subNode);
		public static Transform FindSubNodeTrans(Transform parent, DungeonSubNode subNode);
		public static GameObject FindSubNode(GameObject parent, DungeonSubNode subNode);
		public static GameObject FindSubNode(Transform parent, DungeonSubNode subNode);
		public static GameObject FindFirstSubNode(DungeonSubNode subNode);
		public static void FindNodesByName(Transform trans, string nodeNameContains, List<GameObject> collection);
		public static List<GameObject> FindNodesByName(Transform trans, string nodeNameContains);
		public static GameObject FindRootObject(Scene scene);
		public static GameObject FindRootObject();
		public static void SortSubNode(Transform rootNode);
		public static bool ConvertColorFromHexCode(out Color color, string hexCode, Color defaultColor = default);
		public static string ConvertHexCodeFromColor(Color color);
		public static void BufferedLog(string msg);
		public static void BufferedLogLine(string msg);
		public static void BufferedLogFlush();
		public static string GetDifficultyName(DungeonManager.eStageDifficulty diffcult);
		public static DungeonManager.eStageDifficulty GetDifficultyFromName(string diffcultName);
		public static bool IsDifficultyNode(Transform node);
		public static DungeonManager.eStageDifficulty GetDifficultyOf(Transform diffcultyNode);
		public static Transform FindDifficuliyNodeOf(DungeonManager.eStageDifficulty difficulty);
		public static bool IsQuestRootNode(Transform t);
		public static GameObject[] GetQuestRootNodes();
		public static GameObject GetParentQuestRootNode(GameObject go);
		public static bool CalculateBoundsUnder(out Bounds bounds, Transform calculateRoot);
		public static Vector3 RoundVec(Vector3 vec);
		public static void DebugLogWarnColored(string log);
		public static void DebugLogWarnColored(string fmt, params string[] args);
		public static void DebugLogColored(string color, string log);
		public static T FindComponentInScene<T>(Scene scene)
			where T : Component;
		public static T[] FindComponentsInScene<T>(Scene scene, bool includeInactive)
			where T : Component;
		private static bool IsMatchAreaId(string areaName, string masterAreaName);
		private static bool IsMatchGimmmickDataLabel(string gimmickName, string masterGimmickName);
		private static string GetGimmickDataLabel(string gimmickName, string areaName, int difficulty);
		public static T GetAreaQuestSkillData<T>(SerializableDictionary<string, T> AreaQuestSkillkMasterDict, string questSkillDataLable)
			where T : IMasterElement;
		public static T GetGimmickDataElement<T>(SerializableDictionary<string, T> gimmickMasterDict, GameObject gimmick)
			where T : IMasterElement;
	}
}
