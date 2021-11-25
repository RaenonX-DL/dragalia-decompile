using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gluon
{
	public class HyperLinkText : Text, IPointerClickHandler, IEventSystemHandler
	{
		private List<StringSpan> stringSpanList;

		private List<StringEntry> stringEntryList;

		private UIVertex[] tempVerts;

		private List<UIVertex> vertexList;

		private int[] visibleCharIndexMaps;

		private Canvas rootCanvas;

		private const int charVertsNum = 6;

		public void AddHyperLinkClickEvent(string regexPattern, string colorCode, Action<string> onClick)
		{
		}

		private void AddEventListeners()
		{
		}

		public void RemoveEventListeners()
		{
		}

		protected void AddClickEvent(int startIndex, int length, Color textColor, Action<string> onStringClick)
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		private void HyperTextReferenceBoundingBoxes(ref List<UIVertex> vertexList)
		{
		}

		private List<Rect> CalculateBoundingBoxList(List<Rect> charBoundingBoxList)
		{
			return null;
		}

		private Rect CalculateAxisAlignedBoundingBox(IReadOnlyList<Rect> rectList)
		{
			return default(Rect);
		}

		void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
		{
		}

		private Vector3 CalculateLocalPos(Vector3 pos, Camera camera)
		{
			return default(Vector3);
		}
	}
}
