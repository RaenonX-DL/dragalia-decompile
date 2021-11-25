using UnityEngine;

namespace Gluon
{
	[ExecuteAlways]
	public class FortSortingOrderSetter : MonoBehaviour
	{
		public enum OrderType
		{
			TransparentOnGround,
			FacilityTurf,
			FacilityBase,
			FacilityBaseDecoration,
			FacilityBaseFire,
			FacilitySubLayerBack,
			FacilitySubLayerMiddle,
			FacilitySubLayerFront,
			FacilitySphere,
			FacilityProduct,
			FacilityBalloon,
			FrontEffect,
			BackEffect,
			OrderTypeNum
		}

		private class SortingLayerAttribute : PropertyAttribute
		{
		}

		private static readonly int[] orderTypeOrderNumArray;

		private static readonly int selectedObjectOrderNum;

		[SerializeField]
		[SortingLayer]
		private string layerName;

		[SerializeField]
		private int baseOrder;

		[SerializeField]
		private OrderType orderInLayer;

		public string LayerName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public OrderType OrderInLayer
		{
			get
			{
				return default(OrderType);
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void OnValidate()
		{
		}

		public static void SetSortingOrder(GameObject go, Vector2 gridPos)
		{
		}

		public static void UpdateSortingOrder(GameObject go)
		{
		}

		public void SetBaseOrder(Vector2 gridPos)
		{
		}

		public void SetSelectedBaseOrder(Vector2 gridPos)
		{
		}

		private void RefreshSortingOrder()
		{
		}

		private int GetGridBaseOrder(Vector2 gridPos)
		{
			return default(int);
		}
	}
}
