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
	[ExecuteAlways]
	public class FortSortingOrderSetter : MonoBehaviour
	{
		// Fields
		private static readonly int[] orderTypeOrderNumArray;
		private static readonly int selectedObjectOrderNum;
		[SortingLayer]
		[SerializeField]
		private string layerName;
		[SerializeField]
		private int baseOrder;
		[SerializeField]
		private OrderType orderInLayer;
	
		// Properties
		public string LayerName { get; set; }
		public OrderType OrderInLayer { get; set; }
	
		// Nested types
		public enum OrderType
		{
			TransparentOnGround = 0,
			FacilityTurf = 1,
			FacilityBase = 2,
			FacilityBaseDecoration = 3,
			FacilityBaseFire = 4,
			FacilitySubLayerBack = 5,
			FacilitySubLayerMiddle = 6,
			FacilitySubLayerFront = 7,
			FacilitySphere = 8,
			FacilityProduct = 9,
			FacilityBalloon = 10,
			FrontEffect = 11,
			BackEffect = 12,
			OrderTypeNum = 13
		}
	
		private class SortingLayerAttribute : PropertyAttribute
		{
			// Constructors
			public SortingLayerAttribute();
		}
	
		// Constructors
		public FortSortingOrderSetter();
		static FortSortingOrderSetter();
	
		// Methods
		private void Awake();
		private void OnValidate();
		public static void SetSortingOrder(GameObject go, Vector2 gridPos);
		public static void UpdateSortingOrder(GameObject go);
		public void SetBaseOrder(Vector2 gridPos);
		public void SetSelectedBaseOrder(Vector2 gridPos);
		private void RefreshSortingOrder();
		private int GetGridBaseOrder(Vector2 gridPos);
	}
}
