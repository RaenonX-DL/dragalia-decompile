/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterSwitchingTexture : MonoBehaviour
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private string[] _switchPartsNames;
		[SerializeField]
		[Tooltip]
		private string _propertyMainTexName;
		[SerializeField]
		[Tooltip]
		private string _propertySubTexName;
		[SerializeField]
		[Tooltip]
		private SwitchData[] _switchData;
		private int _propertyMainTexID;
		private int _propertyMainTexSTID;
		private int _propertySubTexID;
		private float _fadeRatio;
		private int _fadeStartIndex;
		private int _fadeEndIndex;
		private CharacterBase _owner;
		private float _duration;
		private float _time;
		private IEnumerator coSwitingTexture;
	
		// Properties
		public SwitchData[] switchData { get; }
	
		// Nested types
		[Serializable]
		public class SwitchData
		{
			// Fields
			[Tooltip]
			public Texture2D texture;
			[Tooltip]
			public Vector2 scale;
			[Tooltip]
			public Vector2 offset;
	
			// Constructors
			public SwitchData();
		}
	
		[CompilerGenerated]
		private sealed class _CoSwitingTexture_d__19 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public CharacterSwitchingTexture __4__this;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _CoSwitingTexture_d__19(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public CharacterSwitchingTexture();
	
		// Methods
		private void Start();
		public void Play(int start_idx, int end_idx, float duration);
		[IteratorStateMachine]
		private IEnumerator CoSwitingTexture();
		public void Stop();
		private void Finish();
	}
}
