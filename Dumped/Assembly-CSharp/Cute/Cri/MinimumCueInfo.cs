/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cute.Cri.Audio;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Cri
{
	public class MinimumCueInfo : IDisposable
	{
		// Fields
		private GCHandle gch;
		private byte[] bytes;
		[CompilerGenerated]
		private string _Name_k__BackingField;
		[CompilerGenerated]
		private int _Id_k__BackingField;
		[CompilerGenerated]
		private float _MinDistance_k__BackingField;
		[CompilerGenerated]
		private float _MaxDistance_k__BackingField;
	
		// Properties
		private IntPtr ptr { get; }
		public string Name { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int Id { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float MinDistance { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public float MaxDistance { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public MinimumCueInfo();
	
		// Methods
		private static extern bool criAtomExAcb_GetCueInfoByName(IntPtr acb_hn, string name, IntPtr info);
		private static extern bool criAtomExAcb_GetCueInfoById(IntPtr acb_hn, int id, IntPtr info);
		public void Dispose();
		public bool AnalyzeCueInfo(CriAtomExAcb acb, RequestCueInfo requestCueInfo);
	}
}
