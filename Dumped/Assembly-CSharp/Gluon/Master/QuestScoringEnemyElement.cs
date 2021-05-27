/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class QuestScoringEnemyElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _ScoringEnemyGroupId;
		[SerializeField]
		private int _EnemyListId;
		[SerializeField]
		private int _Point;
		[SerializeField]
		private string _IconImage;
	
		// Properties
		public int Id { get; }
		public int ScoringEnemyGroupId { get; }
		public int EnemyListId { get; }
		public int Point { get; }
		public string IconImage { get; }
	
		// Constructors
		public QuestScoringEnemyElement();
	}
}
