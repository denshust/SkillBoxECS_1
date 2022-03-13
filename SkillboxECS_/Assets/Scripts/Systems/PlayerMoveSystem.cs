using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class PlayerMoveSystem : ComponentSystem
{
    private EntityQuery _query;

    protected override void OnCreate()
    {
        _query = GetEntityQuery(ComponentType.ReadOnly<PlayerMoveComponent>());
    }

    protected override void OnUpdate()
    {
        Entities.With(_query).ForEach((Entity entity, Transform transform, PlayerMoveComponent moveComp) =>
        {
            var position = transform.position;
            Vector3 direction = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
                position += direction.normalized * moveComp.moveSpeed / 100;
            transform.position = position;
        });
    }
}
