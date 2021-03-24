/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine
{
	public class IkConstraintData
	{
		// Fields
		internal string name;
		internal int order;
		internal List<BoneData> bones;
		internal BoneData target;
		internal int bendDirection;
		internal float mix;
	
		// Properties
		public string Name { get; }
		public int Order { get; set; }
		public List<BoneData> Bones { get; }
		public BoneData Target { get; set; }
		public int BendDirection { get; set; }
		public float Mix { get; set; }
	
		// Constructors
		public IkConstraintData(string name);
	
		// Methods
		public override string ToString();
	}
}
