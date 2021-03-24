/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UiImageExchanger : MonoBehaviour
	{
		// Fields
		[SerializeField]
		protected Image targetImage;
		[SerializeField]
		protected Sprite[] exchangeSprites;
		[SerializeField]
		protected Material[] exchangeMaterials;
		[Header]
		[SerializeField]
		public IndexReceiveEvent indexGetter;
		[Header]
		[SerializeField]
		private bool isUseFooterMenuTabIndex;
		private IndexReceiver myIndexReceiver;
	
		// Nested types
		public class IndexReceiver
		{
			// Fields
			public int index;
	
			// Constructors
			public IndexReceiver();
		}
	
		[Serializable]
		public class IndexReceiveEvent : UnityEvent<IndexReceiver>
		{
			// Constructors
			public IndexReceiveEvent();
		}
	
		// Constructors
		public UiImageExchanger();
	
		// Methods
		private void Start();
		public virtual void SetImage(int index, bool isOverrideSprite = false);
	}
}
