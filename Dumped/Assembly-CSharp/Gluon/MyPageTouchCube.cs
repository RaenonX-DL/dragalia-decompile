/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MyPageTouchCube : MonoBehaviour, IPointerDownHandler
	{
		// Fields
		public int myIndex;
		public MyPageTalkCanvas canvas;
		public MyPageScene scene;
		public Action extraEvent;
	
		// Constructors
		public MyPageTouchCube();
	
		// Methods
		public void OnPointerDown(PointerEventData eventData);
	}
}
