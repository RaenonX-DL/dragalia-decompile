/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;

// Image 54: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity
{
	public class SkeletonRendererInstruction
	{
		// Fields
		public bool immutableTriangles;
		public readonly ExposedList<SubmeshInstruction> submeshInstructions;
		public bool hasActiveClipping;
		public int rawVertexCount;
		public readonly ExposedList<Attachment> attachments;
	
		// Constructors
		public SkeletonRendererInstruction();
	
		// Methods
		public void Clear();
		public void Dispose();
		public void SetWithSubset(ExposedList<SubmeshInstruction> instructions, int startSubmesh, int endSubmesh);
		public void Set(SkeletonRendererInstruction other);
		public static bool GeometryNotEqual(SkeletonRendererInstruction a, SkeletonRendererInstruction b);
	}
}
