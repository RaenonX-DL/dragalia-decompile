/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UIDragAndFollowTarget : FastUpdateMonoBehaviour, IDragHandler
	{
		// Fields
		private RectTransform rectTransform;
		[SerializeField]
		private Transform target;
		[SerializeField]
		private Canvas canvas;
		private RectTransform canvasRectTransformCache;
	
		// Constructors
		public UIDragAndFollowTarget();
	
		// Methods
		private void Awake();
		void IDragHandler.OnDrag(PointerEventData ev);
		private void Update();
	}
}
