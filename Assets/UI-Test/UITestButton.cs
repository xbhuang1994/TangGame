﻿///xbhuang
///小伙伴们，来点乐子吧！
using UnityEngine;
using System.Collections;
using PureMVC.Interfaces;
using PureMVC.Patterns;
using TangGame.Xml;

namespace TangGame
{
	public class UITestButton : MonoBehaviour
	{
		
		TangGame.Net.Npc npc = new TangGame.Net.Npc ();
		Task task = new Task ();
		// Use this for initialization
		void Start ()
		{
			
		}
		
		// Update is called once per frame
		void Update ()
		{
			
		}

//		void OnGUI ()
//		{
//			//TODO 应该去掉，测试代码
//			if (GUILayout.Button ("载入测试数据")) {
//				npc.id = 1002;
//				npc.name = "宇宙Super无敌";
//				npc.talk = "宇宙Super无敌之歌，在山的那边，海的那边有一群宇宙Super无敌~";
//				npc.helfLengthPhoto = "凌烟阁女";
//				ActorCache.AddOrUpdateActor (npc.id, npc);
//				task = Config.taskTable [10002];
//				TangGame.Net.HeroTask heroTask = new TangGame.Net.HeroTask();
//				heroTask.id = 10001;
//				heroTask.taskConfigId = 10001;
////				TaskCache.noTransferHasBeenCompletedTaskIds.Add(10001);
//				TaskCache.mayReceiveTaskIds.Add(10001);
//				TaskCache.heroTasks.Add(heroTask.id,heroTask);
//			}
//			
//		}
		
//		void OnGUI ()
//		{
//			//TODO 应该去掉，测试代码
//			if (GUILayout.Button ("send notification")) {
//				TangGame.Net.EquipUpgradeResult result = new TangGame.Net.EquipUpgradeResult();
//				result.goodsId = 5;
//				result.equipSite = 1;
//				PureMVC.Patterns.Facade.Instance.SendNotification(NotificationIDs.ID_ReSetRoleHeroEquipInSite,result);
//				PureMVC.Patterns.Facade.Instance.SendNotification(NotificationIDs.ID_ToMakeItemUpLevel,(long)result.goodsId);
//			}
//			
//		}
		void SayHello (object obj)
		{
			Debug.Log (obj.ToString ());
		}
	}
}