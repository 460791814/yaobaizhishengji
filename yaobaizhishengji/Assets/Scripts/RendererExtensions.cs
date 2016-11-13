using UnityEngine;
using System.Collections;

public static class RendererExtensions 
{
    public static bool IsVisibleForm(this Renderer render, Camera camera)
    {
        Plane[] planes = GeometryUtility.CalculateFrustumPlanes(camera);
        return GeometryUtility.TestPlanesAABB(planes,render.bounds);
    }
}
