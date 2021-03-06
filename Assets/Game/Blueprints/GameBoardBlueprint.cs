﻿using Assets.Game.Components;
using EcsRx.Blueprints;
using EcsRx.Entities;
using EcsRx.Unity.Components;

namespace Assets.Game.Blueprints
{
    public class GameBoardBlueprint : IBlueprint
    {
        private readonly int _width;
        private readonly int _height;

        public GameBoardBlueprint(int width = 8, int height = 8)
        {
            _width = width;
            _height = height;
        }

        public void Apply(IEntity entity)
        {
            var gameBoardComponent = new GameBoardComponent
            {
                Width = _width,
                Height = _height
            };

            entity.AddComponent(gameBoardComponent);
            entity.AddComponent<ViewComponent>();
        }
    }
}