using System;
using System.Collections.Generic;
using Gluon;
using UnityEngine;

namespace Cutt
{
	[Serializable]
	public class CuttFlashInitializeData
	{
		public static readonly string prefabPathBase;

		public static readonly string commonAssetFolderName;

		public bool usePrivateFolder;

		public string flashPrefabName;

		[SerializeField]
		public List<CuttFtuInitializeData> ftuInitializeDataList;

		[HideInInspector]
		public CuttFlashController flashController;

		public CuttFlashInitializeData(string flashPrefabName, List<CuttFtuInitializeData> initDataList)
		{
		}
	}
}
