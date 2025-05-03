using NUnit.Framework;
using UnityEngine;

public interface ISpawnPointStrategy 
{
    Transform NextSpawnPoint();
}
