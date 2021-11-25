using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("CRIWARE/CRI Atom Listener")]
public class CriAtomListener : MonoBehaviour
{
	public bool activateListenerOnEnable;

	private Vector3 lastPosition;

	public static CriAtomListener activeListener
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static CriAtomEx3dListener sharedNativeListener
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static void CreateSharedNativeListener()
	{
	}

	public static void DestroySharedNativeListener()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void LateUpdate()
	{
	}

	public void ActivateListener()
	{
	}
}
