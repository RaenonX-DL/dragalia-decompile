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
	public class DefenseEventTalkElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private DefenseEventWindowType _WindowType;
		[SerializeField]
		private DefenseEventIconType _IconType;
		[SerializeField]
		private string _IconName;
		[SerializeField]
		private int _QuestGroupId;
		[SerializeField]
		private int _QuestId;
		[SerializeField]
		private int _NextAreaMessage;
		[SerializeField]
		private string _Text;
	
		// Properties
		public int Id { get; }
		public DefenseEventWindowType WindowType { get; }
		public DefenseEventIconType IconType { get; }
		public string IconName { get; }
		public int QuestGroupId { get; }
		public int QuestId { get; }
		public int NextAreaMessage { get; }
		public string Text { get; }
	
		// Constructors
		public DefenseEventTalkElement();
	}
}
