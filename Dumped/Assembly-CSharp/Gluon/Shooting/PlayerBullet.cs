/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	public class PlayerBullet : BaseObject
	{
		// Fields
		private int level;
		private float xplus;
		private float yplus;
		private float r;
		private PlayerBulletTemplate template;
		[CompilerGenerated]
		private float _power_k__BackingField;
		[CompilerGenerated]
		private bool _able_k__BackingField;
		private const int fadeOutTime = 32;
		private Phase phase;
	
		// Properties
		public float power { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool able { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public enum Phase
		{
			Normal = 0,
			FadeOut = 1
		}
	
		// Constructors
		public PlayerBullet();
	
		// Methods
		public void Action();
		private void UpdateFrame();
		public void HitOn();
		public bool IsInRange(float aimx, float aimy, float w, float h);
		public void SetSortingOrder(int z);
		public bool ValueSet(int index, float xOffset, float yOffset, int angle, float speed, float power, PlayerBulletTemplate _template, int delayIndex);
	}
}
