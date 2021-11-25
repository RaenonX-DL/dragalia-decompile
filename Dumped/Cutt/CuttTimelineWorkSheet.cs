using System.Collections.Generic;
using UnityEngine;

namespace Cutt
{
	public class CuttTimelineWorkSheet : ScriptableObject
	{
		public static string[] sVersionList;

		public string version;

		public int targetCameraIndex;

		public bool enableAtRuntime;

		public bool enableAtEdit;

		public CuttTimelineKeyCameraPositionDataList cameraPosKeys;

		public CuttTimelineKeyCameraLookAtDataList cameraLookAtKeys;

		public CuttTimelineKeyCameraFovDataList cameraFovKeys;

		public CuttTimelineKeyCameraRollDataList cameraRollKeys;

		public CuttTimelineKeyHandShakeDataList handShakeKeys;

		public CuttTimelineKeyEventDataList eventKeys;

		public List<CuttTimelineCharaMotSeqData> charaMotSeqList;

		public CuttTimelineKeyCameraSwitcherDataList cameraSwitcherKeys;

		public CuttTimelineKeyCameraLayerDataList cameraLayerKeys;

		public CuttTimelineKeyFloorColorDataList floorColorKeys;

		public CuttTimelineKeyCuttEventDataList cuttEventKeys;

		public CuttTimelineKeyFadeDataList fadeKeys;

		public CuttTimelineKeyBloomDataList bloomKeys;

		public CuttTimelineKeyPostEffectDataList postEffectKeys;

		public CuttTimelineKeySunShaftsDataList sunShaftsKeys;

		public CuttTimelineKeyDofCtrlDataList dofCtrlKeys;

		public CuttTimelineKeyColorAdjustmentDataList colorAdjustmentKeys;

		public CuttTimelineKeyPostFilmDataList postFilmKeys;

		public CuttTimelineKeyImageEffectDataList imageEffectKeys;

		public CuttTimelineKeyFogDataList fogKeys;

		public CuttTimelineKeyRichShaderDataList richShaderKeys;

		public List<CuttTimelineSceneObjectData> sceneObjectList;

		public List<CuttTimelineMaterialData> materialList;

		public List<CuttTimelineEffectData> effectList;

		public CuttTimelineKeySoundFilterDataList soundFilterKeys;

		public List<CuttTimelineSoundData> soundList;

		public List<CuttTimelineFlashData> flashList;

		public CuttTimelineCharacterData[] characterArray;

		private ICuttTimelineKeyDataList[] _keysArray;

		public ICuttTimelineKeyDataList[] keysArray => null;

		public bool IsEnable()
		{
			return default(bool);
		}

		private ICuttTimelineKeyDataList[] GetKeysInGroup<T>(List<T> groups) where T : ICuttTimelineGroupData
		{
			return null;
		}

		private ICuttTimelineKeyDataList[] GetKeysInSet<T>(T[] setData) where T : ICuttTimelineSetData
		{
			return null;
		}

		private void SetupNameHashInGroup<T>(List<T> groups) where T : ICuttTimelineGroupData
		{
		}

		public void OnLoad(CuttTimelineControl timelineControl)
		{
		}
	}
}
