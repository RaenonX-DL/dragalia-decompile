/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;
using UnityEngine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity
{
	public struct SubmeshInstruction
	{
		// Fields
		public Skeleton skeleton;
		public int startSlot;
		public int endSlot;
		public Material material;
		public bool forceSeparate;
		public int preActiveClippingSlotSource;
		public int rawTriangleCount;
		public int rawVertexCount;
		public int rawFirstVertexIndex;
		public bool hasClipping;
	
		// Properties
		public int SlotCount { get; }
	
		// Methods
		public override string ToString();
	}
}
