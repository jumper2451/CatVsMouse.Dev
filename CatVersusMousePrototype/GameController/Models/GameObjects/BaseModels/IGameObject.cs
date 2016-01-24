﻿using System.ComponentModel;

namespace GameController.Models.GameObjects.BaseModels
{
    public interface IGameObject :INotifyPropertyChanged
    {
        int X { get; set; }
        int Y { get; set; }
    }
}