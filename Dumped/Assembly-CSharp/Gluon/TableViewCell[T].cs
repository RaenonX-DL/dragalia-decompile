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
	[RequireComponent]
	public class TableViewCell<T> : MonoBehaviour
	{
		// Fields
		[HideInInspector]
		public RectTransform rectTransform;
		protected T itemData;
		[CompilerGenerated]
		private int _dataIndex_k__BackingField;
	
		// Properties
		public int dataIndex { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float height { get; set; }
		public Vector2 top { get; set; }
		public Vector2 bottom { get; set; }
	
		// Constructors
		public TableViewCell();
	
		// Methods
		protected virtual void Awake();
		public virtual void UpdateContent(T itemData);
	}
}
