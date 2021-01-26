/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UnitDetailCanvasSetting : MonoBehaviour
	{
		// Fields
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
		[SerializeField]
		public const int specialWeaponDetailNum = 1;
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
		[Header]
		[SerializeField]
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
	
		// Nested types
		[Serializable]
		public struct BgTransform
		{
			// Fields
			public Vector3 position;
			public Vector3 rotation;
			public Vector3 scale;
		}
	
		public enum ProjectionEnum
		{
			Perstictive = 0,
			Orthographic = 1
		}
	
		public enum DragonType
		{
			Dragon = 0,
			Human = 1,
			Other = 2
		}
	
		public enum UnitType
		{
			Character = 0,
			Dragon = 1,
			HumanDragon = 2,
			OtherDragon = 3,
			Weapon = 4,
			EnumMax = 5
		}
	
		// Constructors
		public UnitDetailCanvasSetting();
	
		// Methods
		public void SetPos();
		private void OnValidate();
	}
}
