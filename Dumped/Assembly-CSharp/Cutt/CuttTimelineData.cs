/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	public class CuttTimelineData : ScriptableObject
	{
		// Fields
		public static string[] sVersionList;
		public string version;
		public int timeLength;
		public CuttTimelineCharacterSettings characterSettings;
		public CuttTimelineSceneObjectSettings sceneObjectSettings;
		public CuttTimelineMaterialSettings materialSettings;
		public CuttTimelineEffectSettings effectSettings;
		public CuttTimelineSoundSettings soundSettings;
		public CuttTimelineFlashSettings flashSettings;
		[SerializeField]
		private List<CuttTimelineWorkSheet> worksheetList;
	
		// Constructors
		public CuttTimelineData();
		static CuttTimelineData();
	
		// Methods
		public List<CuttTimelineWorkSheet> GetWorkSheetList();
		public CuttTimelineWorkSheet GetWorkSheet(int index);
		public void UnloadSheets();
		public void OnLoad(CuttTimelineControl timelineControl);
	}
}
