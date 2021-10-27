/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Event;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CTSUniqueCtrl : EnemyUniqueCtrl
	{
		// Fields
		private PatternType _pattern;
		private List<ShapeType> _listAnswer;
		private bool _hasSetup;
		private bool _isValid;
		private int _answerIdx;
		[CompilerGenerated]
		private List<ShapeType> _ReservedSubDeads_k__BackingField;
		private List<CTSUniqueCtrlForSub> _sametimeDeadCtrlForSubs;
		private int[,] _patternTable;
	
		// Properties
		public List<ShapeType> ReservedSubDeads { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		public enum ShapeType
		{
			Circle = 0,
			Triangle = 1,
			Square = 2
		}
	
		public enum PatternType
		{
			None = 0,
			C_T_S = 1,
			C_S_T = 2,
			T_S_C = 3,
			T_C_S = 4,
			S_C_T = 5,
			S_T_C = 6
		}
	
		// Constructors
		public CTSUniqueCtrl();
	
		// Methods
		public void ResetInfo();
		public void Setup(PatternType pattern);
		private void Update();
		public bool OnSubDead(CTSUniqueCtrlForSub ctrlSub, ShapeType shape);
		public void SendCTSSubDead(ShapeType shape);
		public void SendCTSIncorrect(List<CTSUniqueCtrlForSub> targets);
		public override void OnReceiveCharacterSpecialState(CharacterSpecialState recvEvent);
	}
}
