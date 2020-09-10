﻿using Unity.Entities;
using Unity.Mathematics;

[GenerateAuthoringComponent]
public struct PlayerInitialization : IComponentData
{
    public Entity PlayerPrefab;
    public Entity HumanPlayerArrowPreview;
    public bool AIOnly;
    public int PlayerCount;
}
