/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SupporterSkillCtrl
	{
		// Fields
		[CompilerGenerated]
		private State _state_k__BackingField;
		private Dictionary<int, TextData> textDic;
		private int _skillId;
		private NotifyCharacter.SkillCutInParam _skillCutInParam;
	
		// Properties
		public State state { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum State
		{
			None = 0,
			Active = 1
		}
	
		public class TextData
		{
			// Fields
			public int type;
			public string text;
	
			// Constructors
			public TextData();
	
			// Methods
			public void Clear();
		}
	
		// Constructors
		public SupporterSkillCtrl();
	
		// Methods
		public void Start();
		public void Update();
		public bool IsActive();
		public void EndProcess();
		public void SetText(int type, string text, int groupNo);
		private void DispText(TextData data, CharacterBase player);
		private void SetActivePlayer(bool isVisible);
	}
}
