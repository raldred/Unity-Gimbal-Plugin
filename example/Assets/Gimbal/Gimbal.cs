﻿using UnityEngine;
using System.Runtime.InteropServices;

public class Gimbal {
	public static void SetApiKey(string apiKey) {
		Debug.Log("unity set api key: " + apiKey);
		setApiKey(apiKey);
	}

	public static void StartBeaconManager() {
		Debug.Log("unity started listening");
		startBeaconManager();
	}

	public static void StopBeaconManager() {
		Debug.Log("unity stopped listening");
		stopBeaconManager();
	}

	public static void StartPlaceManager() {
		Debug.Log("unity started listening for places");
		startPlaceManager();
	}

	public static void StopPlaceManager() {
		Debug.Log("unity stopped listening for places");
		stopPlaceManager();
	}

	public static bool IsMoitoring() {
		Debug.Log("unity asking for monitoring state");
		return isMonitoring();
	}

#if UNITY_IPHONE
	[DllImport ("__Internal")]
	private static extern void setApiKey(string apiKey);

	[DllImport ("__Internal")]
	private static extern void startBeaconManager();

	[DllImport ("__Internal")]
	private static extern void stopBeaconManager();

	[DllImport ("__Internal")]
	private static extern void startPlaceManager();

	[DllImport ("__Internal")]
	private static extern void stopPlaceManager();
		
	[DllImport ("__Internal")]
	private static extern bool isMonitoring();
#elif UNITY_ANDROID
	[DllImport("gimbalunitybridge")]
	private static extern void setApiKey(string apiKey);
	
	[DllImport("gimbalunitybridge")]
	private static extern void startBeaconManager();
	
	[DllImport("gimbalunitybridge")]
	private static extern void stopBeaconManager();
	
	[DllImport("gimbalunitybridge")]
	private static extern void startPlaceManager();
	
	[DllImport("gimbalunitybridge")]
	private static extern void stopPlaceManager();
#endif
}
