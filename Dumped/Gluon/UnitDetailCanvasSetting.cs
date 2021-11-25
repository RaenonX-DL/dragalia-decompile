using System;
using UnityEngine;

namespace Gluon
{
	public class UnitDetailCanvasSetting : MonoBehaviour
	{
		[Serializable]
		public struct BgTransform
		{
			public Vector3 position;

			public Vector3 rotation;

			public Vector3 scale;
		}

		public enum ProjectionEnum
		{
			Perstictive,
			Orthographic
		}

		public enum DragonType
		{
			Dragon,
			Human,
			Other
		}

		public enum UnitType
		{
			Character,
			Dragon,
			HumanDragon,
			OtherDragon,
			Weapon,
			EnumMax
		}

		[HideInInspector]
		public float viewer2DMaxZoom;

		[HideInInspector]
		public float viewer2DMinZoom;

		[HideInInspector]
		public Vector3[] weaponDetailPos;

		[HideInInspector]
		public float[] weaponDetailZoom;

		[HideInInspector]
		public Vector3[] weaponDetailRotation;

		[HideInInspector]
		public int specialWeaponDetailNum;

		[HideInInspector]
		public SpecialWeaponDetail[] specialWeaponDetail;

		[HideInInspector]
		public Vector3 charaDetailPos;

		[HideInInspector]
		public float charaDetailZoom;

		[HideInInspector]
		public Vector3 charaDetailRotation;

		[HideInInspector]
		public float charaMaxZoom;

		[HideInInspector]
		public float charaMinZoom;

		[HideInInspector]
		public float charaZoomSpeed;

		[HideInInspector]
		public float charaRotateSpeed;

		[HideInInspector]
		public Vector3[] dragonsDetailPos;

		[HideInInspector]
		public float[] dragonsDetailZoom;

		[HideInInspector]
		public Vector3[] dragonsDetailRotation;

		[HideInInspector]
		public float[] dragonsMaxZoom;

		[HideInInspector]
		public float[] dragonsMinZoom;

		[HideInInspector]
		public float[] dragonsZoomSpeed;

		[HideInInspector]
		public float[] dragonsRotateSpeed;

		[HideInInspector]
		public float weaponMaxZoom;

		[HideInInspector]
		public float weaponMinZoom;

		[HideInInspector]
		public float weaponZoomSpeed;

		[HideInInspector]
		public float weaponRotateSpeed;

		[SerializeField]
		[Header("RenderCameraOffset")]
		public Vector3 charaRenderCameraPosition;

		public Vector3 charaRenderCameraRotation;

		public Vector3 weaponRenderCameraPosition;

		[HideInInspector]
		public float[] renderCameraFieldOfView;

		[HideInInspector]
		public Vector2[] renderCameraClippingPlanes;

		[HideInInspector]
		public ProjectionEnum[] renderCameraProjection;

		[HideInInspector]
		public BgTransform[] bgTransformList;

		[HideInInspector]
		public UnitDetailScene unitDetail;

		[HideInInspector]
		public bool isShowViewer;

		public void SetPos()
		{
		}

		private void OnValidate()
		{
		}
	}
}
