using System;
using System.Collections.Generic;
using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon
{
	public class SimpleCharacterModelLoader : SingletonInBaseMonoBehaviour<SimpleCharacterModelLoader>
	{
		public enum OutGameScene
		{
			MyPage,
			EquipWeapon,
			Other,
			SummonB,
			Max
		}

		private Dictionary<string, GameObject> characterDict;

		private Dictionary<string, GameObject> weaponDict;

		private Dictionary<string, GameObject> weaponRichDict;

		private GameObject projectionShasowAsset;

		private GameObject quadShadowAsset;

		private readonly Vector3 characterInitPosition;

		private RichController _richController;

		public void ClearCacheAndReleaseMemory()
		{
		}

		public static float GetBaseScale(int charaId)
		{
			return default(float);
		}

		private void LoadRichModel(GameObject characterObject, string modelName)
		{
		}

		public GameObject CreateSimpleCharacterModel(string modelName, int charaId, bool useLightProbe, OutGameScene scene)
		{
			return null;
		}

		public void CreateSimpleCharacterModelAsync(string modelName, int charaId, bool useLightProbe, OutGameScene scene, Action<GameObject> onCompleteAction)
		{
		}

		public GameObject CreateNoCacheSimpleCharacterModel(string modelName, int charaId, bool useLightProbe, OutGameScene scene)
		{
			return null;
		}

		public GameObject CreateSimpleCharacterModel(int charaId, bool useLightProbe, OutGameScene scene, bool noCacheModel = false)
		{
			return null;
		}

		public static void ReplicateMaterialForLightProbe(GameObject obj)
		{
		}

		public void CreateSimpleCharacterModelAsync(int charaId, bool useLightProbe, OutGameScene scene, Action<GameObject> onCompleteAction)
		{
		}

		public GameObject CreateCharacterModel(int charaId, int weaponSkinId, float shadowCastMargin, float shadowScale, bool useLightProbe, OutGameScene scene, bool noCacheModel = false)
		{
			return null;
		}

		public void CreateCharacterModelAsync(int charaId, int weaponSkinId, SimpleCharacterModel.ShadowCastMethod shadowCastMethod, float shadowCastMargin, float shadowScale, bool useLightProbe, OutGameScene scene, Action<GameObject> onCompleteAction, int drawLayer)
		{
		}

		public Projector AttachShadowToCharacter(GameObject character, float castMargin, float shadowScale, int drawLayer, float charaScale)
		{
			return null;
		}

		public GameObject AttachQuadShadowToCharacter(GameObject character, float shadowScale, int drawLayer)
		{
			return null;
		}

		private GameObject GetShadowAsset(SimpleCharacterModel.ShadowCastMethod shadowCastMethod)
		{
			return null;
		}

		public GameObject AttachWeaponToCharacter(GameObject character, int charaId, int weaponSkinId, bool useLightProbe, int drawLayer)
		{
			return null;
		}

		private GameObject AttachWeapon(GameObject character, int baseId, int variationId, Transform attachNode, bool useLightProbe, int drawLayer)
		{
			return null;
		}

		private void AttachWeaponAsync(GameObject character, int baseId, int variationId, Transform attachNode, bool useLightProbe, Action<GameObject> onCompleted, int drawLayer)
		{
		}

		private void ChangeWeaponHand(GameObject weaponObject, Transform attachNode)
		{
		}

		public static int GetSpecialWeaponId(int charaId)
		{
			return default(int);
		}

		public int GetDefaultWeaponId(int charaId)
		{
			return default(int);
		}

		public GameObject LoadWeapon(int baseId, int variationId)
		{
			return null;
		}

		public void LoadWeaponAsync(int baseId, int variationId, Action<GameObject> onCompleted)
		{
		}

		public static void DoSomethingForSpecificWeapon(int baseId, int variationId, GameObject weaponObject)
		{
		}

		public void SetCharacterColor(GameObject character, Color color)
		{
		}

		public void SetCharacterDefaultFacialAnimation(GameObject character)
		{
		}

		public Animator CreateCharacterAnimator(GameObject character, int charaId)
		{
			return null;
		}

		public static string GetPartyCharacterAnimatorDir(bool isQuestPrepare = false)
		{
			return null;
		}

		public Animator CreatePartyCharacterAnimator(GameObject character, int charaId, WeaponType weaponType = WeaponType.NONE, int motionType = -1)
		{
			return null;
		}

		public EnemyCharacter CreateMonsterModel(int showMonsterId, int actionId)
		{
			return null;
		}

		private void Start()
		{
		}

		public EnemyCharacter CreateMonsterModel(int showMonsterId)
		{
			return null;
		}

		public static string GetNhaamModelName(int variationId, bool isHighModel = false)
		{
			return null;
		}

		public static int GetNhaamVariationId()
		{
			return default(int);
		}

		public static void SwitchModelParts(GameObject character, OutGameScene scene)
		{
		}

		public static void SwitchModelParts(GameObject characterModelObj, RenderPartsData.PartsNo changePartsNo, bool isSwitchTexture)
		{
		}

		public static void SwitchModelTexture(GameObject characterModelObj, RenderPartsData.PartsNo changePartsNo)
		{
		}

		public static void SwitchModelTexture(GameObject characterModelObj, RenderPartsData.PartsNo changePartsNo, MaterialPropertyBlock defaultMpb)
		{
		}

		private static MaterialPropertyBlock GetRenderPartsMaterialPropertyBlock(GameObject characterObj, string partsName)
		{
			return null;
		}

		private string GetModelPath(string modelName, bool isRich = false)
		{
			return null;
		}
	}
}
