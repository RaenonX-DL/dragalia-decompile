using System;
using UnityEngine;

public class CriAtomServer : MonoBehaviour
{
	private static CriAtomServer _instance;

	public Action<bool> onApplicationPausePreProcess;

	public Action<bool> onApplicationPausePostProcess;

	public static CriAtomServer instance => null;

	public static void CreateInstance()
	{
	}

	public static void DestroyInstance()
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnApplicationPause(bool appPause)
	{
	}

	private void ProcessApplicationPause(bool appPause)
	{
	}
}
