using System.Numerics;
using System.Runtime.InteropServices;

namespace Raylib_CSharp.CSharp.Collision;

[StructLayout(LayoutKind.Sequential)]
public struct Ray {

    /// <summary>
    /// Ray, ray for RayCasting.
    /// </summary>
    public Ray(Vector3 position, Vector3 direction) {
        this.Position = position;
        this.Direction = direction;
    }

    /// <summary>
    /// Ray position (origin).
    /// </summary>
    public Vector3 Position;

    /// <summary>
    /// Ray direction.
    /// </summary>
    public Vector3 Direction;
}