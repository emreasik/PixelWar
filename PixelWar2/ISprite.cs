using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PixelWar2
{
    interface ISprite
    {
        Size SpriteSize { get; } //canavarların hitbox ı tutulur
    }
}
