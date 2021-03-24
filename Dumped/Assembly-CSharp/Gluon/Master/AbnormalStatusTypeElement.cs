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
	public class AbnormalStatusTypeElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _AbnormalName;
		[SerializeField]
		private int _IsViewDetail;
		[SerializeField]
		private int _SortId;
		[SerializeField]
		private int _Group;
		[SerializeField]
		private int _Priority;
		[SerializeField]
		private int _ResistGain;
		[SerializeField]
		private int _DisplayPriority;
	
		// Properties
		public int Id { get; }
		public string AbnormalName { get; }
		public int IsViewDetail { get; }
		public int SortId { get; }
		public int Group { get; }
		public int Priority { get; }
		public int ResistGain { get; }
		public int DisplayPriority { get; }
	
		// Constructors
		public AbnormalStatusTypeElement();
	}
}
