using UnityEngine;
using Zenject;

public class GameInstallers : MonoInstaller
{
    public override void InstallBindings()
    {
        Container.Bind<bird>().FromComponentInHierarchy().AsSingle().NonLazy();
        Container.Bind<camera>().FromComponentInHierarchy().AsSingle().NonLazy();
        Container.Bind<GameManager>().FromComponentInHierarchy().AsSingle().NonLazy();
        Container.Bind<game_UIManager>().FromComponentInHierarchy().AsSingle().NonLazy();
        //Container.Bind<setting_UIManager>().FromComponentInHierarchy().AsSingle().NonLazy();
    }
}