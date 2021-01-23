/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	public class CuttTimelineWorkSheet : ScriptableObject
	{
		// Fields
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
	
		// Properties
		public ICuttTimelineKeyDataList[] keysArray { get; }
	
		// Constructors
		public CuttTimelineWorkSheet();
		static CuttTimelineWorkSheet();
	
		// Methods
		public bool IsEnable();
		private ICuttTimelineKeyDataList[] GetKeysInGroup<T>(List<T> groups)
			where T : ICuttTimelineGroupData;
		private ICuttTimelineKeyDataList[] GetKeysInSet<T>(T[] setData)
			where T : ICuttTimelineSetData;
		private void SetupNameHashInGroup<T>(List<T> groups)
			where T : ICuttTimelineGroupData;
		public void OnLoad(CuttTimelineControl timelineControl);
	}
}
