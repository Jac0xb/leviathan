using System;
using System.Collections.Generic;
using System.Text;

namespace leviathan.worldobjects.traits
{
    public interface IShakable: IItem
    {
        void Shake();
        bool isShook();
    }
}
