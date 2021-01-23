/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class EnemyTalkDataElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _EnemyId;
		[SerializeField]
		private int _TalkId;
		[SerializeField]
		private EnemyTalkTrigger _Trigger;
		[SerializeField]
		private int _IntValue01;
	
		// Properties
		public int Id { get; }
		public int EnemyId { get; }
		public int TalkId { get; }
		public EnemyTalkTrigger Trigger { get; }
		public int IntValue01 { get; }
	
		// Constructors
		public EnemyTalkDataElement();
	}
}
