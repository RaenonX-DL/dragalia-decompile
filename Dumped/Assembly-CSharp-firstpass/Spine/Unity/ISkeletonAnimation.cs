/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine;

// Image 57: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Spine.Unity
{
	public interface ISkeletonAnimation
	{
		// Properties
		Skeleton Skeleton { get; }
	
		// Events
		event UpdateBonesDelegate UpdateLocal {
			add;
			remove;
		}
		event UpdateBonesDelegate UpdateWorld {
			add;
			remove;
		}
		event UpdateBonesDelegate UpdateComplete {
			add;
			remove;
		}
	}
}
