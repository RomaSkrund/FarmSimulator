using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    public interface IVegitable
    {
        int VegitableCost { get; }
        GameObject VegitablePrefab { get; }
        float GrowSpeed { get; }
    }
}
