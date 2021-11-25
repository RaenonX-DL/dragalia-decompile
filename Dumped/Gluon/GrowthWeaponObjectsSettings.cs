using UnityEngine;

namespace Gluon
{
	public class GrowthWeaponObjectsSettings : MonoBehaviour
	{
		[HideInInspector]
		public Vector3 render3dCameraPos;

		[HideInInspector]
		public Vector3 render3dCameraRot;

		[HideInInspector]
		public float render3dCameraFOV;

		[HideInInspector]
		public float render3dCameraNear;

		[HideInInspector]
		public float render3dCameraFar;

		[HideInInspector]
		public Vector3[] weaponPosList;

		[HideInInspector]
		public Vector3[] weaponRotList;

		[HideInInspector]
		public float[] weaponScaleList;

		[HideInInspector]
		public int specialWeaponDetailNum;

		[HideInInspector]
		public SpecialWeaponDetail[] specialWeaponDetail;

		[HideInInspector]
		public CraftEffectSceneBase crafctEffectScene;

		[HideInInspector]
		public GrowthUnitEnhanceScene growthUnitEnhanceScene;

		private void OnValidate()
		{
		}

		private void SetParameters()
		{
		}
	}
}
