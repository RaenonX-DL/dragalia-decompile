using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon;
using UnityEngine;

namespace Cutt
{
	public class CuttCharacterInitializer : MonoBehaviour
	{
		public enum CharacterId
		{
			Chara01,
			Chara02,
			Chara03,
			Chara04,
			Chara05,
			Chara06,
			Chara07,
			Chara08,
			Chara09,
			Chara10,
			Chara11,
			Chara12,
			Chara13,
			Chara14,
			Chara15,
			Chara16,
			Chara17,
			Chara18,
			Chara19,
			Chara20,
			Chara21,
			Chara22,
			Chara23,
			Chara24,
			Chara25,
			Chara26,
			Chara27,
			Chara28,
			Chara29,
			Chara30,
			Chara31,
			Chara32,
			EnumMax
		}

		public enum ChangeCharacterIndexType
		{
			None,
			Eight
		}

		public class SwapCharacterData
		{
			public int originalCharaIndex;

			public int setCharaIndex;

			public int setAnimeIndex;

			public void ResetValue()
			{
			}
		}

		public class SwapCharaLoadAnimData
		{
			public string animFolderPath;

			public string targetCharaId;

			public SwapCharaLoadAnimData(string path, string charaId)
			{
			}
		}

		public class SwapCharaRuntimeAnimData
		{
			public RuntimeAnimatorController originalData;

			public void SetRuntimeAnimCtrl(RuntimeAnimatorController data)
			{
			}

			public RuntimeAnimatorController GetRuntimeAnimCtrl()
			{
				return null;
			}
		}

		private enum PartyIndexForEight
		{
			None,
			Center,
			PartyA,
			PartyB,
			PartyC
		}

		private enum AnimationKindForEight
		{
			J,
			P,
			M,
			S,
			M_Center,
			EnumMax
		}

		[NonSerialized]
		public const int Max = 32;

		private List<string> replacePartyMotionCharaPrefabNameList;

		[SerializeField]
		public ChangeCharacterIndexType changeCharacterIndexType;

		[SerializeField]
		public CuttCharacterInitializeData[] initializeDataArray;

		[NonSerialized]
		public CuttCharacterController[] characterController;

		[SerializeField]
		public CuttFtuInitializeData[] ftuInitializeDataArray;

		[SerializeField]
		private string environmentMapAreaLabel;

		private CuttTimelineControl control;

		private bool isInitialized;

		private bool isPlayingInGame;

		private ShaderLodDataObject _shaderLodDataObject;

		private static readonly int ingamePartyIdMax;

		private static readonly int ingamePartyIdOffset;

		private Dictionary<CuttCharacterInitializeData.PartyCharacterType, SwapCharacterData> swapCharaTargetDataDict;

		private static readonly SwapCharaLoadAnimData[] swapCharaLoadAnimDataForEight;

		private static readonly AnimationKindForEight[] swapCharaPrioCharaForEight;

		private SwapCharaRuntimeAnimData[] loadedAnimArray;

		private CharacterBase[] swapCharaHumanDataArray;

		private CuttCharacterInitializeData[] currentInitDataArray;

		private string GetCuttName()
		{
			return null;
		}

		private string GetFolderPath()
		{
			return null;
		}

		private void Awake()
		{
		}

		public bool IsInitialized()
		{
			return default(bool);
		}

		public CuttCharacterController GetCharacterController(int index)
		{
			return null;
		}

		public RuntimeAnimatorController GetAnimController(int index)
		{
			return null;
		}

		public CuttTimelineCharacter[] ResetCharacterIndexAndAnimator(CuttTimelineCharacter[] tempArray)
		{
			return null;
		}

		public CuttCharacterInitializeData GetSwappedCharaInitData(CuttCharacterInitializeData.PartyCharacterType type)
		{
			return null;
		}

		public void Load(bool isPlayingInGame, GameObject canvasObject)
		{
		}

		public void OnChangeLightProbeParameter()
		{
		}

		private void ReplacePartyCharacter(CuttCharacterInitializeData initData)
		{
		}

		private CuttCharacterController LoadCharacter(CuttCharacterInitializeData initData, GameObject canvasObject, int index, [Optional] ShaderLodDataObject shaderLodDataObject)
		{
			return null;
		}

		private void OnDestroy()
		{
		}
	}
}
