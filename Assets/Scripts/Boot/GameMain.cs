using Agate.MVC.Base;
using Agate.MVC.Core;
using ExampleGame.Module.SaveData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace ExampleGame.Boot
{
    public class GameMain : BaseMain<GameMain>, IMain
    {

        protected override IConnector[] GetConnectors()
        {
            return null;
        }

        protected override IController[] GetDependencies()
        {
            return new IController[]
            {
                new SaveDataController()
            };
        }

        protected override IEnumerator StartInit()
        {
            CreateEventSystem();
            yield return null;
        }
        private void CreateEventSystem()
        {
            GameObject obj = new GameObject("Event System");
            obj.AddComponent<EventSystem>();
            obj.AddComponent<StandaloneInputModule>();
            GameObject.DontDestroyOnLoad(obj);
        }
        

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

