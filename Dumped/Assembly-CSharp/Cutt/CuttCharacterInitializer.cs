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
	public class CuttCharacterInitializer : MonoBehaviour
	{
		// Fields
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
	
		// Nested types
		public enum CharacterId
		{
			Chara01 = 0,
			Chara02 = 1,
			Chara03 = 2,
			Chara04 = 3,
			Chara05 = 4,
			Chara06 = 5,
			Chara07 = 6,
			Chara08 = 7,
			Chara09 = 8,
			Chara10 = 9,
			Chara11 = 10,
			Chara12 = 11,
			Chara13 = 12,
			Chara14 = 13,
			Chara15 = 14,
			Chara16 = 15,
			Chara17 = 16,
			Chara18 = 17,
			Chara19 = 18,
			Chara20 = 19,
			Chara21 = 20,
			Chara22 = 21,
			Chara23 = 22,
			Chara24 = 23,
			Chara25 = 24,
			Chara26 = 25,
			Chara27 = 26,
			Chara28 = 27,
			Chara29 = 28,
			Chara30 = 29,
			Chara31 = 30,
			Chara32 = 31,
			EnumMax = 32
		}
	
		public enum ChangeCharacterIndexType
		{
			None = 0,
			Eight = 1
		}
	
		public class SwapCharacterData
		{
			// Fields
			public int originalCharaIndex;
			public int setCharaIndex;
			public int setAnimeIndex;
	
			// Constructors
			public SwapCharacterData();
	
			// Methods
			public void ResetValue();
		}
	
		public class SwapCharaLoadAnimData
		{
			// Fields
			public string animFolderPath;
			public string targetCharaId;
	
			// Constructors
			public SwapCharaLoadAnimData(string path, string charaId);
		}
	
		public class SwapCharaRuntimeAnimData
		{
			// Fields
			public RuntimeAnimatorController originalData;
	
			// Constructors
			public SwapCharaRuntimeAnimData();
	
			// Methods
			public void SetRuntimeAnimCtrl(RuntimeAnimatorController data);
			public RuntimeAnimatorController GetRuntimeAnimCtrl();
		}
	
		private enum PartyIndexForEight
		{
			None = 0,
			Center = 1,
			PartyA = 2,
			PartyB = 3,
			PartyC = 4
		}
	
		private enum AnimationKindForEight
		{
			J = 0,
			P = 1,
			M = 2,
			S = 3,
			M_Center = 4,
			EnumMax = 5
		}
	
		// Constructors
		public CuttCharacterInitializer();
		static CuttCharacterInitializer();
	
		// Methods
		private string GetCuttName();
		private string GetFolderPath();
		private void Awake();
		public bool IsInitialized();
		public CuttCharacterController GetCharacterController(int index);
		public RuntimeAnimatorController GetAnimController(int index);
		public CuttTimelineCharacter[] ResetCharacterIndexAndAnimator(CuttTimelineCharacter[] tempArray);
		public CuttCharacterInitializeData GetSwappedCharaInitData(CuttCharacterInitializeData.PartyCharacterType type);
		public void Load(bool isPlayingInGame, GameObject canvasObject);
		public void OnChangeLightProbeParameter();
		private void ReplacePartyCharacter(CuttCharacterInitializeData initData);
		private CuttCharacterController LoadCharacter(CuttCharacterInitializeData initData, GameObject canvasObject, int index, ShaderLodDataObject shaderLodDataObject = null);
		private void OnDestroy();
	}
}
