
#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
#endif
 
public class SquarePrimitive { 
#if UNITY_EDITOR
    private static Mesh CreateMesh() {
        Vector3[] vertices = {
            new Vector3(0f, 0f, 0),
            new Vector3(0f, 1f, 0),
            new Vector3(1f, 0f, 0),
            new Vector3(1f, 1f, 0)
            
        };
 
        Vector2[] uv = {
            new Vector2(0, 0),
            new Vector2(1, 0),
            new Vector2(0f, 1),
            new Vector2(1f, 1)
        }; 
 
        int[] tris = new int[6]
        {
            // lower left triangle
            0, 2, 1,
            // upper right triangle
            2, 3, 1
        };
        var mesh = new Mesh();
        mesh.vertices = vertices;
        mesh.uv = uv;
        mesh.triangles = tris;
        //mesh.triangles = parallelogram;
        mesh.RecalculateBounds();
        mesh.RecalculateNormals();
        mesh.RecalculateTangents();
        return mesh;
    }
 
    private static GameObject CreateObject() {
        var obj = new GameObject("Square");
        var mesh = CreateMesh();
        var filter = obj.AddComponent<MeshFilter>();
        var renderer = obj.AddComponent<MeshRenderer>();
        var collider = obj.AddComponent<MeshCollider>();
 
        filter.sharedMesh = mesh;
        collider.sharedMesh = mesh;
        renderer.sharedMaterial = AssetDatabase.GetBuiltinExtraResource<Material>("Default-Material.mat");
 
        return obj;
    }
 
    [MenuItem("GameObject/3D Object/Square", false, 0)]
    public static void Create() {
        CreateObject();
    }
#endif
}