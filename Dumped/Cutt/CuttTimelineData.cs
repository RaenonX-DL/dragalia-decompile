using System.Collections.Generic;
using UnityEngine;

namespace Cutt
{
	public class CuttTimelineData : ScriptableObject
	{
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

		public List<CuttTimelineWorkSheet> GetWorkSheetList()
		{
			return null;
		}

		public CuttTimelineWorkSheet GetWorkSheet(int index)
		{
			return null;
		}

		public void UnloadSheets()
		{
		}

		public void OnLoad(CuttTimelineControl timelineControl)
		{
		}
	}
}
