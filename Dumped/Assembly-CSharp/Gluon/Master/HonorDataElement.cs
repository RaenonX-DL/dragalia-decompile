/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class HonorDataElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private string _HonorName;
		[SerializeField]
		private string _Description;
		[SerializeField]
		private int _SortId;
		[SerializeField]
		private MissionTransportType _HonorTransportType;
		[SerializeField]
		private int _TransportValue;
		[SerializeField]
		private string _StartDate;
		[SerializeField]
		private string _EndDate;
	
		// Properties
		public int Id { get; }
		public string HonorName { get; }
		public string Description { get; }
		public int SortId { get; }
		public MissionTransportType HonorTransportType { get; }
		public int TransportValue { get; }
		public string StartDate { get; }
		public string EndDate { get; }
	
		// Constructors
		public HonorDataElement();
	}
}
