/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CtrlBoundaryAction : FastUpdateMonoBehaviour
	{
		// Fields
		private EnemyCharacter _owner;
		[CompilerGenerated]
		private readonly List<BoundaryData> _datas_k__BackingField;
		[CompilerGenerated]
		private BoundaryData _activeData_k__BackingField;
		[CompilerGenerated]
		private bool _isFinished_k__BackingField;
	
		// Properties
		public List<BoundaryData> datas { [CompilerGenerated] get; }
		public BoundaryData activeData { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isActiveAction { get; }
		public bool isFinished { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public class BoundaryData
		{
			// Fields
			public int _id;
			public int _hp;
			public int _actionId;
			public EnemyBoundaryCondition _condition;
			public bool _done;
	
			// Constructors
			public BoundaryData();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_0
		{
			// Fields
			public int point;
	
			// Constructors
			public __c__DisplayClass18_0();
	
			// Methods
			internal bool _CreateList_b__1(BoundaryData a);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass18_1
		{
			// Fields
			public int point;
	
			// Constructors
			public __c__DisplayClass18_1();
	
			// Methods
			internal bool _CreateList_b__2(BoundaryData a);
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static Comparison<BoundaryData> __9__18_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal int _CreateList_b__18_0(BoundaryData a, BoundaryData b);
		}
	
		// Constructors
		public CtrlBoundaryAction();
	
		// Methods
		public void Initialize(EnemyCharacter owner);
		public void Reset();
		public static bool IsExistBoundaryAction(EnemyCharacter owner);
		private void CreateList();
		public bool Check();
		public bool OnFatal(bool isQuestSkill);
		public void Execute();
		private bool IsSuperExtraAction();
		public void OnFinishAction();
		public void SetCondition(bool onoff);
		public void ActivateBoundaryData(int boundaryDataId);
		public override void FastUpdate();
	}
}
