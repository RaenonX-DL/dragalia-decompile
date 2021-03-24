/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	[Serializable]
	public class CuttFlashInitializeData
	{
		// Fields
		public static readonly string prefabPathBase;
		public static readonly string commonAssetFolderName;
		public bool usePrivateFolder;
		public string flashPrefabName;
		[SerializeField]
		public List<CuttFtuInitializeData> ftuInitializeDataList;
		[HideInInspector]
		public CuttFlashController flashController;
	
		// Constructors
		public CuttFlashInitializeData(string flashPrefabName, List<CuttFtuInitializeData> initDataList);
		static CuttFlashInitializeData();
	}
}
