/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class DungeonSceneInfo : ScriptableObject
	{
		// Fields
		public const string AssetNamePrefix = "SCENEINFO_";
		public const string ScneneInfoName = "Dungeon/SceneInfo";
		public const string ResourceDir = "Dungeon/SceneInfo/";
		[SerializeField]
		private string[] _setGimmickPrefabNames;
		[SerializeField]
		private string[] _setReactionPrefabNames;
		[SerializeField]
		private string[] _setGatePrefabNames;
		[SerializeField]
		private string[] _setEtcPrefabNames;
	
		// Properties
		public string[] setGimmickPrefabNames { get; }
		public string[] setReactionPrefabNames { get; }
		public string[] setGatePrefabNames { get; }
		public string[] setEtcPrefabNames { get; }
	
		// Constructors
		public DungeonSceneInfo();
	
		// Methods
		public static string MakeAssetName(string areaName);
		public static DungeonSceneInfo LoadOrDefault(string areaName);
		public static string GetAreaNameFromSceneInfoName(string fileNameWithoutExt);
	}
}
