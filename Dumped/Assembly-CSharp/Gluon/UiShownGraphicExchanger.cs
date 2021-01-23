/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UiShownGraphicExchanger : MonoBehaviour
	{
		// Fields
		[SerializeField]
		protected ShownGraphicGroup[] targetGroups;
		[SerializeField]
		private float crossFadingDuration;
	
		// Nested types
		[Serializable]
		public struct ShownGraphicGroup
		{
			// Fields
			public Graphic[] members;
			public bool isActiveOnStart;
		}
	
		// Constructors
		public UiShownGraphicExchanger();
	
		// Methods
		private void Start();
		private void SetGraphicGroupMembersActive(ShownGraphicGroup group, bool isActive);
		private void SetGraphicGroupMembersCrossFading(ShownGraphicGroup group, float targetAlpha, float duration);
		public void ExchangeShownGrapic(int fromIndex, int toIndex, bool isCrossfading);
		public void SetText(int index, string text);
	}
}
