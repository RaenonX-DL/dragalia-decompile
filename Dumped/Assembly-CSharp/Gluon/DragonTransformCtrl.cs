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
	public class DragonTransformCtrl : MonoBehaviour
	{
		// Fields
		[CompilerGenerated]
		private State _state_k__BackingField;
		private TransformType transformType;
		private PlayerCtrl player;
		private float elapsedTime;
		public static readonly float forceChangeSec;
		private List<CharacterBase> transformNgCharaList;
	
		// Properties
		public State state { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum State
		{
			None = 0,
			Start = 1,
			End = 2
		}
	
		public enum TransformType
		{
			None = 0,
			Dragon = 1,
			Unique = 2
		}
	
		// Constructors
		public DragonTransformCtrl();
		static DragonTransformCtrl();
	
		// Methods
		public void SetTransformNgChara(CharacterBase chara, bool ngFlag);
		public bool CheckTransformNgChara(CharacterBase chara);
		private void Awake();
		private void Update();
		public void SetPlayer(PlayerCtrl player);
		public void StartActive(PlayerCtrl player, TransformType type);
		public void SetStateEnd();
		public bool IsActive();
	}
}
