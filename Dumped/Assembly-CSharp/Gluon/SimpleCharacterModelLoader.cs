/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SimpleCharacterModelLoader : SingletonInBaseMonoBehaviour<Gluon.SimpleCharacterModelLoader>
	{
		// Fields
		private Dictionary<string, GameObject> characterDict;
		private Dictionary<string, GameObject> weaponDict;
		private Dictionary<string, GameObject> weaponRichDict;
		private GameObject projectionShasowAsset;
		private GameObject quadShadowAsset;
		private readonly Vector3 characterInitPosition;
		private RichController _richController;
	
		// Nested types
		public enum OutGameScene
		{
			MyPage = 0,
			EquipWeapon = 1,
			Other = 2,
			Max = 3
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass12_0
		{
			// Fields
			public SimpleCharacterModelLoader __4__this;
			public GameObject character;
			public int charaId;
			public string modelName;
			public Renderer[] renderers;
			public bool useLightProbe;
			public OutGameScene scene;
			public Action<GameObject> onCompleteAction;
	
			// Constructors
			public __c__DisplayClass12_0();
	
			// Methods
			internal void _CreateSimpleCharacterModelAsync_b__0(UnityEngine.Object asset);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public float shadowScale;
			public SimpleCharacterModel.ShadowCastMethod shadowCastMethod;
			public int charaId;
			public SimpleCharacterModelLoader __4__this;
			public float shadowCastMargin;
			public int drawLayer;
			public int weaponSkinId;
			public bool useLightProbe;
			public Action<GameObject> onCompleteAction;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal void _CreateCharacterModelAsync_b__0(GameObject character);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_0
		{
			// Fields
			public SimpleCharacterModelLoader __4__this;
			public GameObject weaponObj;
	
			// Constructors
			public __c__DisplayClass22_0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass22_1
		{
			// Fields
			public SimpleCharacterModel model;
			public __c__DisplayClass22_0 CS___8__locals1;
	
			// Constructors
			public __c__DisplayClass22_1();
	
			// Methods
			internal void _AttachWeaponToCharacter_b__0();
			internal void _AttachWeaponToCharacter_b__1();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass24_0
		{
			// Fields
			public Transform attachNode;
			public bool useLightProbe;
			public int drawLayer;
			public Action<GameObject> onCompleted;
	
			// Constructors
			public __c__DisplayClass24_0();
	
			// Methods
			internal void _AttachWeaponAsync_b__0(GameObject weaponObject);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0
		{
			// Fields
			public Action<GameObject> onCompleted;
			public SimpleCharacterModelLoader __4__this;
			public string path;
			public int baseId;
			public int variationId;
	
			// Constructors
			public __c__DisplayClass29_0();
	
			// Methods
			internal void _LoadWeaponAsync_b__0(GameObject obj);
		}
	
		// Constructors
		public SimpleCharacterModelLoader();
	
		// Methods
		public void ClearCacheAndReleaseMemory();
		public static float GetBaseScale(int charaId);
		private void LoadRichModel(GameObject characterObject, string modelName);
		public GameObject CreateSimpleCharacterModel(string modelName, int charaId, bool useLightProbe, OutGameScene scene);
		public void CreateSimpleCharacterModelAsync(string modelName, int charaId, bool useLightProbe, OutGameScene scene, Action<GameObject> onCompleteAction);
		public GameObject CreateNoCacheSimpleCharacterModel(string modelName, int charaId, bool useLightProbe, OutGameScene scene);
		public GameObject CreateSimpleCharacterModel(int charaId, bool useLightProbe, OutGameScene scene, bool noCacheModel = false);
		public static void ReplicateMaterialForLightProbe(GameObject obj);
		public void CreateSimpleCharacterModelAsync(int charaId, bool useLightProbe, OutGameScene scene, Action<GameObject> onCompleteAction);
		public GameObject CreateCharacterModel(int charaId, int weaponSkinId, float shadowCastMargin, float shadowScale, bool useLightProbe, OutGameScene scene, bool noCacheModel = false);
		public void CreateCharacterModelAsync(int charaId, int weaponSkinId, SimpleCharacterModel.ShadowCastMethod shadowCastMethod, float shadowCastMargin, float shadowScale, bool useLightProbe, OutGameScene scene, Action<GameObject> onCompleteAction, int drawLayer);
		public Projector AttachShadowToCharacter(GameObject character, float castMargin, float shadowScale, int drawLayer, float charaScale);
		public GameObject AttachQuadShadowToCharacter(GameObject character, float shadowScale, int drawLayer);
		private GameObject GetShadowAsset(SimpleCharacterModel.ShadowCastMethod shadowCastMethod);
		public GameObject AttachWeaponToCharacter(GameObject character, int weaponSkinId, bool useLightProbe, int drawLayer);
		private GameObject AttachWeapon(GameObject character, int baseId, int variationId, Transform attachNode, bool useLightProbe, int drawLayer);
		private void AttachWeaponAsync(GameObject character, int baseId, int variationId, Transform attachNode, bool useLightProbe, Action<GameObject> onCompleted, int drawLayer);
		private void ChangeWeaponHand(GameObject weaponObject, Transform attachNode);
		public static int GetSpecialWeaponId(int charaId);
		public int GetDefaultWeaponId(int charaId);
		public GameObject LoadWeapon(int baseId, int variationId);
		public void LoadWeaponAsync(int baseId, int variationId, Action<GameObject> onCompleted);
		public static void DoSomethingForSpecificWeapon(int baseId, int variationId, GameObject weaponObject);
		public void SetCharacterColor(GameObject character, Color color);
		public void SetCharacterDefaultFacialAnimation(GameObject character);
		public Animator CreateCharacterAnimator(GameObject character, int charaId);
		public static string GetPartyCharacterAnimatorDir(bool isQuestPrepare = false);
		public Animator CreatePartyCharacterAnimator(GameObject character, int charaId, WeaponType weaponType = WeaponType.NONE, int motionType = -1);
		public EnemyCharacter CreateMonsterModel(int showMonsterId, int actionId);
		private void Start();
		public EnemyCharacter CreateMonsterModel(int showMonsterId);
		public static string GetNhaamModelName(int variationId, bool isHighModel = false);
		public static int GetNhaamVariationId();
		public static void SwitchModelParts(GameObject character, OutGameScene scene);
		private string GetModelPath(string modelName, bool isRich = false);
	}
}
