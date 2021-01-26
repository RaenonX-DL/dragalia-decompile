/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public abstract class SimpleCharacterFacialControlBase : SimpleCharacterFacialControlInterface
	{
		// Fields
		private bool isEnable;
		protected List<Material> materialList;
		[CompilerGenerated]
		private Vector2 _defaultOffset_k__BackingField;
		[CompilerGenerated]
		private Vector2 _currentOffset_k__BackingField;
	
		// Properties
		protected Vector2 defaultOffset { [CompilerGenerated] get; [CompilerGenerated] private set; }
		protected Vector2 currentOffset { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		protected SimpleCharacterFacialControlBase();
	
		// Methods
		public void Setup(List<Material> materialList);
		public void SetEnable(bool enable);
		public bool GetEnable();
		protected void ApplyOffset();
		public void LateUpdate();
		public void SetTrigger(string triggerName);
		protected abstract void OnSetup(out Vector2 defaultTextureOffset);
		protected abstract bool OnLateUpdate(out Vector2 outTextureOffset);
		protected virtual void OnTrigger(string triggerName);
		public virtual void SetFaceEye(CharaFaceEye faceEye);
		public virtual void SetFaceMouth(CharaFaceMouth faceMouth);
	}
}
