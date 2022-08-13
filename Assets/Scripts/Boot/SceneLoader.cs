using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ExampleGame.Boot
{
    public class SceneLoader : BaseLoader<SceneLoader>
    {
        protected override string SplashScene => "SplashScreen";
    }
}