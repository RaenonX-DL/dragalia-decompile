/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class HyperLinkText : UnityEngine.UI.Text, IPointerClickHandler
	{
		// Fields
		private List<StringSpan> stringSpanList;
		private List<StringEntry> stringEntryList;
		private UIVertex[] tempVerts;
		private List<UIVertex> vertexList;
		private int[] visibleCharIndexMaps;
		private Canvas rootCanvas;
		private const int charVertsNum = 6;
	
		// Constructors
		public HyperLinkText();
	
		// Methods
		public void AddHyperLinkClickEvent(string regexPattern, string colorCode, Action<string> onClick);
		private void AddEventListeners();
		public void RemoveEventListeners();
		protected void AddClickEvent(int startIndex, int length, Color textColor, Action<string> onStringClick);
		protected override void OnPopulateMesh(VertexHelper vh);
		private void HyperTextReferenceBoundingBoxes(ref List<UIVertex> vertexList);
		private List<Rect> CalculateBoundingBoxList(List<Rect> charBoundingBoxList);
		private Rect CalculateAxisAlignedBoundingBox(IReadOnlyList<Rect> rectList);
		void IPointerClickHandler.OnPointerClick(PointerEventData eventData);
		private Vector3 CalculateLocalPos(Vector3 pos, Camera camera);
	}
}
