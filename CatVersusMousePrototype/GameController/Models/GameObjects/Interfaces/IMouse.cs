﻿using System.Windows.Media;
using GameController.Models.GameObjects.BaseModels;

namespace GameController.Models.GameObjects.Interfaces
{
    public interface IMouse : IMoveableGameObject
    {
        Brush Color { get; set; }
    }
}