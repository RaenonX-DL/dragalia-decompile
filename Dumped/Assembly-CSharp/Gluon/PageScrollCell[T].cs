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
	public class PageScrollCell<T> : MonoBehaviour
	{
		// Fields
		[HideInInspector]
		public RectTransform rectTransform;
		[CompilerGenerated]
		private int _dataIndex_k__BackingField;
	
		// Properties
		public int dataIndex { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public PageScrollCell();
	
		// Methods
		protected virtual void Awake();
		public virtual void UpdateContent(T itemData);
	}
}
